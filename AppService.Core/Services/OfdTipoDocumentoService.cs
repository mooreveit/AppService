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
    public class OfdTipoDocumentoService: IOfdTipoDocumentoService
    {


        private readonly IUnitOfWork _unitOfWork;
        public OfdTipoDocumentoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<OfdTipoDocumento> GetAll(OfdTipoDocumentoQueryFilter filters)
        {

            var tipoDocumento = _unitOfWork.OfdTipoDocumentoRepository.GetAll();

            if (filters.IdTipoDocumento != null && filters.IdTipoDocumento>0)
            {
                tipoDocumento = tipoDocumento.Where(x => x.IdTipoDocumento == filters.IdTipoDocumento);
            }
            if (filters.IdGrupoTipoDocumento != null && filters.IdGrupoTipoDocumento>0)
            {
                tipoDocumento = tipoDocumento.Where(x => x.IdGrupoTipoDocumento == filters.IdGrupoTipoDocumento);
            }

            if (filters.NombreDocumento != null && filters.NombreDocumento!= "")
            {
                tipoDocumento = tipoDocumento.Where(x => x.NombreDocumento.ToLower().Contains(filters.NombreDocumento.ToLower()) );
            }


            return tipoDocumento;
        }

        public async Task<OfdTipoDocumento> GetById(short id)
        {
            try
            {
                var result = await _unitOfWork.OfdTipoDocumentoRepository.GetById(id);
                return result;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return null;
            }
             
        }

        public async Task<OfdTipoDocumento> Insert(OfdTipoDocumento ofdTipoDocumento)
        {
      
          
            await _unitOfWork.OfdTipoDocumentoRepository.Add(ofdTipoDocumento);
            await _unitOfWork.SaveChangesAsync();
            return ofdTipoDocumento;
        }




        public async Task<OfdTipoDocumento> Update(OfdTipoDocumento ofdTipoDocumento)
        {

            var tipoDocumento = await GetById(ofdTipoDocumento.IdTipoDocumento);
            if (tipoDocumento == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.OfdTipoDocumentoRepository.Update(tipoDocumento);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(ofdTipoDocumento.IdTipoDocumento);

        }

        public async Task<bool> Delete(short id)
        {
            await _unitOfWork.OfdTipoDocumentoRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }




    }
}
