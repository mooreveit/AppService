
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Enumerations;
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
    public class AppRecipesByAppDetailQuotesService : IAppRecipesByAppDetailQuotesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppProductsService _appProductsService;
        private readonly IHelperService _helperService;
        private readonly IAppVariablesService _appVariablesService;
        private readonly IAppVariableSearchService _appVariableSearchService;
        private readonly IAppConfigAppService appConfigAppService;

        private readonly PaginationOptions _paginationOptions;

        public AppRecipesByAppDetailQuotesService(
          IUnitOfWork unitOfWork,
          IMapper mapper,
          IOptions<PaginationOptions> options,
          IAppProductsService appProductsService,
          IHelperService helperService,
          IAppVariablesService appVariablesService,
          IAppVariableSearchService appVariableSearchService,
          IAppConfigAppService appConfigAppService
         )
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._appProductsService = appProductsService;
            this._helperService = helperService;
            this._appVariablesService = appVariablesService;
            this._appVariableSearchService = appVariableSearchService;
            this.appConfigAppService = appConfigAppService;
            this._paginationOptions = options.Value;
        }

        public async Task<List<AppRecipesByAppDetailQuotes>> GetListByCalculoId(
          int calculoId)
        {
            return await this._unitOfWork.AppRecipesByAppDetailQuotesRepository.GetAllByCalculoId(calculoId);
        }

        public async Task<AppRecipesByAppDetailQuotes> GetById(int id) => await this._unitOfWork.AppRecipesByAppDetailQuotesRepository.GetById(id);

        public async Task<AppRecipesByAppDetailQuotes> Update(
          AppRecipesByAppDetailQuotes appRecipes)
        {
            if (await this.GetById(appRecipes.Id) == null)
                throw new Exception("Documento No existe");
            this._unitOfWork.AppRecipesByAppDetailQuotesRepository.Update(appRecipes);
            await this._unitOfWork.SaveChangesAsync();
            return await this.GetById(appRecipes.Id);
        }

        public async Task DeleteRange(List<AppRecipesByAppDetailQuotes> entity)
        {
            this._unitOfWork.AppRecipesByAppDetailQuotesRepository.DeleteRange(entity);
            await this._unitOfWork.SaveChangesAsync();
        }

        public async Task<ApiResponse<AppPriceGetDto>> GetPrice(appRecipesByAppDetailQuotesQueryFilter filter)
        {
            var tasa = await _unitOfWork.TPaTasaReferencialRepository.GetTasaByFecha(DateTime.Now);
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> result = new ApiResponse<AppPriceGetDto>(null);

            if (filter.Cantidad <= 0)
            {

                result.Data = null;
                metadata.IsValid = false;
                metadata.Message = "Cantidad Invalida";
                result.Meta = metadata;
                return result;

            }

            var municipio = await _unitOfWork.Winy243Repository.GetById(filter.IdMunicipio);
            if (municipio == null)
            {
                result.Data = null;
                metadata.IsValid = false;
                metadata.Message = "Id municipio no existe";
                result.Meta = metadata;
                return result;
            }



            AppProducts appProducts = await _appProductsService.GetById(filter.AppProuctId);
            if (appProducts != null)
            {




                var porcFlete = await _unitOfWork.Winy243Repository.GetFleteByIdMunicipo(filter.IdMunicipio);

                if (appProducts.TipoCalculo == (int)TipoCalculoEnum.PrecioPorProductoCantidad)
                {
                    var precioProductoCantidad = await GetPrecioProductoCantidad(filter.AppProuctId, filter.Cantidad);
                    precioProductoCantidad.Precio = Utility.TruncateDec.TruncateDecimal(precioProductoCantidad.Precio, 2);
                    precioProductoCantidad.Flete = (precioProductoCantidad.Precio * porcFlete) / 100;

                    precioProductoCantidad.Flete = Utility.TruncateDec.TruncateDecimal(precioProductoCantidad.Flete, 2);
                    precioProductoCantidad.PrecioMasFlete = precioProductoCantidad.Precio + precioProductoCantidad.Flete;

                    precioProductoCantidad.Tasa = (decimal)tasa.Tasa;

                    result.Data = precioProductoCantidad;
                    metadata.IsValid = true;
                    metadata.Message = "Precio Generado Satisfactoriamente";
                    result.Meta = metadata;

                }





                if (appProducts.TipoCalculo == (int)TipoCalculoEnum.PrecioPorProducto)
                {



                    AppPriceGetDto resultPrice = new AppPriceGetDto();
                    resultPrice.AppproductsId = filter.AppProuctId;
                    resultPrice.CalculoId = 0;
                    resultPrice.Desde = filter.Cantidad;
                    resultPrice.Hasta = filter.Cantidad;
                    resultPrice.Precio = appProducts.UnitPrice;
                    resultPrice.Precio = Utility.TruncateDec.TruncateDecimal(resultPrice.Precio, 2);
                    resultPrice.Tasa = (decimal)tasa.Tasa;
                    var defaultConversion = await GetDefaultConversionByProduct(filter.AppProuctId);
                    if (defaultConversion != null)
                    {
                        Conversion conversion = new Conversion((decimal)defaultConversion.XNumerador, (decimal)defaultConversion.YDenominador, filter.Cantidad);
                        resultPrice.CantidadConvertida = conversion.getCantidadAlternativa(); ;
                    }
                    else
                    {
                        resultPrice.CantidadConvertida = filter.Cantidad;
                    }


                    resultPrice.Flete = (resultPrice.Precio * porcFlete) / 100;
                    resultPrice.Flete = Utility.TruncateDec.TruncateDecimal(resultPrice.Flete, 2);
                    resultPrice.PrecioMasFlete = resultPrice.Precio + resultPrice.Flete;
                    result.Data = resultPrice;
                    metadata.Message = "Precio Generado Satisfactoriamente";
                    result.Meta = metadata;
                    result.Meta.IsValid = true;





                }
                if (appProducts.TipoCalculo == (int)TipoCalculoEnum.RequiereEntradaLargoAncho)
                {

                    if (filter.Largo == null || filter.Largo <= 0)
                    {

                        result.Data = null;
                        metadata.IsValid = false;
                        metadata.Message = "Medida largo Invalida";
                        result.Meta = metadata;
                        return result;

                    }
                    if (filter.Ancho == null || filter.Ancho <= 0)
                    {

                        result.Data = null;
                        metadata.IsValid = false;
                        metadata.Message = "Medida ancho Invalida";
                        result.Meta = metadata;
                        return result;

                    }

                    var resultConversion = await CalculaConversion(filter.Cantidad, (decimal)filter.Largo, (decimal)filter.Ancho);
                    var price = await _unitOfWork.AppPriceRepository.GetByProductoCantidad(filter.AppProuctId, resultConversion.resulCantidad);
                    AppPriceGetDto resultPrice = new AppPriceGetDto();
                    resultPrice.AppproductsId = filter.AppProuctId;
                    resultPrice.CalculoId = 0;
                    resultPrice.Desde = filter.Cantidad;
                    resultPrice.Hasta = filter.Cantidad;
                    resultPrice.Precio = Utility.TruncateDec.TruncateDecimal(price.Precio, 2);
                    resultPrice.Flete = (resultPrice.Precio * porcFlete) / 100;
                    resultPrice.Flete = Utility.TruncateDec.TruncateDecimal(resultPrice.Flete, 2);
                    resultPrice.PrecioMasFlete = resultPrice.Precio + resultPrice.Flete;
                    resultPrice.Tasa = (decimal)tasa.Tasa;
                    resultPrice.CantidadConvertida = Utility.TruncateDec.TruncateDecimal(resultConversion.resulCantidad, 3);
                    result.Data = resultPrice;
                    metadata.Message = "Precio Generado Satisfactoriamente";
                    result.Meta = metadata;
                    result.Meta.IsValid = true;

                }

            }
            else
            {
                result.Data = null;
                metadata.IsValid = false;
                metadata.Message = "Codigo de producto no existe";
                result.Meta = metadata;
            }


            result.Data.Tasa = (decimal)tasa.Tasa;
            result.Data.PrecioBs = Utility.TruncateDec.TruncateDecimal(result.Data.Precio * (decimal)tasa.Tasa, 2);

            result.Data.FleteBs = Utility.TruncateDec.TruncateDecimal(result.Data.Flete * (decimal)tasa.Tasa, 2);
            result.Data.PrecioMasFleteBs = Utility.TruncateDec.TruncateDecimal(result.Data.PrecioMasFlete * (decimal)tasa.Tasa, 2);
            result.Data.SubTotalBs = Utility.TruncateDec.TruncateDecimal(result.Data.SubTotal * (decimal)tasa.Tasa, 2);

            return result;
        }



        public class ParametrosMaquina
        {

            public decimal AdicionalProduccion { get; set; }
            public decimal AdicionalProduccionOpuesta { get; set; }
            public decimal MedidaOpuestaRollo { get; set; }
            public decimal MedidaBasicaRollo { get; set; }

            public ParametrosMaquina(decimal adicionalProduccion, decimal adicionalProduccionOpuesta, decimal medidaOpuestaRollo, decimal medidaBasicaRollo)
            {
                AdicionalProduccion = adicionalProduccion;
                AdicionalProduccionOpuesta = adicionalProduccionOpuesta;
                MedidaOpuestaRollo = medidaOpuestaRollo;
                MedidaBasicaRollo = medidaBasicaRollo;

            }



        }

        public async Task<ResultConversionUnidadesMetrosCuadrados> CalculaConversion(decimal cantidadSolicitada, decimal medidaBasica, decimal medidaOpuesta)
        {

            var parametrosDto = await appConfigAppService.getParametrosMaquina();


            ParametrosMaquina parametrosMaquinas = new ParametrosMaquina(
                parametrosDto.AdicionalProduccion,
                parametrosDto.AdicionalProduccionOpuesta,
                parametrosDto.MedidaOpuestaRollo, parametrosDto.MedidaBasicaRollo);

            if (cantidadSolicitada <= 0)
            {
                return null;
            }

            if (cantidadSolicitada <= 0)
            {
                return null;
            }
            if (medidaBasica <= 0)
            {
                return null;
            }
            if (medidaOpuesta <= 0)
            {
                return null;
            }



            var conversion = new ConversionUnidadesMetrosCuadrados(
                        parametrosMaquinas.AdicionalProduccion,
                        parametrosMaquinas.AdicionalProduccionOpuesta,
                        parametrosMaquinas.MedidaBasicaRollo,
                        parametrosMaquinas.MedidaOpuestaRollo);


            conversion.cantidadBase = cantidadSolicitada;
            conversion.medidaBasica = medidaBasica;
            conversion.medidaOpuesta = medidaOpuesta;
            var result = conversion.getCantidadPorUnidad();
            ResultConversionUnidadesMetrosCuadrados resultObject = new ResultConversionUnidadesMetrosCuadrados();
            resultObject.cantidadPorUnidad = result;
            resultObject.area = conversion.area;
            resultObject.resulCantidad = cantidadSolicitada / result;
            return resultObject;


        }

        public async Task<AppProductConversion> GetDefaultConversionByProduct(int appProductId)
        {
            AppProductConversion result = new AppProductConversion();
            var product = await _unitOfWork.AppProductsRepository.GetById(appProductId);
            if (product != null)
            {
                var appProductConversion = await _unitOfWork.AppProductConversionRepository.GetByProductBaseUnitAlternativeUnit
                        (appProductId, (int)product.ProductionUnitId, (int)product.AppUnitsId);
                result = appProductConversion;

            }

            return result;
        }
        public async Task<AppPriceGetDto> GetPrecioProductoCantidad(
          int productId,
          Decimal cantidad)
        {
            AppPriceGetDto result = new AppPriceGetDto();
            int calculoId = await this.GenerarCalculoPorProductoCantidad(productId, cantidad);
            await this.CalulateRecipeByCalculoId(calculoId);
            Decimal precio = this._unitOfWork.AppRecipesByAppDetailQuotesRepository.TotalCost(calculoId);
            result.AppproductsId = productId;
            result.CalculoId = new int?(calculoId);
            result.Desde = cantidad;
            result.Hasta = cantidad;
            precio = Utility.TruncateDec.TruncateDecimal(precio, 2);
            result.Precio = precio;

            var defaultConversion = await GetDefaultConversionByProduct(productId);
            Conversion conversion = new Conversion((decimal)defaultConversion.XNumerador, (decimal)defaultConversion.YDenominador, cantidad);
            result.CantidadConvertida = conversion.getCantidadAlternativa();

            List<AppRecipesByAppDetailQuotes> calculoList = await this.GetListByCalculoId(calculoId);
            if (calculoList.Count > 0)
            {
                await this._unitOfWork.AppRecipesByAppDetailQuotesRepository.AddRangeHistory(this.CrearListaHistoricoCalculo(calculoList));
                await this._unitOfWork.SaveChangesAsync();
                await this.DeleteRange(calculoList);
            }
            AppPriceGetDto productoCantidad = result;
            result = (AppPriceGetDto)null;
            calculoList = (List<AppRecipesByAppDetailQuotes>)null;
            return productoCantidad;
        }

        public List<AppRecipesByAppDetailQuotesHistory> CrearListaHistoricoCalculo(
          List<AppRecipesByAppDetailQuotes> entities)
        {
            List<AppRecipesByAppDetailQuotesHistory> detailQuotesHistoryList = new List<AppRecipesByAppDetailQuotesHistory>();
            foreach (AppRecipesByAppDetailQuotes entity in entities)
            {
                AppRecipesByAppDetailQuotesHistory detailQuotesHistory = new AppRecipesByAppDetailQuotesHistory()
                {
                    CalculoId = entity.CalculoId,
                    AppproductsId = entity.AppproductsId,
                    AppVariableId = entity.AppVariableId,
                    Description = entity.Description,
                    AppIngredientsId = entity.AppIngredientsId,
                    Quantity = entity.Quantity,
                    TotalCost = entity.TotalCost,
                    Formula = entity.Formula,
                    FormulaValue = entity.FormulaValue,
                    SumValue = entity.SumValue,
                    OrderCalculate = entity.OrderCalculate,
                    Code = entity.Code,
                    IncludeInSearch = entity.IncludeInSearch,
                    Secuencia = entity.Secuencia,
                    AfectaCosto = entity.AfectaCosto,
                    VariablesSearchText = entity.VariablesSearchText,
                    TruncarEntero = entity.TruncarEntero,
                    EsVariableDeEntrada = entity.EsVariableDeEntrada
                };
                detailQuotesHistoryList.Add(detailQuotesHistory);
            }
            return detailQuotesHistoryList;
        }

        public async Task<int> GenerarCalculoPorProductoCantidad(int productId, Decimal cantidad)
        {
            int result = 0;
            List<AppRecipesByAppDetailQuotes> byAppDetailQuotesList = new List<AppRecipesByAppDetailQuotes>();
            List<AppRecipes> recipes = await this._unitOfWork.AppRecipesRepository.GetAllRecipesByProductId(productId);
            if (recipes != null)
            {
                int calculoId = await this.NextId();
                result = calculoId;
                if ((await this._unitOfWork.AppRecipesByAppDetailQuotesRepository.GetAllByCalculoId(calculoId)).Count == 0)
                {
                    foreach (AppRecipes appRecipes in recipes)
                    {
                        AppRecipesByAppDetailQuotes entity = new AppRecipesByAppDetailQuotes()
                        {
                            CalculoId = calculoId,
                            AppproductsId = appRecipes.AppproductsId,
                            AppVariableId = appRecipes.AppVariableId,
                            Description = appRecipes.Description,
                            AppIngredientsId = appRecipes.AppIngredientsId,
                            Quantity = appRecipes.Quantity,
                            TotalCost = appRecipes.TotalCost,
                            Formula = appRecipes.Formula,
                            FormulaValue = appRecipes.FormulaValue,
                            SumValue = appRecipes.SumValue,
                            OrderCalculate = appRecipes.OrderCalculate,
                            Code = appRecipes.Code,
                            IncludeInSearch = appRecipes.IncludeInSearch,
                            Secuencia = appRecipes.Secuencia,
                            AfectaCosto = appRecipes.AfectaCosto,
                            VariablesSearchText = appRecipes.VariablesSearchText,
                            TruncarEntero = appRecipes.TruncarEntero,
                            EsVariableDeEntrada = appRecipes.EsVariableDeEntrada
                        };
                        int? appVariableId = appRecipes.AppVariableId;
                        int num = 92;
                        if (appVariableId.GetValueOrDefault() == num & appVariableId.HasValue)
                            entity.Quantity = new Decimal?(cantidad);
                        await this._unitOfWork.AppRecipesByAppDetailQuotesRepository.Add(entity);
                        await this._unitOfWork.SaveChangesAsync();
                    }
                }
            }
            int num1 = result;
            recipes = (List<AppRecipes>)null;
            return num1;
        }

        public async Task<Decimal> CalculateFormula(AppRecipesByAppDetailQuotes recipe)
        {
            try
            {
                Decimal result = 0M;
                if (recipe == null)
                {
                    result = 0M;
                    return result;
                }
                var producto = await _unitOfWork.AppProductsRepository.GetById((int)recipe.AppproductsId);

                string valueFormula = await this.GetValueFormula(recipe.CalculoId, recipe.Formula, producto.Code, recipe.Code);
                object obj = new DataTable().Compute(valueFormula, "");
                obj.ToString();
                result = Convert.ToDecimal(obj.ToString());
                if (recipe.AfectaCosto.Value)
                {
                    recipe.TotalCost = new Decimal?(result);
                }
                else
                {
                    bool? truncarEntero = recipe.TruncarEntero;
                    bool flag = true;
                    recipe.Quantity = !(truncarEntero.GetValueOrDefault() == flag & truncarEntero.HasValue) ? new Decimal?(result) : new Decimal?(Decimal.Truncate(result));
                }
                recipe.FormulaValue = valueFormula;
                AppRecipesByAppDetailQuotes byAppDetailQuotes = await this.Update(recipe);
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return 0M;
            }
        }

        public async Task<string> GetValueFormula(
          int calculoId,
          string formula,
          string codeProduct,
          string codeRecipe)
        {
            string newFormula = "";
            List<string> listString = this._helperService.GetListString(formula, "[", "]");
            newFormula = formula;
            foreach (string item in listString)
            {
                List<AppRecipesByAppDetailQuotes> codeVariableCode = await this._unitOfWork.AppRecipesByAppDetailQuotesRepository.GetListRecipesByProductCodeVariableCode(calculoId, codeProduct, item);
                if (codeVariableCode != null && codeVariableCode.Count > 0)
                {
                    if (codeVariableCode.FirstOrDefault<AppRecipesByAppDetailQuotes>().AfectaCosto.Value)
                    {
                        Decimal? nullable = codeVariableCode.Select<AppRecipesByAppDetailQuotes, Decimal?>((Func<AppRecipesByAppDetailQuotes, Decimal?>)(c => c.TotalCost)).Sum();
                        newFormula = newFormula.Replace("[" + item + "]", nullable.ToString());
                    }
                    else
                    {
                        Decimal? quantity = codeVariableCode.FirstOrDefault<AppRecipesByAppDetailQuotes>().Quantity;
                        newFormula = newFormula.Replace("[" + item + "]", quantity.ToString());
                    }
                }
                else
                {
                    AppConfigApp byKey = await this._unitOfWork.AppConfigAppRepository.GetByKey(item);
                    if (byKey != null)
                        newFormula = newFormula.Replace("[" + item + "]", byKey.Valor.ToString());
                }
            }
            string valueFormula = newFormula;
            newFormula = (string)null;
            return valueFormula;
        }

        public async Task ValidaFormula(AppRecipes recipe)
        {
            string newFormula = "";
            string mensaje = "";
            List<string> listString = this._helperService.GetListString(recipe.Formula, "[", "]");

            foreach (string item in listString)
            {
                var recetaVariable = await _unitOfWork.AppRecipesRepository.GetRecipesByProductIdCode((int)recipe.AppproductsId, item);
                if (recetaVariable != null)
                {
                    if (recetaVariable.OrderCalculate >= recipe.OrderCalculate)
                    {
                        mensaje = item + " con orden de calculo" + recetaVariable.OrderCalculate + " >= " + recipe.OrderCalculate + " " + recipe.Description;
                    }
                }

            }

            var recipeFind = await _unitOfWork.AppRecipesRepository.GetById(recipe.Id);
            if (recipeFind != null)
            {
                recipeFind.MensajeValidacionFormula = mensaje;
                _unitOfWork.AppRecipesRepository.Update(recipeFind);
                await _unitOfWork.SaveChangesAsync();

            }

        }



        public async Task CalulateRecipeByCalculoId(int calculoId)
        {
            List<AppRecipesByAppDetailQuotes> allByCalculoId = await this._unitOfWork.AppRecipesByAppDetailQuotesRepository.GetAllByCalculoId(calculoId);
            if (allByCalculoId == null)
                return;
            foreach (AppRecipesByAppDetailQuotes recipe in allByCalculoId.Where<AppRecipesByAppDetailQuotes>((Func<AppRecipesByAppDetailQuotes, bool>)(x => x.Formula.Length > 0)).OrderBy<AppRecipesByAppDetailQuotes, Decimal?>((Func<AppRecipesByAppDetailQuotes, Decimal?>)(x => x.OrderCalculate)).ToList<AppRecipesByAppDetailQuotes>())
            {
                Decimal formula = await this.CalculateFormula(recipe);
            }
        }

        public async Task<int> NextId()
        {
            int result = 0;
            AppConfigApp byKey = await this._unitOfWork.AppConfigAppRepository.GetByKey("ULTIMOCALCULO");
            if (byKey == null)
            {
                result = 1;
                await this._unitOfWork.AppConfigAppRepository.Add(new AppConfigApp()
                {
                    Clave = "ULTIMOCALCULO",
                    Valor = "1"
                });
                await this._unitOfWork.SaveChangesAsync();
            }
            else
            {
                result = Convert.ToInt32(byKey.Valor) + 1;
                byKey.Valor = result.ToString();
                this._unitOfWork.AppConfigAppRepository.Update(byKey);
                await this._unitOfWork.SaveChangesAsync();
            }
            return result;
        }





    }
}
