using System;
using AppService.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
	public interface IAppDesarrolloEtiquetasPrimeRepository
	{


        Task<List<AppDesarrolloEtiquetasPrime>> GetAll();

        Task<AppDesarrolloEtiquetasPrime> GetByMedidaBasica(decimal medidaBasica);
    }
}

