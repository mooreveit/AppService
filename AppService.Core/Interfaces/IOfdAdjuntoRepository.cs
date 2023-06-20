using System;
using AppService.Core.Entities;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
	public interface IOfdAdjuntoRepository
	{

      
        Task<OfdAdjunto> GetByFileName(string fileName);
        Task<OfdAdjunto> Add(OfdAdjunto entity);

    }
}

