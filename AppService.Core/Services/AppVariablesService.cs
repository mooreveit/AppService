using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppVariablesService : IAppVariablesService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppVariablesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<AppVariables>> GetAll()
        {

            List<AppVariables> variables = await _unitOfWork.AppVariablesRepository.GetAll();

            return variables;
        }


        public async Task<ApiResponse<List<AppVariablesGetDto>>> GetAllFilter(AppVariablesQueryFilter filter)
        {
            List<AppVariablesGetDto> resultDto = new List<AppVariablesGetDto>();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppVariablesGetDto>> response = new ApiResponse<List<AppVariablesGetDto>>(resultDto);

            List<AppVariables> variables = await _unitOfWork.AppVariablesRepository.GetAllFilter(filter);

            List<AppVariablesGetDto> variablesGetDto = _mapper.Map<List<AppVariablesGetDto>>(variables);

            response.Data = variablesGetDto;
            metadata.IsValid = true;
            metadata.Message = "";
            response.Meta = metadata;
            return response;


        }



        public async Task<AppVariables> GetById(int id)
        {
            return await _unitOfWork.AppVariablesRepository.GetById(id);
        }

        public async Task<AppVariables> Insert(AppVariables appVariables)
        {


            await _unitOfWork.AppVariablesRepository.Add(appVariables);
            await _unitOfWork.SaveChangesAsync();
            return appVariables;
        }
        public async Task<ApiResponse<AppVariablesGetDto>> CreateVariables(AppVariablesCreateDto dto)
        {
            AppVariablesGetDto resultDto = new AppVariablesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppVariablesGetDto> response = new ApiResponse<AppVariablesGetDto>(resultDto);

            try
            {


                AppRecipes recipes = await _unitOfWork.AppRecipesRepository.GetRecipesByVariableCode(dto.Code);

                if (recipes != null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "El Codigo de Variable ya existe en la formulacion!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }


                AppVariables appVariables = _mapper.Map<AppVariables>(dto);

                appVariables.TipoVariable = 1;
                appVariables.UserCreate = dto.UsuarioConectado;
                appVariables.CreatedAt = DateTime.Now;
                AppVariables appVariablesInserted = await Insert(appVariables);

                resultDto = _mapper.Map<AppVariablesGetDto>(appVariablesInserted);
                metadata.IsValid = true;
                metadata.Message = $"Variable Creada Satisfactoriamente!";

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

        public async Task<ApiResponse<AppVariablesGetDto>> UpdateVariables(AppVariablesUpdateDto dto)
        {
            AppVariablesGetDto resultDto = new AppVariablesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppVariablesGetDto> response = new ApiResponse<AppVariablesGetDto>(resultDto);

            try
            {

                AppVariables variable = await GetById(dto.Id);

                if (variable == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Variable No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }
                if (variable.Code != dto.Code)
                {
                    AppRecipes recipes = await _unitOfWork.AppRecipesRepository.GetRecipesByVariableCode(variable.Code);

                    if (recipes != null)
                    {
                        metadata.IsValid = false;

                        metadata.Message = "Variable existe en la formulacion!!!";

                        response.Meta = metadata;
                        response.Data = resultDto;

                        return response;
                    }
                }




                variable.Description = dto.Description;
                variable.Code = dto.Code;
                variable.TipoVariable = 1;
                variable.UserUpdate=
                variable.UserUpdate = dto.UsuarioConectado;
                variable.UpdatedAt = DateTime.Now;

                AppVariables appVariablesUpdated = await Update(variable);

                resultDto = _mapper.Map<AppVariablesGetDto>(appVariablesUpdated);
                metadata.IsValid = true;
                metadata.Message = $"Variable Actualizada Satisfactoriamente!";

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

        public async Task<AppVariables> Update(AppVariables appVariables)
        {

            AppVariables variables = await GetById(appVariables.Id);
            if (variables == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppVariablesRepository.Update(variables);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appVariables.Id);

        }

        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.AppVariablesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResponse<bool>> DeleteVariables(AppVariablesDeleteDto dto)
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

                AppVariables variable = await GetById(dto.Id);

                if (variable == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Variable No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

                AppRecipes recipes = await _unitOfWork.AppRecipesRepository.GetRecipesByVariableCode(variable.Code);

                if (recipes != null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Variable existe en la formulacion!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }





                
                resultDto = await Delete(dto.Id);

                metadata.IsValid = true;
                metadata.Message = $"Variable Eliminada Satisfactoriamente!";

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

    }
}
