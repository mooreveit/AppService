using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry249Repository
    {
        Task<List<ValoresAdicionalesProducto>> BuscacaValoresAdicionales(string linea, string familia);

    }
}
