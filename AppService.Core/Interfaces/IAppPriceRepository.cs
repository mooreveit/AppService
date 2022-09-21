

using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppPriceRepository
    {
        Task<List<AppPrice>> GetAllByAppProduct(int appProductId);

        Task<AppPrice> GetById(int id);

        Task Add(AppPrice entity);

        void Update(AppPrice entity);

        Task Delete(int id);

        Task<AppPrice> GetByProductoDesdeHastaId(
          int apprpoductId,
          Decimal desde,
          Decimal hasta);

        Task<AppPrice> GetByProductoCantidad(int apprpoductId, Decimal cantidad);

        Task<AppPrice> GetFirstPriceByProduct(int apprpoductId);

        Task<bool> ProductExist(int appProductId);
    }
}
