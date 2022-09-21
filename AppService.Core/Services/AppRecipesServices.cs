using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
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
    public class AppRecipesServices : IAppRecipesServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppProductsService _appProductsService;
        private readonly IHelperService _helperService;
        private readonly IAppVariablesService _appVariablesService;
        private readonly IAppVariableSearchService _appVariableSearchService;
        private readonly IAppProductVariableSearchTextService _appProductVariableSearchTextService;
        private readonly PaginationOptions _paginationOptions;

        public AppRecipesServices(
          IUnitOfWork unitOfWork,
          IMapper mapper,
          IOptions<PaginationOptions> options,
          IAppProductsService appProductsService,
          IHelperService helperService,
          IAppVariablesService appVariablesService,
          IAppVariableSearchService appVariableSearchService,
          IAppProductVariableSearchTextService appProductVariableSearchTextService)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._appProductsService = appProductsService;
            this._helperService = helperService;
            this._appVariablesService = appVariablesService;
            this._appVariableSearchService = appVariableSearchService;
            this._appProductVariableSearchTextService = appProductVariableSearchTextService;
            this._paginationOptions = options.Value;
        }

        public async Task<List<AppRecipes>> GetRecipesByProductId(int productId) => await this._unitOfWork.AppRecipesRepository.GetRecipesByProductId(productId);

        public async Task<List<AppRecipes>> GetAllRecipesByProductId(int productId) => await this._unitOfWork.AppRecipesRepository.GetAllRecipesByProductId(productId);

        public async Task<List<AppRecipesGetDto>> GetRecipesGetDtoByProductId(
          AppRecipesQueryFilter filter)
        {
            List<AppRecipesGetDto> resultDto = new List<AppRecipesGetDto>();
            List<AppRecipes> source = await this.GetAllRecipesByProductId(filter.AppproductsId);
            if (source != null)
            {
                if (filter.SearchText != "" && filter.SearchText != null)
                    source = source.Where<AppRecipes>((Func<AppRecipes, bool>)(x => x.Description.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Code.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Formula.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()))).ToList<AppRecipes>();
                List<AppRecipesGetDto> recipesDto = this._mapper.Map<List<AppRecipesGetDto>>((object)source);
                foreach (AppRecipesGetDto item in recipesDto)
                {
                    if (item.MensajeValidacionFormula == null)
                    {
                        item.MensajeValidacionFormula = "";
                    }



                    IAppProductsService appProductsService = this._appProductsService;
                    int? nullable = item.AppproductsId;
                    int id1 = nullable.Value;
                    AppProducts byId1 = await appProductsService.GetById(id1);
                    if (byId1 != null)
                        item.AppProductsGetDto = this._mapper.Map<AppProductsGetDto>((object)byId1);
                    IAppVariablesService variablesService = this._appVariablesService;
                    nullable = item.AppVariableId;
                    int id2 = nullable.Value;
                    AppVariables byId2 = await variablesService.GetById(id2);
                    if (byId2 != null)
                        item.AppVariablesGetDto = this._mapper.Map<AppVariablesGetDto>((object)byId2);
                    nullable = item.AppIngredientsId;
                    if (nullable.HasValue)
                    {
                        IAppIngredientsRepository ingredientsRepository = this._unitOfWork.AppIngredientsRepository;
                        nullable = item.AppIngredientsId;
                        int id3 = nullable.Value;
                        AppIngredients byId3 = await ingredientsRepository.GetById(id3);
                        if (byId3 != null)
                            item.AppIngredientsGetDto = this._mapper.Map<AppIngredientsGetDto>((object)byId3);
                    }

                }
                resultDto = recipesDto;
                recipesDto = (List<AppRecipesGetDto>)null;
            }
            List<AppRecipesGetDto> getDtoByProductId = resultDto;
            resultDto = (List<AppRecipesGetDto>)null;
            return getDtoByProductId;
        }

        public async Task<AppRecipes> GetById(int id) => await this._unitOfWork.AppRecipesRepository.GetById(id);

        public async Task<AppRecipes> Insert(AppRecipes appRecipes)
        {
            await this._unitOfWork.AppRecipesRepository.Add(appRecipes);
            await this._unitOfWork.SaveChangesAsync();
            return appRecipes;
        }

        public async Task<ApiResponse<List<AppRecipesGetDto>>> CreateAppRecipes(
          AppRecipesCreateDto dto)
        {
            AppRecipesServices appRecipesServices1 = this;
            List<AppRecipesGetDto> data = new List<AppRecipesGetDto>();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<List<AppRecipesGetDto>> response = new ApiResponse<List<AppRecipesGetDto>>(data);
            try
            {
                AppRecipes appRecipes = appRecipesServices1._mapper.Map<AppRecipes>((object)dto);
                if (await appRecipesServices1._appProductsService.GetById(dto.AppproductsId.Value) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto no existe!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                AppVariables byId1 = await appRecipesServices1._appVariablesService.GetById(dto.AppVariableId.Value);
                if (byId1 == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Variable no existe!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                appRecipes.Code = byId1.Code;
                appRecipes.Description = byId1.Description;
                appRecipes.Quantity = dto.Quantity;
                appRecipes.SumValue = new bool?(dto.SumValue);
                appRecipes.OrderCalculate = new Decimal?(dto.OrderCalculate);
                appRecipes.IncludeInSearch = new bool?(dto.IncludeInSearch);
                appRecipes.AfectaCosto = new bool?(dto.AfectaCosto);
                appRecipes.TruncarEntero = new bool?(dto.TruncarEntero);
                appRecipes.Secuencia = new int?(dto.Secuencia);
                appRecipes.EsVariableDeEntrada = dto.EsVariableDeEntrada;
                appRecipes.DescriptionSearch = dto.DescriptionSearch;
                int? nullable1 = dto.AppIngredientsId;
                if (!nullable1.HasValue)
                    dto.AppIngredientsId = new int?(39);
                nullable1 = dto.AppIngredientsId;
                if (nullable1.HasValue)
                {
                    IAppIngredientsRepository ingredientsRepository = appRecipesServices1._unitOfWork.AppIngredientsRepository;
                    nullable1 = dto.AppIngredientsId;
                    int id = nullable1.Value;
                    AppIngredients byId2 = await ingredientsRepository.GetById(id);
                    if (byId2 == null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Ingrediente no existe!!";
                        response.Data = (List<AppRecipesGetDto>)null;
                        response.Meta = metadata;
                        return response;
                    }
                    if (dto.AfectaCosto)
                    {
                        AppRecipes appRecipes1 = appRecipes;
                        Decimal cost = byId2.Cost;
                        Decimal? quantity = appRecipes.Quantity;
                        Decimal? nullable2 = quantity.HasValue ? new Decimal?(cost * quantity.GetValueOrDefault()) : new Decimal?();
                        appRecipes1.TotalCost = nullable2;
                    }
                    else
                        appRecipes.TotalCost = new Decimal?(0M);
                }
                else
                {
                    if (dto.Formula == "" || dto.Formula == null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Debe Indicar Una formula o seleccionar un ingrediente!!";
                        response.Data = (List<AppRecipesGetDto>)null;
                        response.Meta = metadata;
                        return response;
                    }
                    appRecipes.TotalCost = new Decimal?(0M);
                    appRecipes.Formula = dto.Formula;
                    appRecipes.FormulaValue = "";
                }
                // ISSUE: explicit non-virtual call
                AppRecipes appRecipes2 = await appRecipesServices1.Insert(appRecipes);
                AppRecipesServices appRecipesServices2 = appRecipesServices1;
                nullable1 = dto.AppproductsId;
                int productId1 = nullable1.Value;
                await appRecipesServices2.UpdateVariableSearchByProduct(productId1);
                AppRecipesServices appRecipesServices3 = appRecipesServices1;
                nullable1 = dto.AppproductsId;
                int productId2 = nullable1.Value;
                // ISSUE: explicit non-virtual call
                response.Data = await appRecipesServices3.CalulateRecipeByProduct(productId2);
                response.Meta = metadata;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = (List<AppRecipesGetDto>)null;
                response.Meta = metadata;
                return response;
            }
        }

        public async Task<AppRecipes> Update(AppRecipes appRecipes)
        {
            if (await this.GetById(appRecipes.Id) == null)
                throw new Exception("Documento No existe");
            this._unitOfWork.AppRecipesRepository.Update(appRecipes);
            await this._unitOfWork.SaveChangesAsync();
            return await this.GetById(appRecipes.Id);
        }

        public async Task<ApiResponse<List<AppRecipesGetDto>>> UpdateAppRecipes(
          AppRecipesUpdateDto dto)
        {

            AppConfigApp appConfigApp = await _unitOfWork.AppConfigAppRepository.GetByKey("RecalcularTodosLosProductos");
            if (appConfigApp != null && appConfigApp.Valor == "1")
            {
                await CalculateAllProduct();
            }

            List<AppRecipesGetDto> data = new List<AppRecipesGetDto>();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<List<AppRecipesGetDto>> response = new ApiResponse<List<AppRecipesGetDto>>(data);
            try
            {


                if (dto.Formula.Length > 0)
                {
                    long CantParentesisInicial = dto.Formula.LongCount(letra => letra.ToString() == "(");
                    long CantParentesisFinal = dto.Formula.LongCount(letra => letra.ToString() == ")");
                    long CantCorchetesInicial = dto.Formula.LongCount(letra => letra.ToString() == "[");
                    long CantCorchetesFinalsFinal = dto.Formula.LongCount(letra => letra.ToString() == "]");

                    if (CantParentesisInicial != CantParentesisFinal)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Cantitad de parentesis en Formula Invalidos!!";
                        response.Data = (List<AppRecipesGetDto>)null;
                        response.Meta = metadata;
                        return response;
                    }
                    if (CantCorchetesInicial != CantCorchetesFinalsFinal)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Cantitad de corchetes en Formula Invalidos!!";
                        response.Data = (List<AppRecipesGetDto>)null;
                        response.Meta = metadata;
                        return response;
                    }

                }



                AppRecipes recipe = await GetById(dto.Id);
                if (recipe == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Receta no existe!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                if (await _appProductsService.GetById(dto.AppproductsId.Value) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto no existe!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                AppVariables byId1 = await _appVariablesService.GetById(dto.AppVariableId.Value);
                if (byId1 == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Variable no existe!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                recipe.AppVariableId = new int?(byId1.Id);
                recipe.Code = byId1.Code;
                recipe.Description = byId1.Description;
                recipe.Quantity = dto.Quantity;
                recipe.SumValue = new bool?(dto.SumValue);
                recipe.OrderCalculate = dto.OrderCalculate;
                recipe.IncludeInSearch = new bool?(dto.IncludeInSearch);
                recipe.AfectaCosto = new bool?(dto.AfectaCosto);
                recipe.TruncarEntero = new bool?(dto.TruncarEntero);
                recipe.EsVariableDeEntrada = dto.EsVariableDeEntrada;
                recipe.Secuencia = new int?(dto.Secuencia);
                recipe.DescriptionSearch = dto.DescriptionSearch;
                recipe.Formula = dto.Formula;
                if (recipe.Formula.Trim().Length <= 0)
                    recipe.FormulaValue = "";
                if (!dto.AppIngredientsId.HasValue)
                    dto.AppIngredientsId = new int?(39);
                recipe.AppIngredientsId = dto.AppIngredientsId;
                int? nullable1 = dto.AppIngredientsId;
                if (nullable1.HasValue)
                {
                    IAppIngredientsRepository ingredientsRepository = _unitOfWork.AppIngredientsRepository;
                    nullable1 = dto.AppIngredientsId;
                    int id = nullable1.Value;
                    AppIngredients byId2 = await ingredientsRepository.GetById(id);
                    if (byId2 == null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Ingrediente no existe!!";
                        response.Data = (List<AppRecipesGetDto>)null;
                        response.Meta = metadata;
                        return response;
                    }
                    if (dto.AfectaCosto)
                    {
                        AppRecipes appRecipes = recipe;
                        Decimal cost = byId2.Cost;
                        Decimal? quantity = recipe.Quantity;
                        Decimal? nullable2 = quantity.HasValue ? new Decimal?(cost * quantity.GetValueOrDefault()) : new Decimal?();
                        appRecipes.TotalCost = nullable2;
                    }
                    else
                        recipe.TotalCost = new Decimal?(0M);
                }
                else
                {
                    if (dto.Formula == "" || dto.Formula == null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Debe Indicar Una formula o seleccionar un ingrediente!!";
                        response.Data = (List<AppRecipesGetDto>)null;
                        response.Meta = metadata;
                        return response;
                    }
                    recipe.TotalCost = new Decimal?(0M);
                    recipe.Formula = dto.Formula;
                    recipe.FormulaValue = "";
                }
                await ValidaFormula(recipe);
                await UpdateVariableSearchByProduct((int)dto.AppproductsId);
                List<AppRecipesGetDto> appRecipesGetDtoList = await CalulateRecipeByProduct((int)dto.AppproductsId);
                metadata.IsValid = true;
                metadata.Message = "Receta actualizada!";
                response.Data = appRecipesGetDtoList;
                response.Meta = metadata;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = (List<AppRecipesGetDto>)null;
                response.Meta = metadata;
                return response;
            }
        }

        public async Task CalculateAllProduct()
        {
            int contador = 0;
            int subcategory = 0;
            AppConfigApp appConfigApp = await this._unitOfWork.AppConfigAppRepository.GetByKey("SubCategoriaARecalcular");
            if (appConfigApp != null)
                subcategory = Convert.ToInt32(appConfigApp.Valor);
            var productos = (await this._unitOfWork.AppProductsRepository.GetAll()).Where<AppProducts>((Func<AppProducts, bool>)(x =>
            {
                int? appSubCategoryId = x.AppSubCategoryId;
                int num = subcategory;
                return appSubCategoryId.GetValueOrDefault() == num & appSubCategoryId.HasValue;
            })).OrderBy<AppProducts, int>((Func<AppProducts, int>)(y => y.Id)).ToList<AppProducts>();


            foreach (AppProducts appProduct in productos)
            {
                await this.UpdateVariableSearchByProduct(appProduct.Id);
                ++contador;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await this._unitOfWork.AppRecipesRepository.Delete(id);
                await this._unitOfWork.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<ApiResponse<bool>> DeleteAppRecipes(AppRecipesDeleteDto dto)
        {
            bool resultDto = true;
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);
            try
            {
                AppRecipes byId = await this.GetById(dto.Id);
                if (byId == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Receta no  No existe!!!";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.AppRecipesRepository.GetRecipesByCodeInFormula(byId.AppproductsId.Value, byId.Code) != null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Variable esta siendo usada en la formulacion!!!";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                resultDto = await this.Delete(dto.Id);
                metadata.IsValid = true;
                metadata.Message = "Variable  Eliminada de la Receta Satisfactoriamente!";
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

        public async Task<AppRecipes> GetRecipesByProductIdVariableId(
          int productId,
          int variableId)
        {
            return await this._unitOfWork.AppRecipesRepository.GetRecipesByProductIdVariableId(productId, variableId);
        }

        public async Task<string> ValidaFormula(AppRecipes recipe)
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
                        mensaje = mensaje + item + " con orden de calculo" + recetaVariable.OrderCalculate + " >= " + recipe.OrderCalculate + " " + recipe.Description;
                    }
                }

            }

            return mensaje;
            /*var recipeFind = await GetById(recipe.Id);
            if (recipeFind != null)
            {
                recipeFind.MensajeValidacionFormula = mensaje;
                await Update(recipeFind);

            }*/

        }


        public async Task<Decimal> CalculateFormula(AppRecipes recipe)
        {
            try
            {
                Decimal result = 0M;
                if (recipe == null)
                {
                    result = 0M;
                    return result;
                }
                string valueFormula = await this.GetValueFormula(recipe.Formula, recipe.Appproducts.Code, recipe.Code);
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
                var mensaje = await ValidaFormula(recipe);
                recipe.MensajeValidacionFormula = mensaje;
                AppRecipes appRecipes = await this.Update(recipe);
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return 0M;
            }
        }

        public async Task<string> GetValueFormula(
          string formula,
          string codeProduct,
          string codeRecipe)
        {
            string newFormula = "";
            List<string> listString = this._helperService.GetListString(formula, "[", "]");
            newFormula = formula;
            foreach (string item in listString)
            {
                List<AppRecipes> codeVariableCode = await this._unitOfWork.AppRecipesRepository.GetListRecipesByProductCodeVariableCode(codeProduct, item);
                if (codeVariableCode != null && codeVariableCode.Count > 0)
                {
                    if (codeVariableCode.FirstOrDefault<AppRecipes>().AfectaCosto.Value)
                    {
                        Decimal? nullable = codeVariableCode.Select<AppRecipes, Decimal?>((Func<AppRecipes, Decimal?>)(c => c.TotalCost)).Sum();
                        newFormula = newFormula.Replace("[" + item + "]", nullable.ToString());
                    }
                    else
                    {
                        Decimal? quantity = codeVariableCode.FirstOrDefault<AppRecipes>().Quantity;
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

        public async Task UpdateIngredientsCostRecipeByProduct(int productId)
        {
            List<AppRecipes> ingredientsByProductId = await this._unitOfWork.AppRecipesRepository.GetRecipesWithIngredientsByProductId(productId);
            if (ingredientsByProductId == null)
                return;
            foreach (AppRecipes item in ingredientsByProductId)
            {
                AppRecipes byId = await this.GetById(item.Id);
                bool? afectaCosto = item.AfectaCosto;
                bool flag = true;
                if (afectaCosto.GetValueOrDefault() == flag & afectaCosto.HasValue)
                {
                    AppRecipes appRecipes = byId;
                    Decimal? quantity = byId.Quantity;
                    Decimal cost = item.AppIngredients.Cost;
                    Decimal? nullable = quantity.HasValue ? new Decimal?(quantity.GetValueOrDefault() * cost) : new Decimal?();
                    appRecipes.TotalCost = nullable;
                }
                else
                    byId.TotalCost = new Decimal?(0M);
                AppRecipes appRecipes1 = await this.Update(byId);
            }
        }


        public async Task ValidateAllReceipProduct()
        {
            List<AppRecipes> ingredientsByProductId = await this._unitOfWork.AppRecipesRepository.GetAll();
            if (ingredientsByProductId == null)
                return;
            foreach (AppRecipes item in ingredientsByProductId)
            {
                AppRecipes byId = await this.GetById(item.Id);
                var mensaje = await ValidaFormula(item);
                if (mensaje != byId.MensajeValidacionFormula)
                {
                    byId.MensajeValidacionFormula = mensaje;
                    AppRecipes appRecipes1 = await this.Update(byId);
                }

            }
        }


        public async Task<List<AppRecipesGetDto>> CalulateRecipeByProduct(
          int productId)
        {
            List<AppRecipesGetDto> resultDto = new List<AppRecipesGetDto>();
            AppRecipesQueryFilter filter = new AppRecipesQueryFilter();
            filter.AppproductsId = productId;
            filter.SearchText = "";
            List<AppRecipes> recipesByProductId = await this.GetRecipesByProductId(productId);
            if (recipesByProductId == null)
                return resultDto;
            foreach (AppRecipes recipe in recipesByProductId)
            {

                Decimal formula = await this.CalculateFormula(recipe);
            }
            await this.UpdatePriceByProduct(productId);
            resultDto = await this.GetRecipesGetDtoByProductId(filter);
            return resultDto;
        }

        public async Task UpdatePriceByProduct(int productId)
        {
            AppProducts producto = await this._appProductsService.GetById(productId);
            if (producto == null)
            {
                return;
            }

            Decimal num = this._unitOfWork.AppRecipesRepository.TotalCost(productId);
            producto.UnitPrice = num;
            AppProducts appProducts = await this._appProductsService.Update(producto);
        }

        public async Task DeleteAllVariableSearchByCategory(int subCategoryId)
        {
            int num = await this._appVariableSearchService.DeleteBySubCategory(subCategoryId) ? 1 : 0;
        }

        public async Task UpdateVariableSearchByProduct(int productId)
        {
            AppRecipesServices appRecipesServices1 = this;
            List<AppProductVariableSearchText> variableSearchTextList = new List<AppProductVariableSearchText>();
            AppProducts product = await appRecipesServices1._unitOfWork.AppProductsRepository.GetById(productId);
            if (product == null)
            {
                product = (AppProducts)null;
            }
            else
            {
                AppRecipesServices appRecipesServices2 = appRecipesServices1;
                int? nullable = product.AppSubCategoryId;
                int subCategoryId = nullable.Value;
                await appRecipesServices2.DeleteAllVariableSearchByCategory(subCategoryId);
                List<AppProductVariableSearchText> listByProduct = await appRecipesServices1._unitOfWork.AppProductVariableSearchTextRepository.GetListByProduct(productId);
                if (listByProduct.Count > 0)
                {
                    int num1 = await appRecipesServices1._appProductVariableSearchTextService.DeleteByRange(listByProduct) ? 1 : 0;
                }
                string searchText = "";


                List<AppRecipes> idIncludeInSearch = await _unitOfWork.AppRecipesRepository.GetRecipesByCategoryIdIncludeInSearch((int)product.AppSubCategoryId);
                if (idIncludeInSearch != null)
                {
                    foreach (AppRecipes item in idIncludeInSearch.OrderBy(rp => rp.AppproductsId).ThenBy(rv => rv.AppVariableId).ToList())
                    {
                        string value = "";


                        if (item.DescriptionSearch != null && item.DescriptionSearch.Length > 0)
                        {
                            value = item.DescriptionSearch.Trim();
                        }
                        else
                        {

                            AppIngredients appIngredientsFind = await _unitOfWork.AppIngredientsRepository.GetById((int)item.AppIngredientsId);
                            if (appIngredientsFind != null)
                            {


                                AppVariables appVariables = await _appVariablesService.GetById((int)item.AppVariableId);
                                if (appVariables != null)
                                {
                                    string str = string.Format("{0:0.00}", (object)item.Quantity);
                                    nullable = item.AppIngredientsId;
                                    int num2 = 39;
                                    if (!(nullable.GetValueOrDefault() == num2 & nullable.HasValue))
                                    {
                                        value = appIngredientsFind.Description.Trim();
                                        bool? afectaCosto = item.AfectaCosto;
                                        bool flag = false;
                                        if (afectaCosto.GetValueOrDefault() == flag & afectaCosto.HasValue)
                                            value = appVariables.Description.Trim() + " " + str;
                                    }
                                    else
                                        value = appVariables.Description.Trim() + " " + str;
                                }
                            }
                            else
                            {
                                AppVariables variable = await _appVariablesService.GetById((int)item.AppVariableId);
                                if (variable != null)
                                    value = variable.Description.Trim();
                            }

                        }


                        IAppVariableSearchService variableSearchService = appRecipesServices1._appVariableSearchService;
                        nullable = product.AppSubCategoryId;
                        int appSubCategoryId = nullable.Value;
                        nullable = item.AppVariableId;
                        int appVariableId = nullable.Value;
                        string searchText1 = value;
                        await variableSearchService.CreateVariableSearchTextBySubcategoryVariableSearchTex(appSubCategoryId, appVariableId, searchText1);
                        AppRecipes appRecipes = item;
                        nullable = item.AppVariableId;
                        string str1 = nullable.ToString().Trim() + value.Trim();
                        appRecipes.VariablesSearchText = str1;
                        appRecipesServices1._unitOfWork.AppRecipesRepository.Update(item);
                        if (item.AppproductsId == productId)
                        {
                            AppProductVariableSearchText variableSearchText = await appRecipesServices1._appProductVariableSearchTextService.Insert(new AppProductVariableSearchText()
                            {
                                AppProductId = new int?(productId),
                                AppVariableId = item.AppVariableId,
                                CodeVariable = item.AppVariable.Code,
                                SearchText = value.Trim()
                            });
                            if (searchText == "")
                            {
                                string str2 = searchText;
                                nullable = item.AppVariableId;
                                string str3 = nullable.ToString().Trim();
                                string str4 = value.Trim();
                                searchText = str2 + str3 + "-" + str4;
                            }
                            else
                            {
                                string[] strArray = new string[5]
                                {
                                  searchText,
                                  "-",
                                  null,
                                  null,
                                  null
                                };
                                nullable = item.AppVariableId;
                                strArray[2] = nullable.ToString().Trim();
                                strArray[3] = "-";
                                strArray[4] = value.Trim();
                                searchText = string.Concat(strArray);
                            }
                        }
                        value = (string)null;

                    }
                    product.VariablesSearchText = searchText;
                    AppProducts appProducts = await appRecipesServices1._appProductsService.Update(product);
                }
                searchText = (string)null;
                product = (AppProducts)null;
            }
        }

        public async Task<ApiResponse<List<AppRecipesGetDto>>> CopyRecipes(
          AppCopyRecipesDto appCopyRecipesDto)
        {
            List<AppRecipesGetDto> data = new List<AppRecipesGetDto>();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<List<AppRecipesGetDto>> response = new ApiResponse<List<AppRecipesGetDto>>(data);
            try
            {
                AppProducts productSince = await this._unitOfWork.AppProductsRepository.GetById(appCopyRecipesDto.productIdSince);
                if (productSince == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto desde no existe!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                AppProducts byId = await this._unitOfWork.AppProductsRepository.GetById(appCopyRecipesDto.productIdUntil);
                if (byId == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto hasta no existe!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                List<AppRecipes> recipesByProductId1 = await this.GetAllRecipesByProductId(byId.Id);
                if (recipesByProductId1 != null && recipesByProductId1.Count > 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto hasta ya tiene una receta asociada!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                List<AppRecipes> recipesByProductId2 = await this.GetAllRecipesByProductId(productSince.Id);
                if (recipesByProductId2 == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto desde no tiene una receta asociada!!";
                    response.Data = (List<AppRecipesGetDto>)null;
                    response.Meta = metadata;
                    return response;
                }
                foreach (AppRecipes appRecipes1 in recipesByProductId2)
                {
                    AppRecipes appRecipes2 = await this.Insert(new AppRecipes()
                    {
                        AppproductsId = new int?(appCopyRecipesDto.productIdUntil),
                        AppIngredientsId = appRecipes1.AppIngredientsId,
                        AppVariableId = appRecipes1.AppVariableId,
                        Code = appRecipes1.Code,
                        Description = appRecipes1.Description,
                        Formula = appRecipes1.Formula,
                        FormulaValue = appRecipes1.FormulaValue,
                        IncludeInSearch = appRecipes1.IncludeInSearch,
                        OrderCalculate = appRecipes1.OrderCalculate,
                        Quantity = appRecipes1.Quantity,
                        SumValue = appRecipes1.SumValue,
                        TotalCost = appRecipes1.TotalCost,
                        AfectaCosto = appRecipes1.AfectaCosto,
                        Secuencia = appRecipes1.Secuencia,
                        TruncarEntero = appRecipes1.TruncarEntero,
                        DescriptionSearch = appRecipes1.DescriptionSearch,
                        EsVariableDeEntrada = appRecipes1.EsVariableDeEntrada,
                        MensajeValidacionFormula = "",

                    });
                }
                await this.UpdateVariableSearchByProduct(appCopyRecipesDto.productIdUntil);
                response.Data = await this.CalulateRecipeByProduct(appCopyRecipesDto.productIdUntil);
                response.Meta = metadata;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = (List<AppRecipesGetDto>)null;
                response.Meta = metadata;
                return response;
            }
        }
    }
}
