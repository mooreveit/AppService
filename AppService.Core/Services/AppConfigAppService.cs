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
    public class AppConfigAppService : IAppConfigAppService
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppConfigAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<AppConfigApp>> GetAll()
        {

            List<AppConfigApp> appConfigApp = await _unitOfWork.AppConfigAppRepository.GetAll();

            return appConfigApp;
        }


        public async Task<ApiResponse<List<AppConfigAppGetDto>>> GetAllFilter(AppConfigAppQueryFilter filter)
        {
            List<AppConfigAppGetDto> resultDto = new List<AppConfigAppGetDto>();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppConfigAppGetDto>> response = new ApiResponse<List<AppConfigAppGetDto>>(resultDto);

            List<AppConfigApp> appConfigApp = await _unitOfWork.AppConfigAppRepository.GetAllFilter(filter);

            List<AppConfigAppGetDto> appConfigAppGetDto = _mapper.Map<List<AppConfigAppGetDto>>(appConfigApp);

            response.Data = appConfigAppGetDto;
            metadata.IsValid = true;
            metadata.Message = "";
            response.Meta = metadata;
            return response;


        }


        public async Task<AppConfigApp> GetById(int id)
        {

            var appConfig = await _unitOfWork.AppConfigAppRepository.GetById(id);

            // AppConfigAppGetDto appConfigDto = _mapper.Map<AppConfigAppGetDto>(appConfig);

            return appConfig;
        }
        public async Task<AppConfigAppGetDto> GetByKey(string key)
        {

            var appConfig = await _unitOfWork.AppConfigAppRepository.GetByKey(key);

            AppConfigAppGetDto appConfigDto = _mapper.Map<AppConfigAppGetDto>(appConfig);

            return appConfigDto;
        }

        public async Task<ParametrosMaquina> getParametrosMaquina()
        {
            ParametrosMaquina parametrosMaquina = new ParametrosMaquina();
            var adicional = await GetByKey("ADICIONALPRODUCCION");
            parametrosMaquina.AdicionalProduccion = Convert.ToDecimal(adicional.Valor);

            var adicionalOpuesta = await GetByKey("ADICIONALPRODUCCIONOPUESTA");
            parametrosMaquina.AdicionalProduccionOpuesta = Convert.ToDecimal(adicionalOpuesta.Valor);

            var basicaRollo = await GetByKey("MEDIDABASICAROLLO");
            parametrosMaquina.MedidaBasicaRollo = Convert.ToDecimal(basicaRollo.Valor);

            var opuestaRollo = await GetByKey("MEDIDAOPUESTAROLLO");
            parametrosMaquina.MedidaOpuestaRollo = Convert.ToDecimal(opuestaRollo.Valor);

            return parametrosMaquina;

        }




        public async Task<AppConfigApp> Insert(AppConfigApp appConfigApp)
        {


            await _unitOfWork.AppConfigAppRepository.Add(appConfigApp);
            await _unitOfWork.SaveChangesAsync();
            return appConfigApp;


        }

        public async Task<ApiResponse<AppConfigAppGetDto>> CreateAppConfig(AppConfigAppCreateDto dto)
        {

            AppConfigAppGetDto resultDto = new AppConfigAppGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppConfigAppGetDto> response = new ApiResponse<AppConfigAppGetDto>(resultDto);


            try
            {
                AppConfigApp appConfig = _mapper.Map<AppConfigApp>(dto);

                if (dto.Clave == null || dto.Clave == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Clave Invalida";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                if (dto.Valor == null || dto.Valor == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Valor Invalido";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }



                var inserted = await Insert(appConfig);

                resultDto = _mapper.Map<AppConfigAppGetDto>(inserted);


                metadata.Message = "Configuracion Creada Satisfactoriamente";

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




        public async Task<AppConfigApp> Update(AppConfigApp appConfigApp)
        {

            var AppConfigAppFind = await GetById(appConfigApp.Id);
            if (AppConfigAppFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppConfigAppRepository.Update(appConfigApp);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appConfigApp.Id);


        }

        public async Task<ApiResponse<AppConfigAppGetDto>> UpdateAppConfig(AppConfigAppUpdateDto dto)
        {

            AppConfigAppGetDto resultDto = new AppConfigAppGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppConfigAppGetDto> response = new ApiResponse<AppConfigAppGetDto>(resultDto);


            try
            {

                var appConfig = await GetById(dto.Id);
                if (appConfig == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Id Configuracion No existe";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }



                if (dto.Clave == null || dto.Clave == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Clave Invalida";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                if (dto.Valor == null || dto.Valor == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Valor Invalido";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }






                appConfig.Clave = dto.Clave;
                appConfig.Valor = dto.Valor;


                var updated = await Update(appConfig);

                resultDto = _mapper.Map<AppConfigAppGetDto>(updated);

                metadata.Message = "Configuracion actualizada Satisfactoriamente";
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
            await _unitOfWork.AppConfigAppRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResponse<bool>> DeleteAppConfig(AppConfigAppDeleteDto dto)
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

                AppConfigApp appConfigApp = await GetById(dto.Id);

                if (appConfigApp == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Clave Valor  No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }



                resultDto = await Delete(dto.Id);

                metadata.IsValid = true;
                metadata.Message = $"Eliminado Satisfactoriamente!";

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
