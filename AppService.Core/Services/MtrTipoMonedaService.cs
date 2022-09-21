using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrTipoMonedaService:IMtrTipoMonedaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MtrTipoMonedaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<MtrTipoMoneda> GetAll(MtrTipoMonedaQueryFilter filters)
        {

            var mtrTipoMoneda = _unitOfWork.MtrTipoMonedaRepository.GetAll();

            return mtrTipoMoneda;
        }

        public async Task<MtrTipoMoneda> GetById(long id)
        {
            return await _unitOfWork.MtrTipoMonedaRepository.GetById(id);
        }

        public async Task<MtrTipoMoneda> Insert(MtrTipoMoneda mtrTipoMoneda)
        {


            await _unitOfWork.MtrTipoMonedaRepository.Add(mtrTipoMoneda);
            await _unitOfWork.SaveChangesAsync();
            return mtrTipoMoneda;
        }




        public async Task<MtrTipoMoneda> Update(MtrTipoMoneda mtrTipoMoneda)
        {

            var monedas = await GetById(mtrTipoMoneda.Id);
            if (monedas == null)
            {
                throw new Exception("Banco No existe");
            }

            _unitOfWork.MtrTipoMonedaRepository.Update(mtrTipoMoneda);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(monedas.Id);

        }

        public async Task<bool> Delete(long id)
        {
            await _unitOfWork.MtrTipoMonedaRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
