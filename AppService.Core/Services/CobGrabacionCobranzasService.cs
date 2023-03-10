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
    public class CobGrabacionCobranzasService: ICobGrabacionCobranzasService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly PaginationOptions _paginationOptions;

        public CobGrabacionCobranzasService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
        }

        public PagedList<CobGrabacionCobranzas> GetCobGrabacionCobranzas(CobGrabacionCobranzasQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var grabacionCobranzas = _unitOfWork.CobGrabacionCobranzasRepository.GetByDocumento(filters.Documento);

            

            var pagedResult = PagedList<CobGrabacionCobranzas>.Create(grabacionCobranzas, filters.PageNumber, filters.PageSize);

            return pagedResult;
        }

        public IEnumerable<CobGrabacionCobranzas> GetAll()
        {

            var cobranzas = _unitOfWork.CobGrabacionCobranzasRepository.GetAll();

            return cobranzas;
        }

        public async Task<CobGrabacionCobranzas> GetById(long id)
        {
            return await _unitOfWork.CobGrabacionCobranzasRepository.GetById(id);
        }

        public async Task<CobGrabacionCobranzas> Insert(CobGrabacionCobranzas cobGrabacionCobranzas)
        {

            var docAfecta = await _unitOfWork.CobEstadoDeCuentaRepository.GetById(cobGrabacionCobranzas.DocAfecta);
            if (docAfecta != null)
            {
                cobGrabacionCobranzas.Rpdoc = docAfecta.Rpdoc;
                cobGrabacionCobranzas.Rpdct = docAfecta.Rpdct;
                cobGrabacionCobranzas.Rpkco = docAfecta.Rpkco;
                cobGrabacionCobranzas.Rpsfx = docAfecta.Rpsfx;
                cobGrabacionCobranzas.DocAfectaSap = docAfecta.DocumentoSap;
            }
            if (cobGrabacionCobranzas.DocumentoSap==null)
            {
                cobGrabacionCobranzas.DocumentoSap = "";
            }
            if (cobGrabacionCobranzas.EjercicioDocumentoSap==null)
            {
                cobGrabacionCobranzas.EjercicioDocumentoSap = "";

            }
            if (cobGrabacionCobranzas.Monto == null)
            {
                cobGrabacionCobranzas.Monto = 0;

            }

            await _unitOfWork.CobGrabacionCobranzasRepository.Add(cobGrabacionCobranzas);
            await _unitOfWork.SaveChangesAsync();

            var generalCobranza = await _unitOfWork.GeneralCobranzaRepository.GetGeneralCobranzaDocumento((long)cobGrabacionCobranzas.Documento);
            generalCobranza.TotalDetalleCobrado = generalCobranza.MontoTransaccion - TotalDetalleRecibo((long)cobGrabacionCobranzas.Documento);

            await _unitOfWork.GeneralCobranzaRepository.Update(generalCobranza);
            await _unitOfWork.SaveChangesAsync();

            return cobGrabacionCobranzas;
        }

        public async Task<CobGrabacionCobranzas> Update(CobGrabacionCobranzas cobGrabacionCobranzas )
        {


            var cobranza = await GetById(cobGrabacionCobranzas.Id);
            if (cobranza == null)
            {
                throw new Exception("Documento No existe");
            }



            cobranza.Monto = cobGrabacionCobranzas.Monto;

            cobranza.Transaccion = cobGrabacionCobranzas.Transaccion;
            cobranza.Cotizacion = cobGrabacionCobranzas.Cotizacion;
            cobranza.DocAfecta = cobGrabacionCobranzas.DocAfecta;
            var docAfecta = await _unitOfWork.CobEstadoDeCuentaRepository.GetById(cobGrabacionCobranzas.DocAfecta);
            if (docAfecta!=null)
            {
                cobranza.Rpdoc = docAfecta.Rpdoc;
                cobranza.Rpdct = docAfecta.Rpdct;
                cobranza.Rpkco = docAfecta.Rpkco;
                cobranza.Rpsfx = docAfecta.Rpsfx;
                cobranza.DocAfectaSap = docAfecta.DocumentoSap;
            }

            if (cobGrabacionCobranzas.DocumentoSap==null)
            {
                cobGrabacionCobranzas.DocumentoSap = "";
            }
            if (cobGrabacionCobranzas.EjercicioDocumentoSap == null)
            {
                cobGrabacionCobranzas.EjercicioDocumentoSap = "";
            }

            
            await _unitOfWork.CobGrabacionCobranzasRepository.Update(cobranza);
            await _unitOfWork.SaveChangesAsync();

            var generalCobranza = await _unitOfWork.GeneralCobranzaRepository.GetGeneralCobranzaDocumento((long)cobGrabacionCobranzas.Documento);
            generalCobranza.TotalDetalleCobrado = generalCobranza.MontoTransaccion - TotalDetalleRecibo((long)cobGrabacionCobranzas.Documento);

            await _unitOfWork.GeneralCobranzaRepository.Update(generalCobranza);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(cobGrabacionCobranzas.Id);

        }

        public async Task<bool> Delete(long id)
        {



            var cobranza = await GetById(id);
            if (cobranza == null)
            {
                throw new Exception("Documento No existe");
            }

            await _unitOfWork.CobGrabacionCobranzasRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();


            var generalCobranza = await _unitOfWork.GeneralCobranzaRepository.GetGeneralCobranzaDocumento((long)cobranza.Documento);
            generalCobranza.TotalDetalleCobrado = generalCobranza.MontoTransaccion -  TotalDetalleRecibo((long)cobranza.Documento);

            await _unitOfWork.GeneralCobranzaRepository.Update(generalCobranza);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }



        public async Task<bool> MontoCobradoEsTotal(long id)
        {
            bool result = false; 
            var grabacion = await GetById(id);
            if (grabacion!= null)
            {
                var estadoCuenta = await _unitOfWork.CobEstadoDeCuentaRepository.GetById(grabacion.DocAfecta);
                if (estadoCuenta!=null)
                {

                    var totalRetenciones = _unitOfWork.CobPagosRetencionesRepository.GetTotalRetencionesByIdCobranzas(grabacion.Id);
            
                    var totalCobrado = grabacion.Monto + totalRetenciones;

                    var diferencia = (decimal)estadoCuenta.Rpag - totalCobrado;

                    if (diferencia==0)
                    {
                        result = true;

                    }
                    else
                    {
                        result = false;

                    }


                }

            }
            else
            {
                result= false;
            }

            return result;



        }


        public bool ReciboTieneCobro(long documento)
        {
            bool result = false;

            var grabacion = _unitOfWork.CobGrabacionCobranzasRepository.GetByDocumento(documento).FirstOrDefault();

            if (grabacion!=null)
            {
                result = true;
            }
            return result;

        }


        public   async Task< bool> GrabacionCobranzasTieneRetencionCero(long documento)
        {

          
            return  await _unitOfWork.CobGrabacionCobranzasRepository.GrabacionCobranzasTieneRetencionCero(documento); ;

            
            

        }

        public async Task<bool> ReciboTienePendienteContabilizar(long documento)
        {
            return await _unitOfWork.CobGrabacionCobranzasRepository.ReciboTienePendienteContabilizar(documento);
        }

        public  decimal TotalAfectadoDocumento(long documento, decimal docafecta)
        {

            return _unitOfWork.CobGrabacionCobranzasRepository.TotalAfectadoDocumento(documento,docafecta);

        }



        public decimal TotalDetalleRecibo(long documento)
        {

            return _unitOfWork.CobGrabacionCobranzasRepository.TotalDetalleRecibo(documento);

        }






    }
}
