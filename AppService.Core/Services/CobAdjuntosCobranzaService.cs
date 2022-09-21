using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobAdjuntosCobranzaService : ICobAdjuntosCobranzaService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly PaginationOptions _paginationOptions;

        public CobAdjuntosCobranzaService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
        }

        //desde aqui los metodos que voy a utilizar...
        public async Task<PagedList<CobAdjuntosCobranza>> GetCobAdjuntosCobranza(AdjuntosCobranzaFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;
            List<CobAdjuntosCobranza> result = new List<CobAdjuntosCobranza>();



            List<CobAdjuntosCobranza> adjuntosCob = await _unitOfWork.CobAdjuntosCobranzaRepository.GetAdjuntoPorDocumento((long)filters.Documento);
            if (adjuntosCob != null)
            {
                result.AddRange(adjuntosCob);


            }



            PagedList<CobAdjuntosCobranza> pagedResult = PagedList<CobAdjuntosCobranza>.Create(result, filters.PageNumber, filters.PageSize);

            return pagedResult;


        }
        public async Task<CobAdjuntosCobranza> Insert(CobAdjuntosCobranza cobAdjuntosCobranza)
        {


            await _unitOfWork.CobAdjuntosCobranzaRepository.Add(cobAdjuntosCobranza);
            await _unitOfWork.SaveChangesAsync();
            return cobAdjuntosCobranza;
        }

        public async Task<List<CobAdjuntosCobranza>> GetCobAdjuntosCobranzaRecibo(long recibo)
        {

            List<CobAdjuntosCobranza> adjuntosCob = await _unitOfWork.CobAdjuntosCobranzaRepository.GetAdjuntoRecibo(recibo);


            return adjuntosCob;
        }


        public async Task<bool> DocumentoTieneAdjunto(long recibo)
        {
            return await _unitOfWork.CobAdjuntosCobranzaRepository.DocumentoTieneAdjunto(recibo);

        }

        public async Task DeleteByNameFile(long recibo, string nombreArchivo)
        {

            await _unitOfWork.CobAdjuntosCobranzaRepository.DeleteByNameFile(recibo, nombreArchivo);

        }


        public async Task<List<CobAdjuntosCobranza>> GetCobAdjuntosCTiff()
        {

            List<CobAdjuntosCobranza> adjuntosCob = await _unitOfWork.CobAdjuntosCobranzaRepository.GetAdjuntoTiff();


            return adjuntosCob;
        }

    }
}
