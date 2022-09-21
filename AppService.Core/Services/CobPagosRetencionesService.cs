using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobPagosRetencionesService:ICobPagosRetencionesService
    {

        private readonly IUnitOfWork _unitOfWork;

        private readonly PaginationOptions _paginationOptions;

        public CobPagosRetencionesService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
        }

        public IEnumerable<CobPagosRetenciones> GetAll()
        {

            var cobPagosRetenciones = _unitOfWork.CobPagosRetencionesRepository.GetAll();

            return cobPagosRetenciones;
        }
        public IEnumerable<CobPagosRetenciones> GetListCobPagosRetenciones(CobPagosRetencionesQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var pagosRetenciones = _unitOfWork.CobPagosRetencionesRepository.GetAll();

            if (filters.IdCobranza > 0)
            {
                pagosRetenciones = pagosRetenciones.Where(x => x.IdCobranza == filters.IdCobranza);
            }

           

            return pagosRetenciones;
        }

        public async Task<CobPagosRetenciones> GetById(long id)
        {
            return await _unitOfWork.CobPagosRetencionesRepository.GetById(id);
        }

        public async Task<CobPagosRetenciones> Insert(CobPagosRetenciones cobPagosRetenciones)
        {

            if (cobPagosRetenciones.DocumentoSap== null)
            {
                cobPagosRetenciones.DocumentoSap = "";
            }

            if (cobPagosRetenciones.EjercicioDocumentoSap==null)
            {
                cobPagosRetenciones.EjercicioDocumentoSap = "";
            }
            

            await _unitOfWork.CobPagosRetencionesRepository.Add(cobPagosRetenciones);
            await _unitOfWork.SaveChangesAsync();
            return cobPagosRetenciones;
        }




        public async Task<CobPagosRetenciones> Update(CobPagosRetenciones cobPagosRetenciones)
        {

            if (cobPagosRetenciones.DocumentoSap == null)
            {
                cobPagosRetenciones.DocumentoSap = "";
            }

            if (cobPagosRetenciones.EjercicioDocumentoSap == null)
            {
                cobPagosRetenciones.EjercicioDocumentoSap = "";
            }

            var retencion = await GetById(cobPagosRetenciones.Id);
            if (retencion == null)
            {
                throw new Exception("Banco No existe");
            }

            _unitOfWork.CobPagosRetencionesRepository.Update(cobPagosRetenciones);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(retencion.Id);

        }

        public async Task<bool> Delete(long id)
        {
            await _unitOfWork.CobPagosRetencionesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }


        public async Task<Metadata> ValidateInsert(CobPagosRetenciones cobPagosRetenciones)
        {
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""

            };

            try
            {

                if (cobPagosRetenciones.IdTransaccion == 0)
                {
                   

                    metadata.IsValid = false;
                    metadata.Message = "Debe indicar tipo de retención";
                    return metadata;
                }
                if (cobPagosRetenciones.Porcentaje == 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Debe indicar el Porcentaje de la Retención";
                    return metadata;
                }

                var meta = await ValorRetencion(cobPagosRetenciones.IdTransaccion, Convert.ToDouble(cobPagosRetenciones.Porcentaje));
                metadata = meta;
                if (!meta.IsValid)
                {
                    metadata = meta;
                    return metadata;

                }


                //BUSCAMOS LA TRANSACCION///////////////////////////////////////////////

                var transacciones =await  _unitOfWork.CobTransaccionesRepository.GetById(cobPagosRetenciones.IdTransaccion);
                
                //VERIFICAMOS QUE LA RETENCION YA FUE CARGADA
                if (transacciones.FlagRepiteImpuesto == false)
                {
                    //var qryPago = _unitOfWork.CobPagosRetencionesRepository.GetAll().Where(x => x.IdCobranza == cobPagosRetenciones.IdCobranza && x.IdTransaccion == cobPagosRetenciones.IdTransaccion).FirstOrDefault();
                    var qryPago =await  _unitOfWork.CobPagosRetencionesRepository.GetByIdCobranzasTransaccion(cobPagosRetenciones.IdCobranza, cobPagosRetenciones.IdTransaccion);

                    //var QryPagos = (from Pago in db.CobPagosRetenciones where Pago.IdCobranza == Pagos.IdCobranza && Pago.IdTransaccion == Pagos.IdTransaccion select Pago).FirstOrDefault();
                    if (qryPago != null)
                    {

                        metadata.IsValid = false;
                        metadata.Message = "Ya tiene porentaje cargado para este impuesto, eliminelo y vuelvalo a crear.";
                        return metadata;
                     
                    }
                }
                else
                {
                    var qryPago = _unitOfWork.CobPagosRetencionesRepository.GetAll().Where(x => x.IdCobranza == cobPagosRetenciones.IdCobranza && x.IdTransaccion == cobPagosRetenciones.IdTransaccion && x.Porcentaje == cobPagosRetenciones.Porcentaje).FirstOrDefault();
                    //var QryPagos = (from Pago in db.CobPagosRetenciones where Pago.IdCobranza == Pagos.IdCobranza && Pago.IdTransaccion == Pagos.IdTransaccion && Pago.Porcentaje == Pagos.Porcentaje select Pago).FirstOrDefault();
                    if (qryPago != null)
                    {

                        metadata.IsValid = false;
                        metadata.Message = "Ya tiene porentaje cargado para este impuesto, eliminelo y vuelvalo a crear.";
                        return metadata;
                       
                    }
                }

                //VERIFICAMOS QUE LA RETENCION NO HAYA SIDO CARGADA EN OTRO RECIBO DE COBRO

               // var grabacionCobranzaActual = _unitOfWork.CobGrabacionCobranzasRepository.GetAll().Where(x=> x.Id== cobPagosRetenciones.IdCobranza).FirstOrDefault();

                var grabacionCobranzaActual = await _unitOfWork.CobGrabacionCobranzasRepository.GetById(cobPagosRetenciones.IdCobranza);


                //var otraGrabacionCobranza = _unitOfWork.CobGrabacionCobranzasRepository.GetAll().Where(x => x.DocAfecta == grabacionCobranzaActual.DocAfecta).FirstOrDefault();
                var otraGrabacionCobranza = _unitOfWork.CobGrabacionCobranzasRepository.GetByDocumentoAfecta(grabacionCobranzaActual.DocAfecta);


                if (otraGrabacionCobranza!=null)
                {
                    //var pagosretencion = _unitOfWork.CobPagosRetencionesRepository.GetAll().Where(x => x.IdCobranza == otraGrabacionCobranza.Id && x.IdTransaccion== cobPagosRetenciones.IdTransaccion).FirstOrDefault();
                    var pagosretencion = await _unitOfWork.CobPagosRetencionesRepository.GetByIdCobranzasTransaccion(otraGrabacionCobranza.Id, cobPagosRetenciones.IdTransaccion);

                    if (pagosretencion!= null)
                    {

                        var general = await _unitOfWork.GeneralCobranzaRepository.GetGeneralCobranzaDocumento((long)otraGrabacionCobranza.Documento);

                        if (general.FlagAnulado == false)
                        {
                            metadata.IsValid = false;
                            metadata.Message = "La Factura " + otraGrabacionCobranza.Rpdoc.ToString() + " ya tiene la " + transacciones.NombreTransaccion + " cargada en el RC N° " + otraGrabacionCobranza.Documento.ToString();
                            return metadata;
                        }
                        

                      
                    }
                }


              

                metadata.IsValid = true;
                metadata.Message = "Retencion Valida";
                return metadata;
            }
            catch (Exception ex )
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                return metadata;
                
            }



        }

        public async Task<Metadata> ValorRetencion(int IdTrans, double Valor)
        {

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            CobTransacciones Trans = await _unitOfWork.CobTransaccionesRepository.GetById(IdTrans);
           

            Boolean ValValido = false;

            var Valores = await _unitOfWork.CobValoresRetencionesRepository.GetById(IdTrans);
               

            if (Valores != null)
            {
                if (Valores.FlagRango == true && Valores.FlagValorFijo == false)
                {
                    string[] ValPermitidos = Valores.Valores.Split('-');

                    if (Valor >= Convert.ToDouble(ValPermitidos[0]) && Valor <= Convert.ToDouble(ValPermitidos[1]))
                    {
                        metadata.Message = "";
                        metadata.IsValid = true;
                        return metadata;
                    }
                    else
                    {
                        metadata.Message = "El Porcentaje " + Valor.ToString() + " no es un valor permitido para " + Trans.NombreTransaccion.ToUpper() + ". \n Los valores permitidos para esta retención se encuentran entre " + ValPermitidos[0] + " y " + ValPermitidos[1];
                        metadata.IsValid = false;
                        return metadata;

                    }

                }

                if (Valores.FlagRango == false && Valores.FlagValorFijo == true)
                {
                    string[] ValPermitidos = Valores.Valores.Split(',');

                    foreach (string Val in ValPermitidos)
                    {
                        if (Valor == Convert.ToDouble(Val))
                        {

                            ValValido = true;

                            break;

                        }
                    }

                    if (ValValido == true)
                    {
                        metadata.Message = "";
                        metadata.IsValid = true;
                        return metadata;
                    }
                    else
                    {
                      
                        metadata.Message = "El Porcentaje " + Valor.ToString() + " no es un valor permitido para " + Trans.NombreTransaccion.ToUpper() + ". \n Los valores permitidos para esta retención deben ser algunos de esto: " + Valores.Valores; ;
                        metadata.IsValid = false;
                        return metadata;
                    }

                }
            }
            else
            {
                metadata.Message = "No existen valores de retencion definidos para esta transaccion" ;
                metadata.IsValid = false;
                return metadata;
            }

           return metadata;
        }

        public decimal GetTotalRetencionesByIdCobranzas(long id)
        {

            var totalRetencion =  _unitOfWork.CobPagosRetencionesRepository.GetTotalRetencionesByIdCobranzas(id);
            return totalRetencion;

        }




    }
}
