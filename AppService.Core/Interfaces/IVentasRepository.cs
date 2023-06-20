using System;
using AppService.Core.EntitiesEstadisticas;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
	public interface IVentasRepository
	{

        Task<Venta> GetByOrden(long orden);

    }
}

