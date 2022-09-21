using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.SapEstadoCuentaResult;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobEstadoCuentaService : ICobEstadoCuentaService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ISapClient _sapClient;
        private readonly PaginationOptions _paginationOptions;

        public CobEstadoCuentaService(IUnitOfWork unitOfWork,
                                      IOptions<PaginationOptions> options,
                                      ISapClient sapClient)
        {
            _unitOfWork = unitOfWork;
            _sapClient = sapClient;
            _paginationOptions = options.Value;

        }



        public async Task<PagedList<CobEstadoDeCuenta>> GetEstadoCuenta(CobEstadoCuentaQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;
            filters.PageSize = 1000;

            //Busca Estado de Cuenta del cliente en Sap
            var estadoCuentaSap = await GetEstadoCuentaSap(filters.IdCliente);
            if (estadoCuentaSap != null)
            {
                //Actualiza Tabla CobEstadoCuenta con el estado de cuenta Sap
                await UpdateCobEstadoCuenta(estadoCuentaSap, filters.IdCliente);


                var estadoCuenta = await _unitOfWork.CobEstadoDeCuentaRepository.GetAllDocumentoMadre(filters.IdCliente);


                if (filters.Documento > 0)
                {
                    estadoCuenta = estadoCuenta.Where(x => x.Rpdoc == filters.Documento).ToList();

                }

                var pagedResult = PagedList<CobEstadoDeCuenta>.Create(estadoCuenta, filters.PageNumber, filters.PageSize);

                return pagedResult;
            }
            else
            {
                return null;
            }

        }

        public async Task GenerateEstadoCuentaMultimoneda()
        {


            string userSap = _paginationOptions.UserSap;
            string passwordSap = _paginationOptions.PasswordSap;
            string tokenSap = "";
            _unitOfWork.CobEstadoDeCuentaMultimonedaRepository.DeleteEstadoCuentaMultimoneda();

            var meta = await _sapClient.GetToken(userSap, passwordSap);
            if (meta.IsValid)
            {
                tokenSap = meta.Message;

            }
            string idCliente = "";
            var estadoCuentaSap = await GetEstadoCuentaSapMultimoneda(tokenSap);
            if (estadoCuentaSap != null)
            {
                await UpdateCobEstadoCuentaMultimoneda(estadoCuentaSap, idCliente);
                _unitOfWork.CobEstadoDeCuentaMultimonedaRepository.UpdateEstadoCuentaMultimoneda();
            }

            /*var clientes = await _unitOfWork.DwConsolidadoAnalisisDeVencimientoRepository.GetClientesConSaldo();
            foreach (var item in clientes)
            {
                string idCliente = item.Key.ToString();
               
                var estadoCuentaSap = await GetEstadoCuentaSapMultimoneda(idCliente, tokenSap);
                if (estadoCuentaSap != null)
                {
                    await UpdateCobEstadoCuentaMultimoneda(estadoCuentaSap, idCliente);

                }
            }*/


        }

        public async Task<PagedList<CobEstadoCuentaMultiMoneda>> GetEstadoCuentaMultimoneda(CobEstadoCuentaQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;
            filters.PageSize = 1000;
            string userSap = _paginationOptions.UserSap;
            string passwordSap = _paginationOptions.PasswordSap;
            string tokenSap = "";

            var meta = await _sapClient.GetToken(userSap, passwordSap);
            if (meta.IsValid)
            {
                tokenSap = meta.Message;

            }
            else
            {
                return null;
            }
            //Busca Estado de Cuenta del cliente en Sap
            var estadoCuentaSap = await GetEstadoCuentaSapMultimoneda(filters.IdCliente, tokenSap);
            if (estadoCuentaSap != null)
            {

                await UpdateCobEstadoCuentaMultimoneda(estadoCuentaSap, filters.IdCliente);

                var estadCta = await _unitOfWork.CobEstadoDeCuentaMultimonedaRepository.GetByCliente(filters.IdCliente);




                var pagedResult = PagedList<CobEstadoCuentaMultiMoneda>.Create(estadCta, filters.PageNumber, filters.PageSize);

                return pagedResult;
            }
            else
            {
                return null;
            }

        }


        public async Task<List<EstadoCuentaSap>> GetEstadoCuentaSap(string cliente)
        {


            string userSap = _paginationOptions.UserSap;
            string passwordSap = _paginationOptions.PasswordSap;
            string tokenSap = "";

            var meta = await _sapClient.GetToken(userSap, passwordSap);
            if (meta.IsValid)
            {
                tokenSap = meta.Message;

            }
            else
            {
                return null;
            }


            //string action = $"EstadoCuentaCliente?Sociedad='1000'&Cliente='{cliente}'&MostrarImportesMonedaDoc=true";
            string action = $"EstadoCuentaCliente?Sociedad='1000'&Cliente='{cliente}'&MostrarImportesMonedaDoc=false";

            var result = await _sapClient.GetEstadoCuenta(action, tokenSap);


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };
            AppService.Core.DTOs.SapEstadoCuentaResult.Application resultSapEstadoCuenta = new AppService.Core.DTOs.SapEstadoCuentaResult.Application();
            resultSapEstadoCuenta = JsonSerializer.Deserialize<AppService.Core.DTOs.SapEstadoCuentaResult.Application>(result.Message, options);
            List<EstadoCuentaSap> estadoCuentaSap = new List<EstadoCuentaSap>();
            foreach (var item in resultSapEstadoCuenta.d.results)
            {
                EstadoCuentaSap itemEstadoCuentaSap = new EstadoCuentaSap();

                itemEstadoCuentaSap.DocumentoSAP = item.DocumentoSAP;
                itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                itemEstadoCuentaSap.ClaseDoc = item.ClaseDoc;
                itemEstadoCuentaSap.Correlativo = item.Correlativo;
                itemEstadoCuentaSap.Cliente = item.Cliente;
                itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                itemEstadoCuentaSap.Moneda = item.Moneda;
                var valor = long.Parse(GetSubStringByString("(", ")", item.FechaDoc));
                var fecha = DateTimeOffset.FromUnixTimeMilliseconds(valor).DateTime;
                itemEstadoCuentaSap.FechaDoc = fecha;
                fecha = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(GetSubStringByString("(", ")", item.FechaVencimiento))).DateTime;
                itemEstadoCuentaSap.FechaVencimiento = fecha;

                itemEstadoCuentaSap.Monto = decimal.Parse(item.Monto);
                itemEstadoCuentaSap.BaseImponible = decimal.Parse(item.BaseImponible);
                itemEstadoCuentaSap.Impuesto = decimal.Parse(item.Impuesto);
                itemEstadoCuentaSap.Saldo = decimal.Parse(item.Saldo);

                estadoCuentaSap.Add(itemEstadoCuentaSap);

            }


            return estadoCuentaSap;




        }
        public async Task<List<EstadoCuentaSap>> GetEstadoCuentaSapMultimoneda(string tokenSap)
        {

            /*
            string userSap = _paginationOptions.UserSap;
            string passwordSap = _paginationOptions.PasswordSap;
            string tokenSap = "";

            var meta = await _sapClient.GetToken(userSap, passwordSap);
            if (meta.IsValid)
            {
                tokenSap = meta.Message;

            }
            else
            {
                return null;
            }*/


            //string action = $"EstadoCuentaCliente?Sociedad='1000'&Cliente='{cliente}'&MostrarImportesMonedaDoc=true";
            // string action = $"EstadoCuentaCliente?Sociedad='1000'&Cliente=''&MostrarImportesMonedaDoc=true";
            string action = $"EstadoCuentaClientes?Sociedad='1000'&MostrarImportesMonedaDoc=true";
            var result = await _sapClient.GetEstadoCuenta(action, tokenSap);


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };
            AppService.Core.DTOs.SapEstadoCuentaResult.Application resultSapEstadoCuenta = new AppService.Core.DTOs.SapEstadoCuentaResult.Application();
            resultSapEstadoCuenta = JsonSerializer.Deserialize<AppService.Core.DTOs.SapEstadoCuentaResult.Application>(result.Message, options);
            List<EstadoCuentaSap> estadoCuentaSap = new List<EstadoCuentaSap>();
            foreach (var item in resultSapEstadoCuenta.d.results)
            {
                EstadoCuentaSap itemEstadoCuentaSap = new EstadoCuentaSap();

                itemEstadoCuentaSap.DocumentoSAP = item.DocumentoSAP;
                itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                itemEstadoCuentaSap.ClaseDoc = item.ClaseDoc;
                itemEstadoCuentaSap.Correlativo = item.Correlativo;
                itemEstadoCuentaSap.Cliente = item.Cliente;
                itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                itemEstadoCuentaSap.Moneda = item.Moneda;
                var valor = long.Parse(GetSubStringByString("(", ")", item.FechaDoc));
                var fecha = DateTimeOffset.FromUnixTimeMilliseconds(valor).DateTime;
                itemEstadoCuentaSap.FechaDoc = fecha;
                fecha = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(GetSubStringByString("(", ")", item.FechaVencimiento))).DateTime;
                itemEstadoCuentaSap.FechaVencimiento = fecha;

                itemEstadoCuentaSap.Monto = decimal.Parse(item.Monto);
                itemEstadoCuentaSap.BaseImponible = decimal.Parse(item.BaseImponible);
                itemEstadoCuentaSap.Impuesto = decimal.Parse(item.Impuesto);
                itemEstadoCuentaSap.Saldo = decimal.Parse(item.Saldo);
                itemEstadoCuentaSap.DebeHaber = item.DebeHaber;
                itemEstadoCuentaSap.Signo = item.Signo;
                itemEstadoCuentaSap.Texto = item.Texto;


                estadoCuentaSap.Add(itemEstadoCuentaSap);

            }


            return estadoCuentaSap;




        }
        public async Task<List<EstadoCuentaSap>> GetEstadoCuentaSapMultimoneda(string cliente, string tokenSap)
        {

            /*
            string userSap = _paginationOptions.UserSap;
            string passwordSap = _paginationOptions.PasswordSap;
            string tokenSap = "";

            var meta = await _sapClient.GetToken(userSap, passwordSap);
            if (meta.IsValid)
            {
                tokenSap = meta.Message;

            }
            else
            {
                return null;
            }*/


            //string action = $"EstadoCuentaCliente?Sociedad='1000'&Cliente='{cliente}'&MostrarImportesMonedaDoc=true";
            string action = $"EstadoCuentaCliente?Sociedad='1000'&Cliente='{cliente}'&MostrarImportesMonedaDoc=true";

            var result = await _sapClient.GetEstadoCuenta(action, tokenSap);


            JsonSerializerOptions options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };
            AppService.Core.DTOs.SapEstadoCuentaResult.Application resultSapEstadoCuenta = new AppService.Core.DTOs.SapEstadoCuentaResult.Application();
            resultSapEstadoCuenta = JsonSerializer.Deserialize<AppService.Core.DTOs.SapEstadoCuentaResult.Application>(result.Message, options);
            List<EstadoCuentaSap> estadoCuentaSap = new List<EstadoCuentaSap>();
            foreach (var item in resultSapEstadoCuenta.d.results)
            {
                EstadoCuentaSap itemEstadoCuentaSap = new EstadoCuentaSap();

                itemEstadoCuentaSap.DocumentoSAP = item.DocumentoSAP;
                itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                itemEstadoCuentaSap.ClaseDoc = item.ClaseDoc;
                itemEstadoCuentaSap.Correlativo = item.Correlativo;
                itemEstadoCuentaSap.Cliente = item.Cliente;
                itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                itemEstadoCuentaSap.Moneda = item.Moneda;
                var valor = long.Parse(GetSubStringByString("(", ")", item.FechaDoc));
                var fecha = DateTimeOffset.FromUnixTimeMilliseconds(valor).DateTime;
                itemEstadoCuentaSap.FechaDoc = fecha;
                fecha = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(GetSubStringByString("(", ")", item.FechaVencimiento))).DateTime;
                itemEstadoCuentaSap.FechaVencimiento = fecha;

                itemEstadoCuentaSap.Monto = decimal.Parse(item.Monto);
                itemEstadoCuentaSap.BaseImponible = decimal.Parse(item.BaseImponible);
                itemEstadoCuentaSap.Impuesto = decimal.Parse(item.Impuesto);
                itemEstadoCuentaSap.Saldo = decimal.Parse(item.Saldo);
                itemEstadoCuentaSap.DebeHaber = item.DebeHaber;
                itemEstadoCuentaSap.Signo = item.Signo;
                itemEstadoCuentaSap.Texto = item.Texto;


                estadoCuentaSap.Add(itemEstadoCuentaSap);

            }


            return estadoCuentaSap;




        }
        public async Task<CobEstadoDeCuenta> GetEstadoCuentaById(decimal id)
        {

            var estadoCuenta = await _unitOfWork.CobEstadoDeCuentaRepository.GetById(id);

            return estadoCuenta;
        }

        public string GetSubStringByString(string a, string b, string c)
        {

            var result = c.Substring((c.IndexOf(a) + a.Length), (c.IndexOf(b) - c.IndexOf(a) - a.Length));

            return result;
        }


        public async Task UpdateCobEstadoCuenta(List<EstadoCuentaSap> estadoCuentaSaps, string idCliente)
        {

            foreach (var item in estadoCuentaSaps)
            {

                CobEstadoDeCuenta cobEstadoDeCuenta = new CobEstadoDeCuenta();

                var estaddoCuentaSearch = await _unitOfWork.CobEstadoDeCuentaRepository.GetByDocumentoSap(item.DocumentoSAP);

                if (estaddoCuentaSearch == null)
                {
                    cobEstadoDeCuenta.DocumentoSap = item.DocumentoSAP;
                    cobEstadoDeCuenta.Rpdoc = double.Parse(item.DocumentoExterno);

                    var claseDocumento = GetListClaseDocumento().Where(x => x.ClaseDocumento == item.ClaseDoc).FirstOrDefault();
                    if (claseDocumento != null)
                    {
                        cobEstadoDeCuenta.Rpdct = claseDocumento.TipoLegacy;
                    }

                    cobEstadoDeCuenta.Rpkco = "01406";
                    cobEstadoDeCuenta.Rpsfx = "001";
                    cobEstadoDeCuenta.Rpan8 = double.Parse(item.Cliente);
                    cobEstadoDeCuenta.Rpag = decimal.ToDouble(item.Monto);
                    cobEstadoDeCuenta.Rpaap = decimal.ToDouble(item.Saldo);
                    cobEstadoDeCuenta.IdCliente = item.Cliente;
                    var cliente = _unitOfWork.MtrClienteRepository.GetById(item.Cliente);
                    cobEstadoDeCuenta.Vendedor = cliente.Vendedor1.Trim();
                    cobEstadoDeCuenta.OficinaVenta = cliente.OficinaVenta.Trim();
                    cobEstadoDeCuenta.BaseImponible = item.BaseImponible;
                    cobEstadoDeCuenta.Iva = item.Impuesto;
                    cobEstadoDeCuenta.MontoOriginal = item.Monto;
                    cobEstadoDeCuenta.FechaDocumento = item.FechaDoc;
                    cobEstadoDeCuenta.FechaVencimiento = item.FechaVencimiento;
                    cobEstadoDeCuenta.Moneda = item.Moneda;
                    await _unitOfWork.CobEstadoDeCuentaRepository.Add(cobEstadoDeCuenta);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    //estaddoCuentaSearch.DocumentoSap = item.DocumentoSAP;
                    estaddoCuentaSearch.Rpdoc = double.Parse(item.DocumentoExterno);
                    var claseDocumento = GetListClaseDocumento().Where(x => x.ClaseDocumento == item.ClaseDoc).FirstOrDefault();
                    if (claseDocumento != null)
                    {
                        estaddoCuentaSearch.Rpdct = claseDocumento.TipoLegacy;
                    }

                    estaddoCuentaSearch.Rpan8 = double.Parse(item.Cliente);
                    estaddoCuentaSearch.Rpag = decimal.ToDouble(item.Monto);
                    estaddoCuentaSearch.Rpaap = decimal.ToDouble(item.Saldo);
                    estaddoCuentaSearch.IdCliente = item.Cliente;
                    var cliente = _unitOfWork.MtrClienteRepository.GetById(item.Cliente);
                    estaddoCuentaSearch.Vendedor = cliente.Vendedor1;
                    estaddoCuentaSearch.OficinaVenta = cliente.OficinaVenta;
                    estaddoCuentaSearch.BaseImponible = item.BaseImponible;
                    estaddoCuentaSearch.Iva = item.Impuesto;
                    estaddoCuentaSearch.MontoOriginal = item.Monto;
                    estaddoCuentaSearch.FechaDocumento = item.FechaDoc;
                    estaddoCuentaSearch.FechaVencimiento = item.FechaVencimiento;
                    estaddoCuentaSearch.Moneda = item.Moneda;
                    _unitOfWork.CobEstadoDeCuentaRepository.Update(estaddoCuentaSearch);
                    await _unitOfWork.SaveChangesAsync();

                }


            }



            var estadoCuenta = await _unitOfWork.CobEstadoDeCuentaRepository.GetAllDocumentoMadre(idCliente);

            foreach (var item in estadoCuenta)
            {

                var estadoCuentaSap = estadoCuentaSaps.Where(x => x.DocumentoSAP == item.DocumentoSap).FirstOrDefault();
                if (estadoCuentaSap == null)
                {

                    var estaddoCuentaSearch = await _unitOfWork.CobEstadoDeCuentaRepository.GetByDocumentoSap(item.DocumentoSap);
                    estaddoCuentaSearch.Rpaap = 0;
                    _unitOfWork.CobEstadoDeCuentaRepository.Update(estaddoCuentaSearch);
                    await _unitOfWork.SaveChangesAsync();
                }

            }

        }


        public async Task UpdateCobEstadoCuentaMultimoneda(List<EstadoCuentaSap> estadoCuentaSaps, string idCliente)
        {
            try
            {

                var tPaActualBancoCentral = await _unitOfWork.TPaTasaBancoCentralRepository.GetTasaByFecha(DateTime.Now);
                var tasaActualBancocentral = tPaActualBancoCentral.Tasa;

                var tPaTasaReferencial = await _unitOfWork.TPaTasaReferencialRepository.GetTasaByFecha(DateTime.Now);
                var tasaActualReferencial = tPaTasaReferencial.Tasa;
                DateTime inicio = DateTime.Now;

                List<CobEstadoCuentaMultiMoneda> listCobEstadoDeCuenta = new List<CobEstadoCuentaMultiMoneda>();

                //foreach (var item in estadoCuentaSaps.Where(a => a.DocumentoExterno == "728917"))
                foreach (var item in estadoCuentaSaps)
                {
                    CobEstadoCuentaMultiMoneda cobEstadoDeCuenta = new CobEstadoCuentaMultiMoneda();
                    //var cliente = _unitOfWork.MtrClienteRepository.GetById(item.Cliente);
                    //var vendedor = _unitOfWork.MtrVendedorRepository.GetById(cliente.Vendedor1.Trim());
                    //var oficina = await _unitOfWork.MtrOficinaRepository.GetById(short.Parse(cliente.OficinaVenta));
                    //await _unitOfWork.CobEstadoDeCuentaMultimonedaRepository.DeleteByCliente(item.Cliente);




                    cobEstadoDeCuenta.DocumentoSap = item.DocumentoSAP;
                    cobEstadoDeCuenta.DocumentoExterno = item.DocumentoExterno;
                    cobEstadoDeCuenta.ClaseDoc = item.ClaseDoc;
                    var claseDocumento = GetListClaseDocumento().Where(x => x.ClaseDocumento == item.ClaseDoc).FirstOrDefault();
                    if (claseDocumento != null)
                    {
                        cobEstadoDeCuenta.DescripcionClaseDocumento = claseDocumento.Descricion;
                    }

                    cobEstadoDeCuenta.Cliente = item.Cliente;



                    if (item.Signo == "-")
                    {
                        cobEstadoDeCuenta.Monto = item.Monto * -1;
                        cobEstadoDeCuenta.Saldo = item.Saldo * -1;
                        cobEstadoDeCuenta.BaseImponible = item.BaseImponible * -1;
                        cobEstadoDeCuenta.Impuesto = item.Impuesto * -1;
                    }
                    else
                    {
                        cobEstadoDeCuenta.Monto = item.Monto;
                        cobEstadoDeCuenta.Saldo = item.Saldo;
                        cobEstadoDeCuenta.BaseImponible = item.BaseImponible;
                        cobEstadoDeCuenta.Impuesto = item.Impuesto;
                    }



                    if (item.Moneda == "VEX")
                    {
                        var valor = (decimal)cobEstadoDeCuenta.Monto / 1000000;

                        cobEstadoDeCuenta.Monto = decimal.Round(valor, 4);


                        valor = (decimal)cobEstadoDeCuenta.Saldo / 1000000;
                        cobEstadoDeCuenta.Saldo = decimal.Round(valor, 4);

                        valor = (decimal)cobEstadoDeCuenta.BaseImponible / 1000000;
                        cobEstadoDeCuenta.BaseImponible = decimal.Round(valor, 4);

                        valor = (decimal)cobEstadoDeCuenta.Impuesto / 1000000;
                        cobEstadoDeCuenta.Impuesto = decimal.Round(valor, 4);



                    }
                    var porcRetencion = 75;
                    cobEstadoDeCuenta.FacturaTieneRetencionesPendientes = false;
                    cobEstadoDeCuenta.RetencionPendiente = 0;
                    if (item.ClaseDoc == "Z0")
                    {

                        var facturaTieneRetencionesPendientes = await _unitOfWork.CobGrabacionCobranzasRepository.FacturaTieneRetencionesPendientes(long.Parse(item.DocumentoExterno));
                        cobEstadoDeCuenta.FacturaTieneRetencionesPendientes = facturaTieneRetencionesPendientes;
                        cobEstadoDeCuenta.RetencionPendiente = 0;
                        if (facturaTieneRetencionesPendientes)
                        {
                            cobEstadoDeCuenta.RetencionPendiente = (cobEstadoDeCuenta.Impuesto * porcRetencion) / 100;
                        }

                    }


                    cobEstadoDeCuenta.FechaDoc = item.FechaDoc;
                    cobEstadoDeCuenta.FechaVencimiento = item.FechaVencimiento;
                    cobEstadoDeCuenta.Moneda = item.Moneda;
                    cobEstadoDeCuenta.Signo = item.Signo;
                    cobEstadoDeCuenta.Texto = item.Texto;
                    cobEstadoDeCuenta.DebeHaber = item.DebeHaber;
                    //cobEstadoDeCuenta.Vendedor = cliente.Vendedor1.Trim();
                    //cobEstadoDeCuenta.NombreVendedor = vendedor.Nombre.Trim();
                    //cobEstadoDeCuenta.NombreCliente = cliente.Nombre.Trim();
                    //cobEstadoDeCuenta.OficinaVenta = cliente.OficinaVenta.Trim();
                    //cobEstadoDeCuenta.NombreOficina = oficina.NomOficina.Trim();
                    var tasaReferencial = await _unitOfWork.TPaTasaReferencialRepository.GetTasaByFecha((DateTime)cobEstadoDeCuenta.FechaDoc);
                    cobEstadoDeCuenta.TasaReferencial = tasaReferencial.Tasa;
                    //TODO ACTUALIZAR TASA DE FECHA ANTES DE AGOSTO 2020
                    var tasaBancoCentral = await _unitOfWork.TPaTasaBancoCentralRepository.GetTasaByFecha((DateTime)cobEstadoDeCuenta.FechaDoc);
                    if (tasaBancoCentral == null)
                    {
                        cobEstadoDeCuenta.TasaBancoCentral = tasaActualBancocentral;
                    }
                    else
                    {
                        cobEstadoDeCuenta.TasaBancoCentral = tasaBancoCentral.Tasa;
                    }

                    cobEstadoDeCuenta.Cotizacion = await GetCotizacionByDocumento(cobEstadoDeCuenta.ClaseDoc, cobEstadoDeCuenta.DocumentoExterno, cobEstadoDeCuenta.DocumentoSap);
                    if (cobEstadoDeCuenta.Cotizacion != "")
                    {
                        var propuesta = await _unitOfWork.PropuestaRepository.GetByCotizacion(cobEstadoDeCuenta.Cotizacion);
                        if (propuesta != null && propuesta.Count > 0)
                        {
                            cobEstadoDeCuenta.Orden = propuesta.FirstOrDefault().Orden;
                        }
                        else
                        {
                            cobEstadoDeCuenta.Orden = 0;
                        }
                    }
                    else
                    {
                        cobEstadoDeCuenta.Orden = 0;
                    }

                    //****************COLUMNAS EN DOLARES CON FECHA DEL DOCUMENTO BANCO CENTRAL********************************
                    if (cobEstadoDeCuenta.Moneda == "USD")
                    {
                        cobEstadoDeCuenta.MontoUsd = cobEstadoDeCuenta.Monto;
                        cobEstadoDeCuenta.BaseImponibleUsd = cobEstadoDeCuenta.BaseImponible;
                        cobEstadoDeCuenta.ImpuestoUsd = cobEstadoDeCuenta.Impuesto;
                        cobEstadoDeCuenta.SaldoUsd = cobEstadoDeCuenta.Saldo;

                        cobEstadoDeCuenta.RetencionPendienteUsd = cobEstadoDeCuenta.RetencionPendiente;
                    }
                    else
                    {
                        //****************Tasa banco central segun fecha del documento en SAP*********
                        var valor = (decimal)cobEstadoDeCuenta.Monto / (decimal)cobEstadoDeCuenta.TasaBancoCentral;
                        cobEstadoDeCuenta.MontoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.BaseImponible / (decimal)cobEstadoDeCuenta.TasaBancoCentral;
                        cobEstadoDeCuenta.BaseImponibleUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Impuesto / (decimal)cobEstadoDeCuenta.TasaBancoCentral;
                        cobEstadoDeCuenta.ImpuestoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Saldo / (decimal)cobEstadoDeCuenta.TasaBancoCentral;
                        cobEstadoDeCuenta.SaldoUsd = decimal.Round(valor, 4);
                        cobEstadoDeCuenta.RetencionPendienteUsd = 0;
                        if (cobEstadoDeCuenta.RetencionPendiente > 0)
                        {
                            valor = (decimal)cobEstadoDeCuenta.RetencionPendiente / (decimal)cobEstadoDeCuenta.TasaBancoCentral;
                            cobEstadoDeCuenta.RetencionPendienteUsd = valor;
                        }

                    }

                    //****************COLUMNAS EN DOLARES DE FECHA_ACTUAL_BANCO_CENTRAL********************************
                    cobEstadoDeCuenta.FechaActualBancoCentralTasa = tasaActualBancocentral;
                    cobEstadoDeCuenta.FechaActualBancoCentralRetencionPendienteUsd = 0;
                    if (cobEstadoDeCuenta.Moneda == "USD")
                    {
                        cobEstadoDeCuenta.FechaActualBancoCentralMontoUsd = cobEstadoDeCuenta.Monto;
                        cobEstadoDeCuenta.FechaActualBancoCentralBaseImponibleUsd = cobEstadoDeCuenta.BaseImponible;
                        cobEstadoDeCuenta.FechaActualBancoCentralImpuestoUsd = cobEstadoDeCuenta.Impuesto;
                        cobEstadoDeCuenta.FechaActualBancoCentralSaldoUsd = cobEstadoDeCuenta.Saldo;
                        cobEstadoDeCuenta.FechaActualBancoCentralRetencionPendienteUsd = cobEstadoDeCuenta.RetencionPendiente;

                    }
                    else
                    {
                        var valor = (decimal)cobEstadoDeCuenta.Monto / (decimal)tasaActualBancocentral;
                        cobEstadoDeCuenta.FechaActualBancoCentralMontoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.BaseImponible / (decimal)tasaActualBancocentral;
                        cobEstadoDeCuenta.FechaActualBancoCentralBaseImponibleUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Impuesto / (decimal)tasaActualBancocentral;
                        cobEstadoDeCuenta.FechaActualBancoCentralImpuestoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Saldo / (decimal)tasaActualBancocentral;
                        cobEstadoDeCuenta.FechaActualBancoCentralSaldoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.RetencionPendiente / (decimal)tasaActualBancocentral;
                        cobEstadoDeCuenta.FechaActualBancoCentralRetencionPendienteUsd = valor;
                    }


                    //****************COLUMNAS EN DOLARES DE FECHA_ACTUAL_REFERENCIAL********************************

                    cobEstadoDeCuenta.FechaActualReferencialTasa = tasaActualReferencial;
                    if (cobEstadoDeCuenta.Moneda == "USD")
                    {
                        cobEstadoDeCuenta.FechaActualReferencialMontoUsd = cobEstadoDeCuenta.Monto;
                        cobEstadoDeCuenta.FechaActualReferencialBaseImponibleUsd = cobEstadoDeCuenta.BaseImponible;
                        cobEstadoDeCuenta.FechaActualReferencialImpuestoUsd = cobEstadoDeCuenta.Impuesto;
                        cobEstadoDeCuenta.FechaActualReferencialSaldoUsd = cobEstadoDeCuenta.Saldo;
                        cobEstadoDeCuenta.FechaActualReferencialRetencionPendienteUsd = cobEstadoDeCuenta.RetencionPendiente;

                    }
                    else
                    {
                        var valor = (decimal)cobEstadoDeCuenta.Monto / (decimal)tasaActualReferencial;
                        cobEstadoDeCuenta.FechaActualReferencialMontoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.BaseImponible / (decimal)tasaActualReferencial;
                        cobEstadoDeCuenta.FechaActualReferencialBaseImponibleUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Impuesto / (decimal)tasaActualReferencial;
                        cobEstadoDeCuenta.FechaActualReferencialImpuestoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Saldo / (decimal)tasaActualReferencial;
                        cobEstadoDeCuenta.FechaActualReferencialSaldoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.RetencionPendiente / (decimal)tasaActualReferencial;
                        cobEstadoDeCuenta.FechaActualReferencialRetencionPendienteUsd = decimal.Round(valor, 4);
                    }



                    //****************COLUMNAS EN DOLARES DE FECHA_ACTUAL_REFERENCIAL_COTIZACION********************************
                    var tasaActualCotizacion = await TasaActualCotizacion(cobEstadoDeCuenta.Cotizacion);

                    cobEstadoDeCuenta.FechaActualReferencialCotizacionTasa = tasaActualCotizacion;
                    if (cobEstadoDeCuenta.Moneda == "USD")
                    {
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionMontoUsd = cobEstadoDeCuenta.Monto;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionBaseImponibleUsd = cobEstadoDeCuenta.BaseImponible;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionImpuestoUsd = cobEstadoDeCuenta.Impuesto;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionSaldoUsd = cobEstadoDeCuenta.Saldo;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionRetencionPendienteUsd = cobEstadoDeCuenta.RetencionPendiente;
                    }
                    else
                    {
                        var valor = (decimal)cobEstadoDeCuenta.Monto / (decimal)tasaActualCotizacion;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionMontoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.BaseImponible / (decimal)tasaActualCotizacion;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionBaseImponibleUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Impuesto / (decimal)tasaActualCotizacion;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionImpuestoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.Saldo / (decimal)tasaActualCotizacion;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionSaldoUsd = decimal.Round(valor, 4);
                        valor = (decimal)cobEstadoDeCuenta.RetencionPendiente / (decimal)tasaActualCotizacion;
                        cobEstadoDeCuenta.FechaActualReferencialCotizacionRetencionPendienteUsd = decimal.Round(valor, 4); ;

                    }
                    cobEstadoDeCuenta.Inicio = inicio;
                    cobEstadoDeCuenta.Fin = DateTime.Now;


                    listCobEstadoDeCuenta.Add(cobEstadoDeCuenta);





                }



                await _unitOfWork.CobEstadoDeCuentaMultimonedaRepository.AddList(listCobEstadoDeCuenta);



            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
                throw;
            }






        }

        private async Task<decimal> TasaActualCotizacion(string idCotizacion)
        {
            decimal result = 0;


            var cotizacion = await _unitOfWork.CotizacionRepository.GetByCotizacion(idCotizacion);

            if (cotizacion != null && cotizacion.TasaExcepcion > 0)
            {
                result = cotizacion.TasaExcepcion ?? 0;

            }
            else
            {
                var tPaTasaReferencial = await _unitOfWork.TPaTasaReferencialRepository.GetTasaByFecha(DateTime.Now);
                var tasa = tPaTasaReferencial.Tasa;
                result = tasa ?? 0;
            }


            return result;

        }

        public async Task<string> GetCotizacionByDocumento(string claseDocumento, string documento, string documentoSap)
        {

            string cotizacion = "";
            int _documento = Int32.Parse(documento);


            switch (claseDocumento)
            {
                case "Z0":
                    var factura = await _unitOfWork.Ciny057Repository.GetByNumero(_documento);
                    var orden = factura.Orden;
                    var propuesta = await _unitOfWork.PropuestaRepository.GetByOrden(orden);
                    if (propuesta != null)
                    {
                        cotizacion = propuesta.Cotizacion;
                    }
                    else
                    {
                        cotizacion = "";
                    }


                    break;
                case "Z5":
                    var notaCredito = await _unitOfWork.Ciny057Repository.GetNotaCreditoByNumero(_documento);
                    if (notaCredito != null)
                    {
                        var facturaNotaCredito = await _unitOfWork.Ciny057Repository.GetByNumero(notaCredito.Factura);
                        long ordenNotaCredito = 0;
                        if (facturaNotaCredito != null)
                        {
                            ordenNotaCredito = facturaNotaCredito.Orden;
                        }


                        var propuestaNota = await _unitOfWork.PropuestaRepository.GetByOrden(ordenNotaCredito);
                        if (propuestaNota != null)
                        {
                            cotizacion = propuestaNota.Cotizacion;
                        }
                        else
                        {
                            cotizacion = "";
                        }
                    }
                    else
                    {
                        cotizacion = "";
                    }



                    break;
                case "DZ":

                    var grabacionCobranzas = await _unitOfWork.CobGrabacionCobranzasRepository.GetByDocumentoSap(documentoSap);
                    if (grabacionCobranzas != null)
                    {
                        if (grabacionCobranzas.Transaccion == "RU")
                        {
                            cotizacion = grabacionCobranzas.Cotizacion;

                        }
                        else
                        {
                            var facturaCobro = await _unitOfWork.Ciny057Repository.GetByNumero(Convert.ToInt32(grabacionCobranzas.Rpdoc));
                            if (facturaCobro != null)
                            {
                                var ordenCobro = facturaCobro.Orden;
                                var propuestaCobro = await _unitOfWork.PropuestaRepository.GetByOrden(ordenCobro);
                                if (propuestaCobro != null)
                                {
                                    cotizacion = propuestaCobro.Cotizacion;
                                }
                                else
                                {
                                    cotizacion = "";
                                }
                            }
                            else
                            {
                                cotizacion = "";
                            }



                        }

                    }
                    else
                    {
                        var retenciones = await _unitOfWork.CobPagosRetencionesRepository.GetByDocumentoSap(documentoSap);
                        if (retenciones != null)
                        {
                            var cobranzas = await _unitOfWork.CobGrabacionCobranzasRepository.GetById(retenciones.IdCobranza);
                            var facturaCobro = await _unitOfWork.Ciny057Repository.GetByNumero(Convert.ToInt32(cobranzas.Rpdoc));
                            if (facturaCobro != null)
                            {
                                var ordenCobro = facturaCobro.Orden;
                                var propuestaCobro = await _unitOfWork.PropuestaRepository.GetByOrden(ordenCobro);
                                if (propuestaCobro != null)
                                {
                                    cotizacion = propuestaCobro.Cotizacion;
                                }
                                else
                                {
                                    cotizacion = "";
                                }
                            }
                            else
                            {
                                cotizacion = "";
                            }


                        }
                        else
                        {
                            cotizacion = "";
                        }

                    }


                    break;
                case "AB":
                    cotizacion = "";
                    break;

                default:
                    cotizacion = "";
                    break;
            }


            return cotizacion;

        }
        public List<SAPClaseDocumentoDto> GetListClaseDocumento()
        {

            List<SAPClaseDocumentoDto> result = new List<SAPClaseDocumentoDto>();

            SAPClaseDocumentoDto item = new SAPClaseDocumentoDto();
            item.ClaseDocumento = "AB";
            item.TipoLegacy = "AB";
            item.Descricion = "Documento Contable";
            result.Add(item);

            SAPClaseDocumentoDto item1 = new SAPClaseDocumentoDto();
            item1.ClaseDocumento = "CD";
            item1.TipoLegacy = "CD";
            item1.Descricion = "Ch.devuelto cliente";
            result.Add(item1);

            SAPClaseDocumentoDto item2 = new SAPClaseDocumentoDto();
            item2.ClaseDocumento = "CI";
            item2.TipoLegacy = "SO";
            item2.Descricion = "Carga Inicial saldos";
            result.Add(item2);

            SAPClaseDocumentoDto item3 = new SAPClaseDocumentoDto();
            item3.ClaseDocumento = "DA";
            item3.TipoLegacy = "";
            item3.Descricion = "";
            result.Add(item3);

            SAPClaseDocumentoDto item4 = new SAPClaseDocumentoDto();
            item4.ClaseDocumento = "DG";
            item4.TipoLegacy = "DG";
            item4.Descricion = "";
            result.Add(item4);

            SAPClaseDocumentoDto item5 = new SAPClaseDocumentoDto();
            item5.ClaseDocumento = "DR";
            item5.TipoLegacy = "SO";
            item5.Descricion = "Factura deudor";
            result.Add(item5);

            SAPClaseDocumentoDto item6 = new SAPClaseDocumentoDto();

            item6.ClaseDocumento = "DV";
            item6.TipoLegacy = "DV";
            item6.Descricion = "Retenciones del año 2013 al 2016";
            result.Add(item6);

            SAPClaseDocumentoDto item7 = new SAPClaseDocumentoDto();
            item7.ClaseDocumento = "DZ";
            item7.TipoLegacy = "RC";
            item7.Descricion = "Cobranzas, Pagos y retenciones";
            result.Add(item7);

            SAPClaseDocumentoDto item8 = new SAPClaseDocumentoDto();
            item8.ClaseDocumento = "RV";
            item8.TipoLegacy = "SO";
            item8.Descricion = "Traspaso de facturas";
            result.Add(item8);

            SAPClaseDocumentoDto item9 = new SAPClaseDocumentoDto();
            item9.ClaseDocumento = "SA";
            item9.TipoLegacy = "SA";
            item9.Descricion = "Ajustes";
            result.Add(item9);

            SAPClaseDocumentoDto item10 = new SAPClaseDocumentoDto();

            item10.ClaseDocumento = "Z0";
            item10.TipoLegacy = "SO";
            item10.Descricion = "Factura";
            result.Add(item10);

            SAPClaseDocumentoDto item11 = new SAPClaseDocumentoDto();
            item11.ClaseDocumento = "Z1";
            item11.TipoLegacy = "SO";
            item11.Descricion = "NC x Dev. Moore";
            result.Add(item11);

            SAPClaseDocumentoDto item12 = new SAPClaseDocumentoDto();
            item12.ClaseDocumento = "Z2";
            item12.TipoLegacy = "SO";
            item12.Descricion = "NC x Dif.Prec. Moore";
            result.Add(item12);

            SAPClaseDocumentoDto item13 = new SAPClaseDocumentoDto();
            item13.ClaseDocumento = "Z5";
            item13.TipoLegacy = "CO";
            item13.Descricion = "Nota Credito Finac.";
            result.Add(item13);

            SAPClaseDocumentoDto item14 = new SAPClaseDocumentoDto();
            item14.ClaseDocumento = "Z7";
            item14.TipoLegacy = "SN";
            item14.Descricion = "Nota Debito";
            result.Add(item14);

            SAPClaseDocumentoDto item15 = new SAPClaseDocumentoDto();
            item15.ClaseDocumento = "ZA";
            item15.TipoLegacy = "ZA";
            item15.Descricion = "Anul.N/C Financiera";
            result.Add(item15);

            SAPClaseDocumentoDto item16 = new SAPClaseDocumentoDto();
            item16.ClaseDocumento = "ZX";
            item16.TipoLegacy = "ZX";
            item16.Descricion = "Anulacion Doc.Venta";
            result.Add(item16);

            SAPClaseDocumentoDto item17 = new SAPClaseDocumentoDto();

            item17.ClaseDocumento = "ZZ";
            item17.TipoLegacy = "ZZ";
            item17.Descricion = "";
            result.Add(item17);


            return result;


        }

    }
}
