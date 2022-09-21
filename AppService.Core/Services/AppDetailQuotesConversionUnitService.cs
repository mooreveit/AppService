using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppDetailQuotesConversionUnitService : IAppDetailQuotesConversionUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppProductsService _appProductsService;
        private readonly IHelperService _helperService;
        //private readonly IAppDetailQuotesService _appDetailQuotesService;
        private readonly PaginationOptions _paginationOptions;

        public AppDetailQuotesConversionUnitService(IUnitOfWork unitOfWork,
                                    IMapper mapper,
                                    IOptions<PaginationOptions> options,
                                    IAppProductsService appProductsService,
                                    IHelperService helperService/*,
                                    IAppDetailQuotesService appDetailQuotesService*/)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _appProductsService = appProductsService;
            _helperService = helperService;
            //_appDetailQuotesService = appDetailQuotesService;
            _paginationOptions = options.Value;
        }

        public async Task<AppDetailQuotesConversionUnit> GetById(int id)
        {
            return await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetById(id);
        }

        public async Task<AppDetailQuotesConversionUnit> Insert(AppDetailQuotesConversionUnit appDetailQuotesConversionUnit)
        {


            await _unitOfWork.AppDetailQuotesConversionUnitRepository.Add(appDetailQuotesConversionUnit);
            await _unitOfWork.SaveChangesAsync();
            return appDetailQuotesConversionUnit;


        }
        public async Task<ApiResponse<List<AppDetailQuotesConversionUnit>>> CreateAppDetailQuotesConversionUnit(AppDetailQuotesConversionUnitCreateDto appDetailQuotesConversionUnitCreateDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            List<AppDetailQuotesConversionUnit> resultDto = new List<AppDetailQuotesConversionUnit>();
            ApiResponse<List<AppDetailQuotesConversionUnit>> response = new ApiResponse<List<AppDetailQuotesConversionUnit>>(resultDto);

            try
            {
                AppDetailQuotes newDetail = new AppDetailQuotes();
                if (appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId == 0)
                {
                    newDetail = await CreateDetaiQuotes(appDetailQuotesConversionUnitCreateDto);

                    if (newDetail != null)
                    {
                        appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId = newDetail.Id;
                    }

                }


                await DeteleAppDetailQuotesByDetailQuotesId(appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId);

                List<AppTemplateConversionUnit> template = await _unitOfWork.AppTemplateConversionUnitRepository.GetTemplateByUnits(appDetailQuotesConversionUnitCreateDto.AppUnitIdSince, appDetailQuotesConversionUnitCreateDto.AppUnitIdUntil);
                var listDetailQuotesConversion = await CreateListFromTemplate(template, (int)appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId);
                foreach (var item in listDetailQuotesConversion)
                {
                    var variable = appDetailQuotesConversionUnitCreateDto.AppTemplateConversionUnitGetDto.Where(x => x.AppVariableId == item.AppVariableId).FirstOrDefault();
                    if (variable != null && item.Formula == "")
                    {
                        item.Value = variable.Value;
                    }
                    await Insert(item);

                }


                await CalculateAppDetailQuotesByDetailQuotesId(appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId);

                var totalValue = _unitOfWork.AppDetailQuotesConversionUnitRepository.TotalValue(appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId);
                var cantidadPorUnidadProduccion = _unitOfWork.AppDetailQuotesConversionUnitRepository.GetCantidadPorUnidadProduccion(appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId);
                var detailQuote = await _unitOfWork.AppDetailQuotesRepository.GetById(appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId);
                if (detailQuote != null)
                {
                    detailQuote.ValorConvertido = totalValue;
                    detailQuote.CantidadPorUnidadProduccion = cantidadPorUnidadProduccion;
                    detailQuote.UnitPriceBaseProduction = detailQuote.IdProductoNavigation.UnitPrice;
                    if (detailQuote.UnitPriceBaseProduction > 0)
                    {
                        detailQuote.UnitPriceConverted = detailQuote.UnitPriceBaseProduction * detailQuote.ValorConvertido;
                    }
                    else
                    {
                        detailQuote.UnitPriceConverted = 0;
                    }
                    detailQuote.IdUnidad = appDetailQuotesConversionUnitCreateDto.AppUnitIdSince;
                    _unitOfWork.AppDetailQuotesRepository.Update(detailQuote);
                    await _unitOfWork.SaveChangesAsync();

                }

                resultDto = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId);
                response.Meta = metadata;
                response.Data = resultDto;


                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;


                return response;

            }





        }


        public async Task<AppDetailQuotes> CreateDetaiQuotes(AppDetailQuotesConversionUnitCreateDto dto)
        {

            var generalQuotes = await _unitOfWork.AppGeneralQuotesRepository.GetById(dto.AppGeneralQuotesId);
            if (generalQuotes != null)
            {
                AppDetailQuotes newDetail = new AppDetailQuotes();
                newDetail.AppGeneralQuotesId = dto.AppGeneralQuotesId;
                newDetail.Cotizacion = generalQuotes.Cotizacion;
                newDetail.DiasEntrega = 1;
                newDetail.IdProducto = dto.AppProductId;
                var producto = await _unitOfWork.AppProductsRepository.GetById(dto.AppProductId);
                newDetail.NombreComercialProducto = producto.Description1;
                newDetail.Cantidad = 1;
                newDetail.DiasEntrega = 1;
                newDetail.IdEstatus = generalQuotes.IdEstatus;
                newDetail.IdUnidad = dto.AppUnitIdSince;
                newDetail.PrecioUsd = 0;
                newDetail.Precio = 0;
                newDetail.Total = 0;
                newDetail.TotalUsd = 0;
                newDetail.FechaRegistro = DateTime.Now;
                newDetail.CreatedAt = DateTime.Now;
                newDetail.UpdatedAt = DateTime.Now;
                newDetail.Observaciones = "";
                newDetail.UserCreate = "";
                await _unitOfWork.AppDetailQuotesRepository.Add(newDetail);
                await _unitOfWork.SaveChangesAsync();

                return await _unitOfWork.AppDetailQuotesRepository.GetById(newDetail.Id);
            }
            else
            {
                return null;
            }




        }


        public async Task<ApiResponse<UnitConvertedGetDto>> ConversionUnitGeneric(AppConversionUnitGenericCreateDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            UnitConvertedGetDto resultDto = new UnitConvertedGetDto();
            ApiResponse<UnitConvertedGetDto> response = new ApiResponse<UnitConvertedGetDto>(resultDto);

            try
            {

                var product = await _unitOfWork.AppProductsRepository.GetById(dto.AppProductId);

                List<AppTemplateConversionUnit> templateNew = new List<AppTemplateConversionUnit>();

                List<AppTemplateConversionUnit> template = await _unitOfWork.AppTemplateConversionUnitRepository.GetTemplateByUnits(dto.AppUnitIdSince, (int)product.ProductionUnitId);

                foreach (var item in template)
                {
                    var variable = dto.AppTemplateConversionGenericUnitGetDto.Where(x => x.AppVariableId == item.AppVariableId).FirstOrDefault();
                    if (variable != null)
                    {
                        item.Value = variable.Value;




                    }
                    templateNew.Add(item);

                }

                List<AppTemplateConversionUnit> templateCalculated = new List<AppTemplateConversionUnit>();
                foreach (var item in templateNew)
                {

                    if (item.Formula != "")
                    {
                        var newItemCalculated = await CalculateFormulaGeneric(item, templateNew);

                        templateCalculated.Add(newItemCalculated);
                    }
                    else
                    {
                        templateCalculated.Add(item);
                    }

                }



                var totalValue = TotalValue(templateCalculated);
                var ValorConvertido = totalValue;
                var UnitPriceBaseProduction = product.UnitPrice;
                //var UnitPriceConverted = ValorConvertido / UnitPriceBaseProduction;
                var UnitPriceConverted = UnitPriceBaseProduction * ValorConvertido;
                resultDto.UnitPriceBaseProduction = UnitPriceBaseProduction;
                resultDto.UnitPriceConverted = UnitPriceConverted;
                resultDto.ValorConvertido = ValorConvertido;
                resultDto.CantidadPorUnidadProduccion = GetCantidadPorUnidadProduccion(templateCalculated);


                response.Meta = metadata;
                response.Data = resultDto;


                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;


                return response;

            }





        }

        public decimal TotalValue(List<AppTemplateConversionUnit> listTemplate)
        {

            var total = (from c in listTemplate
                         where c.SumValue == true
                         select c.Value).Sum();

            return (decimal)total;
        }
        public decimal GetCantidadPorUnidadProduccion(List<AppTemplateConversionUnit> listTemplate)
        {

            var total = (from c in listTemplate
                         where c.Code == "CANTIDADPORUNIDAD" || c.Code == "CANTIDADPORUNIDAD2"
                         select c.Value).OrderByDescending(c => c.Value).FirstOrDefault();


            return (decimal)total;
        }



        public async Task DeteleAppDetailQuotesByDetailQuotesId(int appDetailQuotesId)
        {
            var appDetailQuotesConversionUnit = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(appDetailQuotesId);

            if (appDetailQuotesConversionUnit != null)
            {
                foreach (var item in appDetailQuotesConversionUnit)
                {
                    await Delete(item.Id);
                }
            }

        }

        public async Task<List<AppDetailQuotesConversionUnit>> CreateListFromTemplate(List<AppTemplateConversionUnit> listAppTemplateConversionUnits, int appDetailQuotesId)
        {


            List<AppDetailQuotesConversionUnit> result = new List<AppDetailQuotesConversionUnit>();

            foreach (AppTemplateConversionUnit item in listAppTemplateConversionUnits)
            {
                AppDetailQuotesConversionUnit appDetailQuotesConversionUnit = new AppDetailQuotesConversionUnit
                {
                    AppDetailQuotesId = appDetailQuotesId,
                    AppVariableId = item.AppVariableId,
                    Description = item.Description,
                    Value = item.Value,
                    Formula = item.Formula,
                    FormulaValue = item.FormulaValue,
                    OrderCalculate = item.OrderCalculate,
                    Code = item.Code,
                    SumValue = item.SumValue,
                    Min = item.Min,
                    Max = item.Max
                };

                result.Add(appDetailQuotesConversionUnit);



            }

            return result;
        }




        public async Task<AppDetailQuotesConversionUnit> Update(AppDetailQuotesConversionUnit appDetailQuotesConversionUnit)
        {

            AppDetailQuotesConversionUnit appDetailQuotesConversionUnitFind = await GetById(appDetailQuotesConversionUnit.Id);
            if (appDetailQuotesConversionUnitFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppDetailQuotesConversionUnitRepository.Update(appDetailQuotesConversionUnit);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appDetailQuotesConversionUnit.Id);


        }

        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.AppDetailQuotesConversionUnitRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
        public async Task<decimal> CalculateFormula(AppDetailQuotesConversionUnit appDetailQuotesConversionUnit)
        {
            try
            {

                decimal result = 0;


                if (appDetailQuotesConversionUnit == null)
                {
                    result = 0;
                }
                else
                {

                    string formula = await GetValueFormula(appDetailQuotesConversionUnit.Formula, (int)appDetailQuotesConversionUnit.AppDetailQuotesId, appDetailQuotesConversionUnit.Code);
                    DataTable dt = new DataTable();
                    object calculate = dt.Compute(formula, "");
                    string a = calculate.ToString();
                    result = Convert.ToDecimal(calculate.ToString());

                    appDetailQuotesConversionUnit.Value = result;
                    appDetailQuotesConversionUnit.FormulaValue = formula;
                    await Update(appDetailQuotesConversionUnit);





                }



                return result;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                return 0;

            }



        }


        public async Task<AppTemplateConversionUnit> CalculateFormulaGeneric(AppTemplateConversionUnit appTemplateConversionUnit, List<AppTemplateConversionUnit> template)
        {
            try
            {

                decimal result = 0;

                AppTemplateConversionUnit res = new AppTemplateConversionUnit();

                if (appTemplateConversionUnit == null)
                {
                    result = 0;
                }
                else
                {

                    string formula = await GetValueFormulaGeneric(appTemplateConversionUnit.Formula, template, appTemplateConversionUnit.Code);
                    DataTable dt = new DataTable();
                    object calculate = dt.Compute(formula, "");
                    string a = calculate.ToString();
                    result = Convert.ToDecimal(calculate.ToString());

                    appTemplateConversionUnit.Value = result;
                    appTemplateConversionUnit.FormulaValue = formula;

                    res = appTemplateConversionUnit;




                }



                return res;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                return null;

            }



        }
        public async Task<string> GetValueFormula(string formula, int appDetailQuotesId, string code)
        {

            string newFormula = "";

            List<string> variablesList = _helperService.GetListString(formula, "[", "]");

            newFormula = formula;
            foreach (string item in variablesList)
            {
                var detailQuotes = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesIdCode(appDetailQuotesId, item);

                if (detailQuotes != null)
                {
                    var variable = await _unitOfWork.AppVariablesRepository.GetByCode(item);
                    if (variable != null)
                    {
                        if (variable.Entero)
                        {
                            //if (detailQuotes.Value < 1) detailQuotes.Value = 1;
                            //Math.Truncate(floatNumber)
                            newFormula = newFormula.Replace("[" + item + "]", Math.Truncate((decimal)detailQuotes.Value).ToString());
                        }
                        else
                        {

                            newFormula = newFormula.Replace("[" + item + "]", detailQuotes.Value.ToString());
                        }
                    }

                }
                else
                {
                    var configApp = await _unitOfWork.AppConfigAppRepository.GetByKey(item);

                    if (configApp != null)
                    {
                        newFormula = newFormula.Replace("[" + item + "]", configApp.Valor.ToString());
                    }
                }
            }


            return newFormula;

        }

        public async Task<string> GetValueFormulaGeneric(string formula, List<AppTemplateConversionUnit> template, string code)
        {

            string newFormula = "";

            List<string> variablesList = _helperService.GetListString(formula, "[", "]");

            newFormula = formula;
            foreach (string item in variablesList)
            {
                //var detailQuotes = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesIdCode(appDetailQuotesId, item);

                var detailQuotes = template.Where(x => x.Code == item).FirstOrDefault();

                if (detailQuotes != null)
                {
                    var variable = await _unitOfWork.AppVariablesRepository.GetByCode(item);
                    if (variable != null)
                    {
                        if (variable.Entero)
                        {

                            newFormula = newFormula.Replace("[" + item + "]", Math.Truncate((decimal)detailQuotes.Value).ToString());
                        }
                        else
                        {
                            newFormula = newFormula.Replace("[" + item + "]", detailQuotes.Value.ToString());
                        }

                    }


                }
                else
                {
                    var configApp = await _unitOfWork.AppConfigAppRepository.GetByKey(item);

                    if (configApp != null)
                    {
                        newFormula = newFormula.Replace("[" + item + "]", configApp.Valor.ToString());
                    }
                }
            }


            return newFormula;

        }





        public async Task<List<AppDetailQuotesConversionUnit>> CalculateAppDetailQuotesByDetailQuotesId(int appDetailQuotesId)
        {



            List<AppDetailQuotesConversionUnit> resultDto = new List<AppDetailQuotesConversionUnit>();
            var appDetailQuotesConversionUnit = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(appDetailQuotesId);



            if (appDetailQuotesConversionUnit == null)
            {
                return resultDto;
            }
            else
            {
                foreach (AppDetailQuotesConversionUnit item in appDetailQuotesConversionUnit.OrderBy(x => x.OrderCalculate).Where(x => x.Formula != "").ToList())
                {
                    await CalculateFormula(item);
                }

                //await UpdatePriceByProduct(productId);
                resultDto = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(appDetailQuotesId);
                return resultDto;
            }


        }



        public async Task<List<AppTemplateConversionUnit>> CalculateGenericConversion(List<AppTemplateConversionUnit> dto)
        {



            List<AppTemplateConversionUnit> resultDto = new List<AppTemplateConversionUnit>();


            if (dto == null)
            {
                return resultDto;
            }
            else
            {
                foreach (AppTemplateConversionUnit item in dto.OrderBy(x => x.OrderCalculate).Where(x => x.Formula != "").ToList())
                {
                    var newItem = await CalculateFormulaGeneric(item, dto);
                    resultDto.Add(newItem);
                }

                //await UpdatePriceByProduct(productId);
                //resultDto = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(appDetailQuotesId);
                return resultDto;
            }


        }


    }
}
