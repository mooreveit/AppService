using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrVendedorService: IMtrVendedorService
    {

        private readonly IUnitOfWork _unitOfWork;


        public MtrVendedorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<MtrVendedor>> ListVendedoresPorUsuario(MtrVendedorQueryFilter filter)
        {
            return await _unitOfWork.MtrVendedorRepository.ListvendedoresPorUsuario(filter);
        }

        public async Task<MtrVendedor> GetByIdAsync(string id)
        {
            return await _unitOfWork.MtrVendedorRepository.GetByIdAsync(id);
        }

        public MtrVendedor GetById(string id)
        {

            return  _unitOfWork.MtrVendedorRepository.GetById(id);
        }

    }
}
