using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.Sap;
using AppService.Core.Entities;
using AppService.Core.Enumerations;
using AppService.Core.Exceptions;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Utility;
using AutoMapper;
using Microsoft.Extensions.Options;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class GeneralCobranzaService : IGeneralCobranzaService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly PaginationOptions _paginationOptions;

        private readonly IMapper _mapper;
        private readonly IMtrClienteService _mtrClienteService;
        private readonly IMtrVendedorService _mtrVendedorService;
        private readonly IMtrBancosService _mtrBancosService;
        private readonly ICobTipoTransaccionService _cobTipoTransaccionService;
        private readonly IMtrTipoMonedaService _mtrTipoMonedaService;
        private readonly ICobEstadoCuentaService _cobEstadoCuentaService;
        private readonly ICobTransaccionesService _cobTransaccionesService;
        private readonly ISapRetencionesService _sapRetencionesService;
        private readonly ICobGrabacionCobranzasService _cobGrabacionCobranzasService;
        private readonly IMtrOficinaService _mtrOficinaService;
        private readonly ICobAdjuntosCobranzaService _cobAdjuntosCobranzaService;
        private readonly IAppConfigAppService _appConfigAppService;
        private readonly ICobSysfileService _cobSysfileService;


        public GeneralCobranzaService(IUnitOfWork unitOfWork,
                                      IOptions<PaginationOptions> options,
                                       IMapper mapper,
                                       IMtrClienteService mtrClienteService,
                                       IMtrVendedorService mtrVendedorService,
                                       IMtrBancosService mtrBancosService,
                                       ICobTipoTransaccionService cobTipoTransaccionService,
                                       IMtrTipoMonedaService mtrTipoMonedaService,
                                       ICobEstadoCuentaService cobEstadoCuentaService,
                                       ICobTransaccionesService cobTransaccionesService,
                                       ISapRetencionesService sapRetencionesService,
                                       ICobGrabacionCobranzasService cobGrabacionCobranzasService,
                                       IMtrOficinaService mtrOficinaService,
                                        ICobAdjuntosCobranzaService cobAdjuntosCobranzaService,
                                        IAppConfigAppService appConfigAppService,
                                        ICobSysfileService cobSysfileService

                                      )
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;
            _mtrClienteService = mtrClienteService;
            _mtrVendedorService = mtrVendedorService;
            _mtrBancosService = mtrBancosService;
            _cobTipoTransaccionService = cobTipoTransaccionService;
            _mtrTipoMonedaService = mtrTipoMonedaService;
            _cobEstadoCuentaService = cobEstadoCuentaService;
            _cobTransaccionesService = cobTransaccionesService;
            _sapRetencionesService = sapRetencionesService;
            _cobGrabacionCobranzasService = cobGrabacionCobranzasService;
            _mtrOficinaService = mtrOficinaService;
            _cobAdjuntosCobranzaService = cobAdjuntosCobranzaService;
            _appConfigAppService = appConfigAppService;
            _cobSysfileService = cobSysfileService;



        }



        public async Task<IEnumerable<CobGeneralCobranza>> GetGeneralCobranza(GeneralCobranzaQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            //var cobranzasUpdate = await _unitOfWork.GeneralCobranzaRepository.ListCobranzaPorUsuario(filters);

            //await UpdateSearchText();
            filters.PageSize = 100;
            IEnumerable <CobGeneralCobranza> cobranzas = await _unitOfWork.GeneralCobranzaRepository.ListCobranzaPorUsuario(filters);







            if (filters.IdCliente != null)
            {
                cobranzas = cobranzas.Where(x => x.IdCliente == filters.IdCliente);
            }


            if (filters.IdBanco != null)
            {
                cobranzas = cobranzas.Where(x => x.IdBanco == filters.IdBanco);

            }

            if (filters.IdTipoTransaccion != null)
            {
                cobranzas = cobranzas.Where(x => x.IdTipoTransaccion == filters.IdTipoTransaccion);

            }

            if (filters.FechaTransaccion != null)
            {
                cobranzas = cobranzas.Where(x => x.FechaTransaccion.ToShortDateString() == filters.FechaTransaccion?.ToShortDateString());

            }


            if (filters.UsuarioRegistro != null)
            {
                cobranzas = cobranzas.Where(x => x.UsuarioRegistro == filters.UsuarioRegistro);

            }

            if (filters.Documento > 0)
            {
                cobranzas = cobranzas.Where(x => x.Documento == filters.Documento);

            }


            cobranzas = cobranzas.OrderByDescending(x => x.Documento);


            

            return cobranzas;
        }

        public async Task UpdateSearchText()
        {
            List<CobGeneralCobranza> cobGeneralCobranza = new List<CobGeneralCobranza>();
            cobGeneralCobranza = await _unitOfWork.GeneralCobranzaRepository.GetAllSearchTextBlanco();



            foreach (CobGeneralCobranza item in cobGeneralCobranza)
            {

                CobGeneralCobranza result = await UpdateGeneralCobranza(item);


            }

        }

        public async Task<IEnumerable<CobGeneralCobranza>> GetGeneralCobranzaPendienteVerificarPago(GeneralCobranzaQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;
            filters.PageSize = 200;

            IEnumerable<CobGeneralCobranza> cobranzas = await _unitOfWork.GeneralCobranzaRepository.ListCobranzaPorUsuarioPendienteVerificarPago(filters);

            // var cobranzas = await _unitOfWork.GeneralCobranzaRepository.ListCobranzaPorUsuario(filters);

            // cobranzas = cobranzas.Where(x => x.FlagEnviado == true && x.FlagAnulado==false && x.FlagConfirmado==false);

            return cobranzas;

        }
        public async Task<IEnumerable<CobGeneralCobranza>> GetGeneralCobranzaPendienteAprobarPago(GeneralCobranzaQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;
            filters.PageSize = 200;
            IEnumerable<CobGeneralCobranza> cobranzas = await _unitOfWork.GeneralCobranzaRepository.ListGeneralCobranzaPendienteAprobarPago(filters);

            //cobranzas = cobranzas.Where(x => x.FlagEnviado == true && x.FlagAnulado == false && x.FlagConfirmado == true && x.FlagAprobado==false);

            return cobranzas;

        }


        public async Task<CobGeneralCobranza> GetGeneralCobranzaPorDocumento(long documento)
        {
            return await _unitOfWork.GeneralCobranzaRepository.GetById(documento);
        }
        public async Task<Metadata> ValidaInsertCobranza(CobGeneralCobranza generalCobranza)
        {
            Metadata metadata = new Metadata();

            SegUsuario user = await _unitOfWork.SegUsuarioRepository.GetUser(generalCobranza.UsuarioRegistro);
            if (user == null)
            {

                metadata.IsValid = false;
                metadata.Message = "usuario no existe";
            }

            CobGeneralCobranza existenDocumentosPendientes = await _unitOfWork.GeneralCobranzaRepository.ExisteCobranzaPendienteEnviar(generalCobranza);
            if (existenDocumentosPendientes != null)
            {
                //throw new BusinessException("Este cliente ya tiene un RC abierto pendiente por enviar N° " + existenDocumentosPendientes.Documento.ToString() + ".Agregue la cobranza a este RC.Si es necesario grabar otro RC a este cliente, envíe el que está pendiente a la administradora.");
                metadata.IsValid = false;
                metadata.Message = "Este cliente ya tiene un RC abierto pendiente por enviar N° " + existenDocumentosPendientes.Documento.ToString() + ".Agregue la cobranza a este RC.Si es necesario grabar otro RC a este cliente, envíe el que está pendiente a la administradora.";
            }
            else
            {
                metadata.IsValid = true;
                metadata.Message = "";
            }


            return metadata;
        }


        public async Task<Metadata> ValidaUpdateCobranza(CobGeneralCobranza generalCobranza)
        {
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""
            };
            CobGrabacionCobranzas cambiaRcRu = await _unitOfWork.GeneralCobranzaRepository.RCRUYaTieneCobranzaGrabada(generalCobranza.Documento);
            if (cambiaRcRu != null && generalCobranza.IdTipoTransaccion == "RET")
            {
                //throw new BusinessException("Este cliente ya tiene un RC abierto pendiente por enviar N° " + existenDocumentosPendientes.Documento.ToString() + ".Agregue la cobranza a este RC.Si es necesario grabar otro RC a este cliente, envíe el que está pendiente a la administradora.");
                metadata.IsValid = false;
                metadata.Message = "Este recibo ya tiene cobranza registrada, para cambiarlo a retención debe eliminarla.";

            }

            CobGrabacionCobranzas cambiaRet = await _unitOfWork.GeneralCobranzaRepository.RETYaTieneCobranzaGrabada(generalCobranza.Documento);
            if (cambiaRet != null && generalCobranza.IdTipoTransaccion != "RET")
            {
                //throw new BusinessException("Este cliente ya tiene un RC abierto pendiente por enviar N° " + existenDocumentosPendientes.Documento.ToString() + ".Agregue la cobranza a este RC.Si es necesario grabar otro RC a este cliente, envíe el que está pendiente a la administradora.");
                metadata.IsValid = false;
                metadata.Message = "Este recibo ya tiene retenciones registradas, para cambiarla a cobranza debe eliminarla.";
            }


            return metadata;
        }

        public async Task<DateTime?> FechaContabilizacion()
        {
            DateTime? fechaContabilizacion;
            CobSysfile Sysfile = new CobSysfile();
            Sysfile = await _cobSysfileService.GetById(1);
            if (DateTime.Today > Sysfile.FechaLmcxC)
            {
                fechaContabilizacion = Sysfile.FechaLmcxC;

            }
            else
            {

                fechaContabilizacion = DateTime.Now;
            }

            return fechaContabilizacion;

        }
        public async Task<CobGeneralCobranza> InsertGeneralCobranza(CobGeneralCobranza generalCobranza)
        {
            CobSysfile Sysfile = new CobSysfile();

            Sysfile = await _cobSysfileService.GetById(1);


            SegUsuario user = await _unitOfWork.SegUsuarioRepository.GetUser(generalCobranza.UsuarioRegistro);
            if (user == null)
            {
                throw new Exception("usuario no existe");
            }

            CobGeneralCobranza existenDocumentosPendientes = await _unitOfWork.GeneralCobranzaRepository.ExisteCobranzaPendienteEnviar(generalCobranza);
            if (existenDocumentosPendientes != null)
            {
                throw new BusinessException("Este cliente ya tiene un RC abierto pendiente por enviar N° " + existenDocumentosPendientes.Documento.ToString() + ".Agregue la cobranza a este RC.Si es necesario grabar otro RC a este cliente, envíe el que está pendiente a la administradora.");
            }
            MtrCliente cliente = await _mtrClienteService.GetByIdAsync(generalCobranza.IdCliente);
            MtrVendedor vendedor = await _mtrVendedorService.GetByIdAsync(cliente.Vendedor1);

            string vIn = cliente.OficinaVenta;
            short vOut = Convert.ToInt16(vIn);

            MtrOficina mtrOficina = await _mtrOficinaService.GetOficina(vOut);

            generalCobranza.SearchText = generalCobranza.IdCliente + "-" + cliente.Nombre + "-" + vendedor.Nombre + "-" + generalCobranza.Documento.ToString() + "-" + mtrOficina.NomOficina.Trim();
            generalCobranza.OficinaVenta = cliente.OficinaVenta;
            generalCobranza.FechaLm = generalCobranza.FechaTransaccion;
            generalCobranza.FechaLmcxC = generalCobranza.FechaTransaccion;
            //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LM COMISIONES) Y LA///////////
            //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
            var fechaTransaccionString = generalCobranza.FechaTransaccion.ToString("d");
            DateTime fechaTransaccion = Convert.ToDateTime(fechaTransaccionString);
            if ((DateTime.Today > Sysfile.FechaLm) && fechaTransaccion <= Sysfile.FechaLm)
            {
                generalCobranza.FechaLm = Sysfile.FechaLm;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LMCxC) Y LA///////////////////
            //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
            if ((DateTime.Today > Sysfile.FechaLmcxC) && fechaTransaccion <= Sysfile.FechaLmcxC)
            {
                generalCobranza.FechaLmcxC = Sysfile.FechaLmcxC;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////


            generalCobranza.FechaLmcxC = await FechaContabilizacion();
            generalCobranza.FechaLm = await FechaContabilizacion();

            await _unitOfWork.GeneralCobranzaRepository.Add(generalCobranza);
            await _unitOfWork.SaveChangesAsync();


            CobGeneralCobranza result = await UpdateGeneralCobranza(generalCobranza);

            return result;
        }


        public async Task<CobGeneralCobranza> UpdateGeneralCobranza(CobGeneralCobranza generalCobranza)
        {
            CobSysfile Sysfile = new CobSysfile();

            Sysfile = await _cobSysfileService.GetById(1);

            CobGeneralCobranza cobranza = await GetGeneralCobranzaPorDocumento(generalCobranza.Documento);
            if (cobranza == null)
            {
                throw new Exception("Documento No existe");
            }

            MtrCliente cliente = await _mtrClienteService.GetByIdAsync(generalCobranza.IdCliente);
            MtrVendedor vendedor = await _mtrVendedorService.GetByIdAsync(cliente.Vendedor1);

            string vIn = cliente.OficinaVenta;
            short vOut = Convert.ToInt16(vIn);

            MtrOficina mtrOficina = await _mtrOficinaService.GetOficina(vOut);

            string statusString = EstatusRecibo(generalCobranza);

            if (vendedor != null)
            {
                cobranza.SearchText = cobranza.IdCliente + "-" + cliente.Nombre.Trim() + "-" + vendedor.Nombre.Trim() + "-" + cobranza.Documento.ToString() + "-" + statusString + "-Ofic " + mtrOficina.NomOficina.Trim();

            }
            else
            {
                cobranza.SearchText = cobranza.IdCliente + "-" + cliente.Nombre.Trim() + "-" + cobranza.Documento.ToString() + "-" + statusString + "-Ofic " + mtrOficina.NomOficina.Trim();

            }

            cobranza.IdCliente = generalCobranza.IdCliente;
            cobranza.IdMtrTipoMoneda = generalCobranza.IdMtrTipoMoneda;
            cobranza.MontoTransaccion = generalCobranza.MontoTransaccion;
            cobranza.IdTipoTransaccion = generalCobranza.IdTipoTransaccion;
            cobranza.IdBanco = generalCobranza.IdBanco;
            cobranza.FechaTransaccion = generalCobranza.FechaTransaccion;
            cobranza.FechaLm = cobranza.FechaTransaccion;
            cobranza.FechaLmcxC = cobranza.FechaTransaccion;
            cobranza.NumReferencia = generalCobranza.NumReferencia;
            cobranza.EmailCliente = generalCobranza.EmailCliente;
            cobranza.FechaRegistro = generalCobranza.FechaRegistro;
            cobranza.UsuarioRegistro = generalCobranza.UsuarioRegistro;
            cobranza.OficinaVenta = cliente.OficinaVenta;

            cobranza.TotalDetalleCobrado = cobranza.MontoTransaccion - _cobGrabacionCobranzasService.TotalDetalleRecibo(cobranza.Documento);

            //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LM COMISIONES) Y LA///////////
            //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
            var fechaTransaccionString = cobranza.FechaTransaccion.ToString("d");
            DateTime fechaTransaccion = Convert.ToDateTime(fechaTransaccionString);
            if ((DateTime.Today > Sysfile.FechaLm) && fechaTransaccion <= Sysfile.FechaLm)
            {
                cobranza.FechaLm = Sysfile.FechaLm;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LMCxC) Y LA///////////////////
            //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
            if ((DateTime.Today > Sysfile.FechaLmcxC) && fechaTransaccion <= Sysfile.FechaLmcxC)
            {
                cobranza.FechaLmcxC = Sysfile.FechaLmcxC;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            generalCobranza.FechaLmcxC = await FechaContabilizacion();
            generalCobranza.FechaLm = await FechaContabilizacion();
            await _unitOfWork.GeneralCobranzaRepository.Update(cobranza);
            await _unitOfWork.SaveChangesAsync();

            return await GetGeneralCobranzaPorDocumento(generalCobranza.Documento);

        }

        public async Task<bool> DeleteGeneralCobranza(long documento)
        {
            CobGeneralCobranza cobranza = await GetGeneralCobranzaPorDocumento(documento);
            if (cobranza == null)
            {
                throw new Exception("Documento No existe");
            }


            await _unitOfWork.GeneralCobranzaRepository.Delete(documento);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }


        public Metadata GeneraPdfRecibo(ReciboDto reciboDto, string sufijoFileName)
        {

            Metadata metadata = new Metadata
            {
                Message = "",
                IsValid = false
            };

            try
            {

                string html = TemplateGenerator.GetHTMLStringRecibo(reciboDto);


                HtmlToPdf oHtmlToPdf = new HtmlToPdf();

                oHtmlToPdf.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
                oHtmlToPdf.Options.MarginLeft = 10;
                oHtmlToPdf.Options.MarginRight = 10;
                oHtmlToPdf.Options.MarginTop = 20;
                oHtmlToPdf.Options.MarginBottom = 20;

                PdfDocument oPdfDocument = oHtmlToPdf.ConvertHtmlString(html);

                byte[] pdf = oPdfDocument.Save();
                oPdfDocument.Close();
                string ruta = _paginationOptions.FolderDocumentation + "\\";
                string fileName = "RC_" + reciboDto.CobGeneralCobranzaDto.Documento.ToString() + sufijoFileName + ".pdf";
                //string imageFullName = @"D:\Moore\Adjuntos\ListRecibos_Report.pdf";
                string imageFullName = ruta + fileName;
                //creo el fichero
                System.IO.File.WriteAllBytes(imageFullName, pdf);


                //CREA EL RECIBO EN FORMATO JPG
                //string rutaImage = _paginationOptions.FolderDocumentation + "\\";
                //fileName = "RC_" + reciboDto.CobGeneralCobranzaDto.Documento.ToString() + sufijoFileName + ".jpg";
                //imageFullName = rutaImage + fileName;
                //var converter = new HtmlConverter();

                //var bytes = converter.FromHtmlString(html, 1024, ImageFormat.Jpg, 100);
                //System.IO.File.WriteAllBytes(imageFullName, bytes);

                metadata.Message = "";
                metadata.IsValid = true;

                return metadata;

            }
            catch (Exception e)
            {
                string message = e.InnerException.Message;
                metadata.Message = message;
                metadata.IsValid = false;

                return metadata;

            }



        }

        public async Task<ReciboDto> GeneraReciboDto(long recibo)
        {

            ReciboDto result = new ReciboDto();
            CobGeneralCobranza cobGeneralCobranza = new CobGeneralCobranza();
            List<CobGrabacionCobranzas> listaCobGrabacionCobranzas = new List<CobGrabacionCobranzas>();
            try
            {

                //Crea Objeto General cobranzas
                cobGeneralCobranza = await GetGeneralCobranzaPorDocumento(recibo);
                CobGeneralCobranzaDto generalCobranzasDtos = _mapper.Map<CobGeneralCobranzaDto>(cobGeneralCobranza);

                MtrCliente cliente = await _mtrClienteService.GetByIdAsync(generalCobranzasDtos.IdCliente);
                MtrVendedor vendedor = await _mtrVendedorService.GetByIdAsync(cliente.Vendedor1);
                generalCobranzasDtos.NombreCliente = cliente.NoRegTribut + " " + cliente.Nombre.Trim();
                generalCobranzasDtos.IdCliente = generalCobranzasDtos.IdCliente.Trim();
                generalCobranzasDtos.FechaTransaccionString = generalCobranzasDtos.FechaTransaccion.ToShortDateString();
                generalCobranzasDtos.NombreVendedor = vendedor.Nombre;
                generalCobranzasDtos.vendedor = vendedor.Codigo;
                generalCobranzasDtos.CorreoVendedor = vendedor.EMail;
                generalCobranzasDtos.TelefonoVendedor = vendedor.TlfCelular;





                decimal decimalValue = generalCobranzasDtos.MontoTransaccion;
                generalCobranzasDtos.MontoTransaccionString = string.Format("{0:N}", decimalValue); // 1,234,567.00


                //creamos el objeto
                Moneda oMoneda = new Moneda();

                //primer parametro es la cantidad en string
                //segundo parametro es si queremos que sea mayuscula
                //tercer parametro la moneda


                MtrTipoMoneda tipoMoneda = await _mtrTipoMonedaService.GetById((long)cobGeneralCobranza.IdMtrTipoMoneda);
                string MonedaString = tipoMoneda.Descripcion;



                string resultado = oMoneda.Convertir(generalCobranzasDtos.MontoTransaccion.ToString(), true, MonedaString);
                generalCobranzasDtos.MontoLetras = resultado;


                decimal? detalleValue = generalCobranzasDtos.TotalDetalleCobrado;
                generalCobranzasDtos.TotalDetalleCobradoString = string.Format("{0:N}", detalleValue);
                generalCobranzasDtos.Status = EstatusRecibo(cobGeneralCobranza);

                MtrBancos banco = await _mtrBancosService.GetByCodigo(generalCobranzasDtos.IdBanco);
                generalCobranzasDtos.NombreBanco = banco.Nombre;

                CobTipoTransaccion tipoTransaccion = await _cobTipoTransaccionService.GetById(generalCobranzasDtos.IdTipoTransaccion);
                generalCobranzasDtos.NombreTipoTransaccion = tipoTransaccion.NombreTipoTransaccion;
                generalCobranzasDtos.FlagImpuesto = tipoTransaccion.FlagImpuesto;


                MtrTipoMoneda mtrTipoMoneda = await _mtrTipoMonedaService.GetById((long)generalCobranzasDtos.IdMtrTipoMoneda);
                generalCobranzasDtos.NombreTipoMoneda = mtrTipoMoneda.Descripcion;



                listaCobGrabacionCobranzas = _unitOfWork.CobGrabacionCobranzasRepository.GetByDocumento(recibo);
                listaCobGrabacionCobranzas = listaCobGrabacionCobranzas.Where(x => x.DocumentoSap == "").ToList();

                List<CobGrabacionCobranzaDto> listaCobGrabacionCobranzasDto = _mapper.Map<List<CobGrabacionCobranzaDto>>(listaCobGrabacionCobranzas);

                foreach (CobGrabacionCobranzaDto item in listaCobGrabacionCobranzasDto)
                {
                    item.CuentaBancaria = banco.CodContable;
                    item.Moneda = mtrTipoMoneda.Descripcion;
                    if (item.Transaccion == "RU")
                    {
                        item.DocAfectaMostrar = item.Cotizacion;
                    }
                    else
                    {
                        item.DocAfectaMostrar = item.DocAfectaSap;

                    }

                    decimalValue = (decimal)item.Monto;
                    item.MontoMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00

                    CobEstadoDeCuenta cobEstadoDeCuenta = await _cobEstadoCuentaService.GetEstadoCuentaById(item.DocAfecta);

                    if (cobEstadoDeCuenta != null)
                    {
                        decimalValue = (decimal)cobEstadoDeCuenta.BaseImponible;
                        item.BaseImponible = (decimal)cobEstadoDeCuenta.BaseImponible;
                        item.BaseImponibleMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00
                        decimalValue = (decimal)cobEstadoDeCuenta.Iva;
                        item.Iva = (decimal)cobEstadoDeCuenta.Iva;
                        item.IvaMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00
                        decimalValue = (decimal)cobEstadoDeCuenta.MontoOriginal;

                        item.MontoOriginalMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00
                        item.FechaDocumento = cobEstadoDeCuenta.FechaDocumento;
                        DateTime fechaDocumento = (DateTime)cobEstadoDeCuenta.FechaDocumento;
                        item.FechaDocumentoString = fechaDocumento.ToShortDateString();

                    }

                    //List<CobPagosRetencionesDto> listCobPagosRetencionesDto = new List<CobPagosRetencionesDto>();
                    List<CobPagosRetenciones> listCobPagosRetenciones = _unitOfWork.CobPagosRetencionesRepository.GetByIdCobranzas(item.Id);

                    List<CobPagosRetencionesDto> listCobPagosRetencionesDto = _mapper.Map<List<CobPagosRetencionesDto>>(listCobPagosRetenciones);

                    if (listCobPagosRetencionesDto != null && listCobPagosRetencionesDto.Count > 0)
                    {
                        foreach (CobPagosRetencionesDto itemRet in listCobPagosRetencionesDto)
                        {
                            decimalValue = itemRet.Monto;
                            itemRet.MontoString = string.Format("{0:N}", decimalValue); // 1,234,567.00

                            CobTransacciones transaccion = await _cobTransaccionesService.GetById(itemRet.IdTransaccion);
                            if (transaccion != null)
                            {
                                itemRet.NombreTransaccion = transaccion.NombreTransaccion;
                                itemRet.TxOrigen = transaccion.TipoSap;
                            }
                            itemRet.FechaComprobanteString = itemRet.FechaComprobante.ToShortDateString();

                        }

                    }


                    item.CobPagosRetencionesDto = listCobPagosRetencionesDto;





                }

                var  fecha= await FechaContabilizacion();
                generalCobranzasDtos.FechaLm = fecha;
                generalCobranzasDtos.FechaLmcxC= (DateTime)fecha;


                result.CobGeneralCobranzaDto = generalCobranzasDtos;
                result.CobGrabacionCobranzaDto = listaCobGrabacionCobranzasDto;
                    
                return result;
            }
            catch (Exception e)
            {
                string message = e.Message;
                throw;
            }



        }

        public async Task<List<ReciboEnviarSapDto>> GeneraListObjectSap(ReciboDto reciboDto)
        {
            List<ReciboEnviarSapDto> result = new List<ReciboEnviarSapDto>();
            try
            {
                foreach (CobGrabacionCobranzaDto item in reciboDto.CobGrabacionCobranzaDto)
                {
                    ReciboEnviarSapDto itemContenedorresult = new ReciboEnviarSapDto();

                    d itemResult = new d
                    {
                        Id = item.Id,
                        Transaccion = item.Transaccion,

                        NroRecibo = (long)item.Documento,
                        Sociedad = "1000",
                        Cliente = reciboDto.CobGeneralCobranzaDto.IdCliente
                    };
                    if (item.DocAfectaSap != null)
                    {
                        itemResult.DocCobroSAP = item.DocAfectaSap;
                    }
                    else
                    {
                        itemResult.DocCobroSAP = "";
                    }


                    string año = reciboDto.CobGeneralCobranzaDto.FechaTransaccion.Year.ToString();
                    string mes = "00" + reciboDto.CobGeneralCobranzaDto.FechaTransaccion.Month.ToString();
                    mes = mes.Substring(mes.Length - 2, 2);
                    string dia = reciboDto.CobGeneralCobranzaDto.FechaTransaccion.Day.ToString();
                    itemResult.FechaCobroReal = $"{año}-{mes}-{dia}T00:00";

                    año = reciboDto.CobGeneralCobranzaDto.FechaLmcxC.Year.ToString();
                    mes = "00" + reciboDto.CobGeneralCobranzaDto.FechaLmcxC.Month.ToString();
                    mes = mes.Substring(mes.Length - 2, 2);
                    dia = reciboDto.CobGeneralCobranzaDto.FechaLmcxC.Day.ToString();
                    itemResult.FechaContabilizacion = $"{año}-{mes}-{dia}T00:00";
                    if (reciboDto.CobGeneralCobranzaDto.NumReferencia.ToString().Length >=8)
                    {
                        itemResult.Referencia = reciboDto.CobGeneralCobranzaDto.NumReferencia.ToString().Substring(reciboDto.CobGeneralCobranzaDto.NumReferencia.ToString().Length - 8); ;

                    }
                    else
                    {
                        itemResult.Referencia = reciboDto.CobGeneralCobranzaDto.NumReferencia.ToString();
                    }
                    itemResult.TextoCab = item.CuentaBancaria;

                    itemResult.CuentaBancaria = item.CuentaBancaria;
                    if (item.Cotizacion.Length > 0)
                    {
                        itemResult.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap + "Cot: " + item.Cotizacion;
                    }
                    else
                    {
                        itemResult.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap;
                    }


                    itemResult.Monto = item.Monto.ToString();
                    itemResult.Moneda = item.Moneda;
                    List<RetencionesCobranza> retencionesCobranzas = new List<RetencionesCobranza>();
                    if (item.CobPagosRetencionesDto != null)
                    {

                        foreach (CobPagosRetencionesDto itemretenciones in item.CobPagosRetencionesDto)
                        {
                            string refe = "";
                            
                            if (itemretenciones.NroComprobante.Length>=8)
                            {
                                refe = itemretenciones.NroComprobante.Substring(itemretenciones.NroComprobante.Length - 8);
                            }
                            else
                            {
                                refe = itemretenciones.NroComprobante;
                            } 
                               

                            RetencionesCobranza itemRetencionesCobranzas = new RetencionesCobranza
                            {
                                TxOrigen = itemretenciones.TxOrigen,
                                
                                Referencia = refe,
                                TextoCab = item.CuentaBancaria
                            };

                            if (item.Cotizacion.Length > 0)
                            {
                                itemRetencionesCobranzas.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap + "Cot: " + item.Cotizacion;
                            }
                            else
                            {
                                itemRetencionesCobranzas.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap;
                            }

                            itemRetencionesCobranzas.Monto = itemretenciones.Monto.ToString();
                            var monedaLocalCobro = await _appConfigAppService.GetByKey("MONEDALOCALCOBRO");
                            itemRetencionesCobranzas.Moneda = monedaLocalCobro.Valor; //"VES o VED";


                            SapRetenciones sapRetenciones = _sapRetencionesService.GetByTranzaccionPorcentaje(itemretenciones.IdTransaccion, (double)itemretenciones.Porcentaje);

                            itemRetencionesCobranzas.IndRetencion = sapRetenciones.IndicadordeRetencion;


                            if (itemretenciones.TxOrigen == "06")
                            {
                                itemRetencionesCobranzas.BaseRetencion = item.Iva.ToString();
                            }
                            else
                            {
                                itemRetencionesCobranzas.BaseRetencion = item.BaseImponible.ToString();
                            }

                            retencionesCobranzas.Add(itemRetencionesCobranzas);






                        }



                    }
                    else
                    {
                        RetencionesCobranza itemRetencionesCobranzas = new RetencionesCobranza();
                        itemResult.RetencionesCobranza.Add(itemRetencionesCobranzas);
                    }

                    //itemResult.RetencionesCobranza.Add(retencionesCobranzas);

                    itemContenedorresult.d = itemResult;
                    itemContenedorresult.d.RetencionesCobranza = retencionesCobranzas;
                    result.Add(itemContenedorresult);

                }
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                throw;
            }



            return result;
        }

        public async Task<List<AppService.Core.DTOs.SapEnviarSoloRetencion.Application>> GeneraListSapEnviarSoloRetencion(ReciboDto reciboDto)
        {
            List<AppService.Core.DTOs.SapEnviarSoloRetencion.Application> result = new List<AppService.Core.DTOs.SapEnviarSoloRetencion.Application>();
            try
            {
                foreach (CobGrabacionCobranzaDto item in reciboDto.CobGrabacionCobranzaDto)
                {
                    ReciboEnviarSapDto itemContenedorresult = new ReciboEnviarSapDto();

                    d itemResult = new d
                    {
                        Id = item.Id,
                        Transaccion = item.Transaccion,

                        NroRecibo = (long)item.Documento,
                        Sociedad = "1000",
                        Cliente = reciboDto.CobGeneralCobranzaDto.IdCliente
                    };
                    if (item.DocAfectaSap != null)
                    {
                        itemResult.DocCobroSAP = item.DocAfectaSap;
                    }
                    else
                    {
                        itemResult.DocCobroSAP = "";
                    }


                    string año = reciboDto.CobGeneralCobranzaDto.FechaTransaccion.Year.ToString();
                    string mes = "00" + reciboDto.CobGeneralCobranzaDto.FechaTransaccion.Month.ToString();
                    mes = mes.Substring(mes.Length - 2, 2);
                    string dia = reciboDto.CobGeneralCobranzaDto.FechaTransaccion.Day.ToString();
                    itemResult.FechaCobroReal = $"{año}-{mes}-{dia}T00:00";

                    año = reciboDto.CobGeneralCobranzaDto.FechaLmcxC.Year.ToString();
                    mes = "00" + reciboDto.CobGeneralCobranzaDto.FechaLmcxC.Month.ToString();
                    mes = mes.Substring(mes.Length - 2, 2);
                    dia = reciboDto.CobGeneralCobranzaDto.FechaLmcxC.Day.ToString();
                    itemResult.FechaContabilizacion = $"{año}-{mes}-{dia}T00:00";
                    var refConvert= reciboDto.CobGeneralCobranzaDto.NumReferencia.ToString();
                    if (refConvert.Length>=8)
                    {
                        itemResult.Referencia = refConvert.Substring(refConvert.Length - 8);
                    }
                    else
                    {
                        itemResult.Referencia = reciboDto.CobGeneralCobranzaDto.NumReferencia.ToString(); ;
                    }
                    
                    itemResult.TextoCab = item.CuentaBancaria;

                    itemResult.CuentaBancaria = item.CuentaBancaria;
                    if (item.Cotizacion.Length > 0)
                    {
                        itemResult.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap + "Cot: " + item.Cotizacion;
                    }
                    else
                    {
                        itemResult.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap;
                    }


                    itemResult.Monto = item.Monto.ToString();
                    itemResult.Moneda = item.Moneda;
                    List<RetencionesCobranza> retencionesCobranzas = new List<RetencionesCobranza>();
                    if (item.CobPagosRetencionesDto != null)
                    {

                        foreach (CobPagosRetencionesDto itemretenciones in item.CobPagosRetencionesDto)
                        {
                            RetencionesCobranza itemRetencionesCobranzas = new RetencionesCobranza();

                            AppService.Core.DTOs.SapEnviarSoloRetencion.Application itemAplication = new AppService.Core.DTOs.SapEnviarSoloRetencion.Application();

                            AppService.Core.DTOs.SapEnviarSoloRetencion.D itemD = new AppService.Core.DTOs.SapEnviarSoloRetencion.D();
                            itemRetencionesCobranzas.Id = itemretenciones.Id;
                            itemRetencionesCobranzas.TxOrigen = itemretenciones.TxOrigen;
                            
                            if (itemretenciones.NroComprobante.Length>=8)
                            {
                                itemRetencionesCobranzas.Referencia = itemretenciones.NroComprobante.Substring(itemretenciones.NroComprobante.Length - 8);
                            }
                            else
                            {
                                itemRetencionesCobranzas.Referencia = itemretenciones.NroComprobante;
                            }
                            
                            itemRetencionesCobranzas.TextoCab = item.CuentaBancaria;

                            if (item.Cotizacion.Length > 0)
                            {
                                itemRetencionesCobranzas.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap + "Cot: " + item.Cotizacion;
                            }
                            else
                            {
                                itemRetencionesCobranzas.TextoPos = "Doc: " + item.Documento.ToString() + " Canc: " + item.DocAfectaSap;
                            }

                            itemRetencionesCobranzas.Monto = itemretenciones.Monto.ToString();
                            var monedaLocalCobro = await _appConfigAppService.GetByKey("MONEDALOCALCOBRO");
                            itemRetencionesCobranzas.Moneda = monedaLocalCobro.Valor;


                            SapRetenciones sapRetenciones = _sapRetencionesService.GetByTranzaccionPorcentaje(itemretenciones.IdTransaccion, (double)itemretenciones.Porcentaje);

                            itemRetencionesCobranzas.IndRetencion = sapRetenciones.IndicadordeRetencion;


                            if (itemretenciones.TxOrigen == "06")
                            {
                                itemRetencionesCobranzas.BaseRetencion = item.Iva.ToString();
                            }
                            else
                            {
                                itemRetencionesCobranzas.BaseRetencion = item.BaseImponible.ToString();
                            }
                            itemD.Id = itemRetencionesCobranzas.Id;
                            itemD.NroRecibo = (int)itemResult.NroRecibo;
                            itemD.Sociedad = itemResult.Sociedad;
                            itemD.Cliente = itemResult.Cliente;
                            itemD.TxOrigen = itemRetencionesCobranzas.TxOrigen;
                            itemD.DocCobroSAP = itemResult.DocCobroSAP;
                            itemD.FechaCobroReal = itemResult.FechaCobroReal;
                            itemD.FechaContabilizacion = itemResult.FechaContabilizacion;
                            itemD.Referencia = itemRetencionesCobranzas.Referencia;
                            itemD.TextoCab = itemRetencionesCobranzas.TextoCab;
                            itemD.TextoPos = itemRetencionesCobranzas.TextoPos;
                            itemD.Monto = itemRetencionesCobranzas.Monto;
                            itemD.Moneda = itemRetencionesCobranzas.Moneda;
                            itemD.IndRetencion = itemRetencionesCobranzas.IndRetencion;
                            itemD.BaseRetencion = itemRetencionesCobranzas.BaseRetencion;
                            itemAplication.d = itemD;

                            result.Add(itemAplication);






                        }



                    }


                    //itemResult.RetencionesCobranza.Add(retencionesCobranzas);



                }
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                throw;
            }



            return result;
        }


        public string EstatusRecibo(CobGeneralCobranza cobranza)
        {
            string result = "";

            if (cobranza.FlagEnviado == false)
            {
                result = Enum.GetName(typeof(EstatusReciboEnum), EstatusReciboEnum.GRABACION);
            }
            if (cobranza.FlagEnviado == true)
            {
                result = Enum.GetName(typeof(EstatusReciboEnum), EstatusReciboEnum.ENVIADO_ADMINISTRACION);

            }
            if (cobranza.FlagConfirmado == true)
            {
                result = Enum.GetName(typeof(EstatusReciboEnum), EstatusReciboEnum.CONFIRMADO);

            }
            if (cobranza.FlagAprobado == true)
            {
                result = Enum.GetName(typeof(EstatusReciboEnum), EstatusReciboEnum.APROBADO);
            }
            if (cobranza.FlagAnulado == true)
            {
                result = Enum.GetName(typeof(EstatusReciboEnum), EstatusReciboEnum.ANULADO);
            }

            return result;



        }




        public async Task GeneraRecibo(long documento, string usuario)
        {

            CobGeneralCobranza generalCobranzas = await GetGeneralCobranzaPorDocumento(documento);
           // CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();
            CobAdjuntosCobranza Adjunto = new CobAdjuntosCobranza();
           // CobAdjuntosCobranza AdjuntoJpg = new CobAdjuntosCobranza();
            if (generalCobranzas != null)
            {


                ReciboDto recibo = await GeneraReciboDto(documento);
                Metadata geberaPdf = GeneraPdfRecibo(recibo, "_Consultado");
                if (geberaPdf.IsValid)
                {
                    var nombreArchivo= "RC_" + documento.ToString() + "_Consultado" + ".pdf";

                    await _cobAdjuntosCobranzaService.DeleteByNameFile(recibo.CobGeneralCobranzaDto.Documento, nombreArchivo);



                    //ADJUNTAMOS EL RC///////////////////////////////
                    Adjunto.Documento = documento;
                    Adjunto.IdTipoDocumento = 20;
                    Adjunto.NombreArchivo = nombreArchivo;
                    Adjunto.Archivo = null;
                    Adjunto.IdUsuarioCreacion = usuario;
                    Adjunto.FechaCreacion = DateTime.Now;
                    Adjunto.Ruta = _paginationOptions.FolderDocumentation + "\\";
                    //CobAdjuntosCobranza cobranzaAdjunto = await _cobAdjuntosCobranzaService.Insert(Adjunto);
                    await _cobAdjuntosCobranzaService.Insert(Adjunto);


                }


            }

        }
    }
}
