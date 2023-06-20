using System;
using AppService.Core.Entities;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
	public interface IOfdAdjuntoCriterioRepository
	{

        Task<OfdAdjuntoCriterio> Add(OfdAdjuntoCriterio entity);

    }
}

