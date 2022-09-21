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
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppTemplateConversionUnitService : IAppTemplateConversionUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        private readonly IHelperService _helperService;
        private readonly IAppUnitsService _appUnitsService;
        private readonly IAppVariablesService _appVariablesService;
        private readonly IAppDetailQuotesConversionUnitService _appDetailQuotesConversionUnitService;
        private readonly PaginationOptions _paginationOptions;

        public AppTemplateConversionUnitService(IUnitOfWork unitOfWork,
                                                IMapper mapper,
                                                IOptions<PaginationOptions> options,
                                                IHelperService helperService,
                                                IAppUnitsService appUnitsService,
                                                IAppVariablesService appVariablesService,
                                                IAppDetailQuotesConversionUnitService appDetailQuotesConversionUnitService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
           
            _helperService = helperService;
            _appUnitsService = appUnitsService;
            _appVariablesService = appVariablesService;
            _appDetailQuotesConversionUnitService = appDetailQuotesConversionUnitService;
            _paginationOptions = options.Value;
        }

        public async Task<List<AppTemplateConversionUnit>> GetTemplateByUnits(int appUnitIdSince, int appUnitIdUntil)
        {

            return  await _unitOfWork.AppTemplateConversionUnitRepository.GetTemplateByUnits(appUnitIdSince, appUnitIdUntil);
            

        }
        public async Task<ApiResponse<List<AppTemplateConversionUnitGetDto>>> GetTemplateByUnitsInput(AppTemplateConversionUnitQueryFilter filter)
        {


            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            List<AppTemplateConversionUnitGetDto> resultDto = new List<AppTemplateConversionUnitGetDto>();
            ApiResponse<List<AppTemplateConversionUnitGetDto>> response = new ApiResponse<List<AppTemplateConversionUnitGetDto>>(resultDto);
            try
            {

                var detailConversion = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(filter.AppDetailQuotesId);
                if (detailConversion.Count==0 )
                {
                    var template = await _unitOfWork.AppTemplateConversionUnitRepository.GetTemplateByUnitsInput(filter.AppUnitIdSince, filter.AppUnitIdUntil);
                    if (template!= null)
                    {
                        template = template.OrderBy(x => x.OrderCalculate).ToList();

                        resultDto = _mapper.Map<List<AppTemplateConversionUnitGetDto>>(template);
                       
                        response.Meta = metadata;
                        response.Data = resultDto;
                    }
                    else
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Estas Unidades no tienen conversion configurada";
                        response.Meta = metadata;
                        response.Data = resultDto;

                    }
                    
                    
                    
                    return response;

                }
                else
                {
                    var template = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetDetailQuotesConversionInputById(filter.AppDetailQuotesId);



                    if (template != null)
                    {

                        template = template.OrderBy(x => x.OrderCalculate).ToList();
                        resultDto = _mapper.Map<List<AppTemplateConversionUnitGetDto>>(template);

                        response.Meta = metadata;
                        response.Data = resultDto;
                    }
                    else
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Estas Unidades no tienen conversion configurada";
                        response.Meta = metadata;
                        response.Data = resultDto;

                    }
                    return response;
                }
               
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = null;
                return response;
            }

            


        }


        public async Task<ApiResponse<List<AppTemplateConversionUnitGenericGetDto>>> GetAllTemplateByUnitsInput(AppTemplateConversionUnitQueryFilter filter)
        {


            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            List<AppTemplateConversionUnitGenericGetDto> resultDto = new List<AppTemplateConversionUnitGenericGetDto>();
            ApiResponse<List<AppTemplateConversionUnitGenericGetDto>> response = new ApiResponse<List<AppTemplateConversionUnitGenericGetDto>>(resultDto);
            try
            {


                var template = await _unitOfWork.AppTemplateConversionUnitRepository.GetAllTemplateByUnitsInput(filter.AppUnitIdSince, filter.AppUnitIdUntil);

                template = template.OrderBy(x => x.OrderCalculate).ToList();
                resultDto = _mapper.Map<List<AppTemplateConversionUnitGenericGetDto>>(template);
               


                foreach (var item in resultDto)
                {

                    AppUnits AppUnitsFind = await _appUnitsService.GetById(item.AppUnitIdSince);
                    if (AppUnitsFind != null)
                    {
                        AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                        item.AppUnitIdSinceGetDto = appUnitsGetDto;
                    }
                    AppUnitsFind = await _appUnitsService.GetById(item.AppUnitIdUntil);
                    if (AppUnitsFind != null)
                    {
                        AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                        item.AppUnitIdUntilGetDto = appUnitsGetDto;
                    }


                    AppVariables AppVariablesFind = await _appVariablesService.GetById(item.AppVariableId);
                    if (AppVariablesFind != null)
                    {
                        AppVariablesGetDto appVariablesGetDto = _mapper.Map<AppVariablesGetDto>(AppVariablesFind);
                        item.AppVariablesGetDto = appVariablesGetDto;
                    }
                    


                }





                response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                

            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = null;
                return response;
            }




        }


        public async Task<AppTemplateConversionUnit> GetById(int id)
        {
            return await _unitOfWork.AppTemplateConversionUnitRepository.GetById(id);
        }

        public async Task<AppTemplateConversionUnit> Insert(AppTemplateConversionUnit appTemplateConversionUnit )
        {


            await _unitOfWork.AppTemplateConversionUnitRepository.Add(appTemplateConversionUnit);
            await _unitOfWork.SaveChangesAsync();
            return appTemplateConversionUnit;


        }


        public async Task<AppTemplateConversionUnit> Update(AppTemplateConversionUnit appTemplateConversionUnit )
        {

            var appTemplateConversionUnitFind = await GetById(appTemplateConversionUnit.Id);
            if (appTemplateConversionUnitFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppTemplateConversionUnitRepository.Update(appTemplateConversionUnit);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appTemplateConversionUnit.Id);


        }



        public async Task<ApiResponse<AppTemplateConversionUnitGenericGetDto>> UpdateAppTemplateConversionUnit(AppTemplateConversionUnitUpdateDto dto)
        {

            AppTemplateConversionUnitGenericGetDto resultDto = new AppTemplateConversionUnitGenericGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppTemplateConversionUnitGenericGetDto> response = new ApiResponse<AppTemplateConversionUnitGenericGetDto>(resultDto);


            try
            {

                var template = await GetById(dto.Id);
                if (template == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Id Template No existe";
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

                AppVariables AppVariablesFind = await _appVariablesService.GetById(dto.AppVariableId);
                if (AppVariablesFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Variable no existe";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;

                   
                }


                AppUnits appUnitIdSinceFind = await _appUnitsService.GetById(dto.AppUnitIdSince);
                if (appUnitIdSinceFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Unidad de Medida desde no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                AppUnits appUnitIdUntilFind = await _appUnitsService.GetById(dto.AppUnitIdUntil);
                if (appUnitIdUntilFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Unidad de Medida hasta no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }


                template.AppVariableId = dto.AppVariableId;


                template.Code = AppVariablesFind.Code;
                template.Description = dto.Description;
                template.Formula = dto.Formula;
                template.SumValue = dto.SumValue;
                template.Value = dto.Value;
                template.OrderCalculate = dto.OrderCalculate;
                template.AppUnitIdSince = dto.AppUnitIdSince;
                template.AppUnitIdUntil = dto.AppUnitIdUntil;
                template.Min = dto.Min;
                template.Max = dto.Max;


                 var updated = await Update(template);

                resultDto = _mapper.Map<AppTemplateConversionUnitGenericGetDto>(updated);

                if (appUnitIdSinceFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(appUnitIdSinceFind);
                    resultDto.AppUnitIdSinceGetDto = appUnitsGetDto;
                }

                if (appUnitIdUntilFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(appUnitIdUntilFind);
                    resultDto.AppUnitIdUntilGetDto = appUnitsGetDto;
                }
                if (AppVariablesFind != null)
                {
                    AppVariablesGetDto appVariablesGetDto = _mapper.Map<AppVariablesGetDto>(AppVariablesFind);
                    resultDto.AppVariablesGetDto = appVariablesGetDto;

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

        public async Task<ApiResponse<AppTemplateConversionUnitGenericGetDto>> CreateAppTemplateConversionUnit(AppTemplateConversionUnitCreateDto dto)
        {

            AppTemplateConversionUnitGenericGetDto resultDto = new AppTemplateConversionUnitGenericGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppTemplateConversionUnitGenericGetDto> response = new ApiResponse<AppTemplateConversionUnitGenericGetDto>(resultDto);


            try
            {

               



               

                AppVariables AppVariablesFind = await _appVariablesService.GetById(dto.AppVariableId);
                if (AppVariablesFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Variable no existe";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;


                }


                AppUnits appUnitIdSinceFind = await _appUnitsService.GetById(dto.AppUnitIdSince);
                if (appUnitIdSinceFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Unidad de Medida desde no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                AppUnits appUnitIdUntilFind = await _appUnitsService.GetById(dto.AppUnitIdUntil);
                if (appUnitIdUntilFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Unidad de Medida hasta no existe!!";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }


                AppTemplateConversionUnit template = new AppTemplateConversionUnit();

                template.AppVariableId = dto.AppVariableId;


                template.Code = AppVariablesFind.Code;
                template.Description = dto.Description;
                template.Formula = dto.Formula;
                template.Value = dto.Value;
                template.SumValue = dto.SumValue;
                template.OrderCalculate = dto.OrderCalculate;
                template.AppUnitIdSince = dto.AppUnitIdSince;
                template.AppUnitIdUntil = dto.AppUnitIdUntil;
                template.Min = dto.Min;
                template.Max = dto.Max;


                var inserted = await Insert(template);

                resultDto = _mapper.Map<AppTemplateConversionUnitGenericGetDto>(inserted);

                if (appUnitIdSinceFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(appUnitIdSinceFind);
                    resultDto.AppUnitIdSinceGetDto = appUnitsGetDto;
                }

                if (appUnitIdUntilFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(appUnitIdUntilFind);
                    resultDto.AppUnitIdUntilGetDto = appUnitsGetDto;
                }
                if (AppVariablesFind != null)
                {
                    AppVariablesGetDto appVariablesGetDto = _mapper.Map<AppVariablesGetDto>(AppVariablesFind);
                    resultDto.AppVariablesGetDto = appVariablesGetDto;

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
            await _unitOfWork.AppTemplateConversionUnitRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResponse<bool>> DeleteAppTemplateConversionUnit(AppTemplateConversionUnitDeleteDto dto)
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

                AppTemplateConversionUnit appTemplateConversionUnit = await GetById(dto.Id);

                if (appTemplateConversionUnit == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Template No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

             

                resultDto = await Delete(dto.Id);

                metadata.IsValid = true;
                metadata.Message = $"Template Eliminado Satisfactoriamente!";

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
