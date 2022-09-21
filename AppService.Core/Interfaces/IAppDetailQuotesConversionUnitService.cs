using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppDetailQuotesConversionUnitService
    {

        Task<AppDetailQuotesConversionUnit> GetById(int id);

        Task<AppDetailQuotesConversionUnit> Insert(AppDetailQuotesConversionUnit appDetailQuotesConversionUnit);

        Task<ApiResponse<List<AppDetailQuotesConversionUnit>>> CreateAppDetailQuotesConversionUnit(AppDetailQuotesConversionUnitCreateDto appDetailQuotesConversionUnitCreateDto);



        Task DeteleAppDetailQuotesByDetailQuotesId(int appDetailQuotesId);

        Task<List<AppDetailQuotesConversionUnit>> CreateListFromTemplate(List<AppTemplateConversionUnit> listAppTemplateConversionUnits, int appDetailQuotesId);

        Task<AppDetailQuotesConversionUnit> Update(AppDetailQuotesConversionUnit appDetailQuotesConversionUnit);


        Task<bool> Delete(int id);

        Task<decimal> CalculateFormula(AppDetailQuotesConversionUnit appDetailQuotesConversionUnit);


        Task<string> GetValueFormula(string formula, int appDetailQuotesId, string code);


        Task<List<AppDetailQuotesConversionUnit>> CalculateAppDetailQuotesByDetailQuotesId(int appDetailQuotesId);


        Task<ApiResponse<UnitConvertedGetDto>> ConversionUnitGeneric(AppConversionUnitGenericCreateDto dto);

    }
}
