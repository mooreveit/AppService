using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppTemplateConversionUnitRepository
    {

        Task<List<AppTemplateConversionUnit>> GetAll();

        Task<List<AppTemplateConversionUnit>> GetTemplateByUnits(int appUnitIdSince, int appUnitIdUntil);

        Task<AppTemplateConversionUnit> GetById(int id);

        Task Add(AppTemplateConversionUnit entity);

        void Update(AppTemplateConversionUnit entity);

        Task Delete(int id);
        Task<List<AppTemplateConversionUnit>> GetTemplateByUnitsInput(int appUnitIdSince, int appUnitIdUntil);

        Task<List<AppTemplateConversionUnit>> GetAllTemplateByUnitsInput(int appUnitIdSince, int appUnitIdUntil);
    }
}
