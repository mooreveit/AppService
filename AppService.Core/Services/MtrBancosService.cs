using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrBancosService: IMtrBancosService
    {



        private readonly IUnitOfWork _unitOfWork;
        public MtrBancosService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<MtrBancos>> GetAll()
        {

            var mtrBancos =  await _unitOfWork.MtrBancosRepository.GetAll();



            return mtrBancos;
        }


        public async Task<IEnumerable<MtrBancosDto>> GetAllFilter(MtrBancosQueryFilter filters)
        {

            var mtrBancosDto = await  _unitOfWork.MtrBancosRepository.GetBancos(filters.idTipoTransaccion);

            

            return mtrBancosDto;
        }

        public async Task<MtrBancos> GetByCodigo(string id)
        {
            return await _unitOfWork.MtrBancosRepository.GetByCodigo(id);
        }

        public async Task<MtrBancos> Insert(MtrBancos mtrBancos)
        {


            await _unitOfWork.MtrBancosRepository.Add(mtrBancos);
            await _unitOfWork.SaveChangesAsync();
            return mtrBancos;
        }




        public async Task<MtrBancos> Update(MtrBancos mtrBancos)
        {

            var bancos = await GetByCodigo(mtrBancos.Codigo);
            if (bancos == null)
            {
                throw new Exception("Banco No existe");
            }

            _unitOfWork.MtrBancosRepository.Update(bancos);
            await _unitOfWork.SaveChangesAsync();

            return await GetByCodigo(bancos.Codigo);

        }

        public async Task<bool> Delete(string id)
        {
            await _unitOfWork.MtrBancosRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }


    }
}
