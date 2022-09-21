
using AppService.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductConversionRepository
    {
        IQueryable<AppProductConversion> GetAll();

        Task<List<AppProductConversion>> GetAllByProduct(int appProductId);

        Task<AppProductConversion> GetByProductBaseUnitAlternativeUnit(
          int appProductId,
          int appUnitBase,
          int appUnitAlternative);

        Task<AppProductConversion> GetById(int id);

        Task Add(AppProductConversion entity);

        void Update(AppProductConversion entity);

        Task Delete(int id);
    }
}
