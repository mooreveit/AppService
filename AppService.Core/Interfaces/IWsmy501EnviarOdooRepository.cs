using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy501EnviarOdooRepository
    {

        Task<List<Wsmy501EnviarOdoo>> GetAll();
        Task<Wsmy501EnviarOdoo> GetById(int id);
        Task Add(Wsmy501EnviarOdoo entity);
        void Update(Wsmy501EnviarOdoo entity);
        Task Delete(int id);

    }
}
