using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrOficinaService: IMtrOficinaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;

        public MtrOficinaService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
        }


        public async Task<PagedList<MtrOficina>> ListOficinasPorUsuario(MtrOficinaQueryFilter filter)
        {

            filter.PageNumber = filter.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filter.PageNumber;
            filter.PageSize = filter.PageSize == 0 ? _paginationOptions.DefaultPageSize : filter.PageSize;

            var oficinas = await _unitOfWork.MtrOficinaRepository.ListOficinasPorUsuario(filter);

            var pagedOficinas = PagedList<MtrOficina>.Create(oficinas, filter.PageNumber, filter.PageSize);

            return pagedOficinas;
        }

        public async Task<MtrOficina> GetOficina(short id)
        {

          

            var oficina = await _unitOfWork.MtrOficinaRepository.GetById(id);

           

            return oficina;
        }


    }
}
