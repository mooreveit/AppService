using AppService.Core.EntitiesMooreve;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICompetidoresRepository
    {


        Task<List<Wsmy383>> GetAll();

        Task<List<Wsmy383>> GetAllByFilter(CompetidoresQueryFilter filter);


        Task<Wsmy383> GetById(int id);

        Task Add(Wsmy383 entity);

        void Update(Wsmy383 entity);

        Task Delete(int id);


    }
}
