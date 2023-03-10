using System;
using AppService.Core.Entities;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
	public interface IAppPorcentajeAdicionalM2Repository
	{
        Task<AppPorcentajeAdicionalM2> GetDesdeHasta(decimal cantidad);

        Task<bool> AplicarValorBase(decimal cantidadM2);

    }
}

