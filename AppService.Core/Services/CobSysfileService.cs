using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobSysfileService: ICobSysfileService
    {

        private readonly IUnitOfWork _unitOfWork;
        public CobSysfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CobSysfile> GetAll()
        {

            return _unitOfWork.CobSysfileRepository.GetAll();

         
        }

        public async Task<CobSysfile> GetById(short id)
        {
            return await _unitOfWork.CobSysfileRepository.GetById(id);
        }

        public async Task<CobSysfile> Insert(CobSysfile cobSysfile)
        {


            await _unitOfWork.CobSysfileRepository.Add(cobSysfile);
            await _unitOfWork.SaveChangesAsync();
            return cobSysfile;
        }




        public async Task<CobSysfile> Update(CobSysfile cobSysfile)
        {

            var sysfile = await GetById(cobSysfile.Id);
            if (sysfile == null)
            {
                throw new Exception("Registro No existe");
            }

            _unitOfWork.CobSysfileRepository.Update(sysfile);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(cobSysfile.Id);

        }

        public async Task<bool> Delete(short id)
        {
            await _unitOfWork.CobSysfileRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }


    }
}
