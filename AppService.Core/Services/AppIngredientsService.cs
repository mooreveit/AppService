using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.EntitiesMaestros;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppIngredientsService : IAppIngredientsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;
        private readonly IAppUnitsService _appUnitsService;
        private readonly IMtrTipoMonedaService _mtrTipoMonedaService;
        private readonly IAppRecipesServices _appRecipesServices;

        public AppIngredientsService(IUnitOfWork unitOfWork,
                                     IOptions<PaginationOptions> options,
                                     IMapper mapper,
                                     IAppUnitsService appUnitsService,
                                     IMtrTipoMonedaService mtrTipoMonedaService,
                                     IAppRecipesServices appRecipesServices)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;
            _appUnitsService = appUnitsService;
            _mtrTipoMonedaService = mtrTipoMonedaService;
            _appRecipesServices = appRecipesServices;
        }

        public async Task<List<AppIngredients>> GetAll()
        {

            List<AppIngredients> appIngredients = await _unitOfWork.AppIngredientsRepository.GetAll();

            return appIngredients;
        }

        public async Task<ApiResponse<List<AppIngredientsGetDto>>> GetAllFilter(AppIngredientsQueryFilter filter)
        {
            filter.PageNumber = filter.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filter.PageNumber;
            filter.PageSize = filter.PageSize == 0 ? _paginationOptions.DefaultPageSize : filter.PageSize;

            List<AppIngredientsGetDto> resultDto = new List<AppIngredientsGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppIngredientsGetDto>> response = new ApiResponse<List<AppIngredientsGetDto>>(resultDto);

            try
            {

                List<AppIngredients> appIngredients = await _unitOfWork.AppIngredientsRepository.GetAllFilter(filter);


                if (appIngredients != null)
                {
                    List<AppIngredientsGetDto> appIngredientsDto = _mapper.Map<List<AppIngredientsGetDto>>(appIngredients);
                    foreach (AppIngredientsGetDto item in appIngredientsDto)
                    {
                        AppUnits AppUnitsFind = await _appUnitsService.GetById(item.AppUnitId);
                        if (AppUnitsFind != null)
                        {
                            AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                            item.AppUnitsGetDto = appUnitsGetDto;
                        }
                        MtrTipoMoneda MtrTipoMonedaFind = await _mtrTipoMonedaService.GetById((long)item.PrymaryMtrMonedaId);
                        if (MtrTipoMonedaFind != null)
                        {
                            MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaFind);
                            item.PrymaryMtrMonedaDto = mtrTipoMonedaDto;
                        }

                        MtrTipoMonedaFind = await _mtrTipoMonedaService.GetById((long)item.SecundaryMtrMonedaId);
                        if (MtrTipoMonedaFind != null)
                        {
                            MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaFind);
                            item.SecundaryMtrMonedaDto = mtrTipoMonedaDto;
                        }



                    }




                    response.Data = appIngredientsDto;
                    response.Meta = metadata;
                    return response;
                }
                else
                {

                    metadata.IsValid = true;
                    metadata.Message = "No Data....";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
            }
            catch (Exception ex)
            {


                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }



        }

        public async Task<AppIngredients> GetById(int id)
        {
            return await _unitOfWork.AppIngredientsRepository.GetById(id);
        }

        public async Task<AppIngredients> Insert(AppIngredients appIngredients)
        {


            await _unitOfWork.AppIngredientsRepository.Add(appIngredients);
            await _unitOfWork.SaveChangesAsync();
            return appIngredients;


        }

        public async Task<ApiResponse<AppIngredientsGetDto>> CreateAppIngredient(AppIngredientsCreateDto dto)
        {

            AppIngredientsGetDto resultDto = new AppIngredientsGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppIngredientsGetDto> response = new ApiResponse<AppIngredientsGetDto>(resultDto);


            try
            {
                AppIngredients appIngredients = _mapper.Map<AppIngredients>(dto);

                if (dto.Code == null || dto.Code == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo Invalido";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                if (dto.Description == null || dto.Description == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Descripcion Invalida";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }
                if (dto.Cost <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Costo Invalido";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                AppUnits AppUnitsFind = await _appUnitsService.GetById(dto.AppUnitId);
                if (AppUnitsFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Unidad de Medida no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }
                MtrTipoMoneda MtrTipoMonedaPrymaryFind = await _mtrTipoMonedaService.GetById((long)dto.PrymaryMtrMonedaId);
                if (MtrTipoMonedaPrymaryFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Primaria no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                MtrTipoMoneda MtrTipoMonedaSecundaryFind = await _mtrTipoMonedaService.GetById((long)dto.SecundaryMtrMonedaId);
                if (MtrTipoMonedaSecundaryFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Secundaria no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                appIngredients.UserCreate = dto.UsuarioConectado;
                appIngredients.UserUpdate = dto.UsuarioConectado;
                appIngredients.CreatedAt = DateTime.Now;
                appIngredients.UpdatedAt = DateTime.Now;
                var inserted = await Insert(appIngredients);

                resultDto = _mapper.Map<AppIngredientsGetDto>(inserted);

                if (AppUnitsFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                    resultDto.AppUnitsGetDto = appUnitsGetDto;
                }

                if (MtrTipoMonedaPrymaryFind != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaPrymaryFind);
                    resultDto.PrymaryMtrMonedaDto = mtrTipoMonedaDto;
                }


                if (MtrTipoMonedaSecundaryFind != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaSecundaryFind);
                    resultDto.SecundaryMtrMonedaDto = mtrTipoMonedaDto;
                }

                response.Data = resultDto;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }




        public async Task<AppIngredients> Update(AppIngredients appIngredients)
        {

            AppIngredients AppIngredientsFind = await GetById(appIngredients.Id);
            if (AppIngredientsFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppIngredientsRepository.Update(appIngredients);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appIngredients.Id);


        }

        public async Task<ApiResponse<AppIngredientsGetDto>> UpdateAppIngredient(AppIngredientsUpdateDto dto)
        {

            AppIngredientsGetDto resultDto = new AppIngredientsGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppIngredientsGetDto> response = new ApiResponse<AppIngredientsGetDto>(resultDto);


            try
            {

                var ingredient = await GetById(dto.Id);
                if (ingredient == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Ingrediente No existe";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }



                if (dto.Code == null || dto.Code == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo Invalido";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                if (dto.Description == null || dto.Description == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Descripcion Invalida";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }
                if (dto.Cost <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Costo Invalido";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                AppUnits AppUnitsFind = await _appUnitsService.GetById(dto.AppUnitId);
                if (AppUnitsFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Unidad de Medida no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }
                MtrTipoMoneda MtrTipoMonedaPrymaryFind = await _mtrTipoMonedaService.GetById((long)dto.PrymaryMtrMonedaId);
                if (MtrTipoMonedaPrymaryFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Primaria no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                MtrTipoMoneda MtrTipoMonedaSecundaryFind = await _mtrTipoMonedaService.GetById((long)dto.SecundaryMtrMonedaId);
                if (MtrTipoMonedaSecundaryFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Secundaria no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }
                ingredient.Code = dto.Code;
                ingredient.Description = dto.Description;
                ingredient.Cost = dto.Cost;
                ingredient.AppUnitId = dto.AppUnitId;
                ingredient.PrymaryMtrMonedaId = dto.PrymaryMtrMonedaId;
                ingredient.SecundaryMtrMonedaId = dto.SecundaryMtrMonedaId;

                ingredient.UserUpdate = dto.UsuarioConectado;
                ingredient.UpdatedAt = DateTime.Now;
                var updated = await Update(ingredient);

                resultDto = _mapper.Map<AppIngredientsGetDto>(updated);
                await RecalculateRecipesByIngredient(ingredient.Id);


                if (AppUnitsFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                    resultDto.AppUnitsGetDto = appUnitsGetDto;
                }

                if (MtrTipoMonedaPrymaryFind != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaPrymaryFind);
                    resultDto.PrymaryMtrMonedaDto = mtrTipoMonedaDto;
                }


                if (MtrTipoMonedaSecundaryFind != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaSecundaryFind);
                    resultDto.SecundaryMtrMonedaDto = mtrTipoMonedaDto;
                }

                response.Data = resultDto;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }
        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.AppIngredientsRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResponse<bool>> DeleteAppIngredients(AppIngredientsDeleteDto dto)
        {
            bool resultDto = true;

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);

            try
            {

                AppIngredients appIngredients = await GetById(dto.Id);

                if (appIngredients == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Ingrediente No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

                AppRecipes recipes = await _unitOfWork.AppRecipesRepository.GetRecipesByIdIngredients(dto.Id);

                if (recipes != null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Ingrediente existe en la formulacion!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

                resultDto = await Delete(dto.Id);

                metadata.IsValid = true;
                metadata.Message = $"Ingrediente Eliminada Satisfactoriamente!";

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


        public async Task RecalculateRecipesByIngredient(int id)
        {


            var recipes = await _unitOfWork.AppRecipesRepository.GetListRecipesByIdIngredients(id);

            var newResult =
            from c in recipes
            group c by new
            {
                c.AppproductsId,

            } into gcs
            select new
            {
                AppproductsId = (int)gcs.Key.AppproductsId,


            };


            if (newResult != null)
            {

                foreach (var item in newResult)
                {

                    await _appRecipesServices.UpdateIngredientsCostRecipeByProduct(item.AppproductsId);

                    await _appRecipesServices.CalulateRecipeByProduct(item.AppproductsId);

                }

            }
        }


    }
}
