
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.Map;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppProductConversionService : IAppProductConversionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly PaginationOptions _paginationOptions;

        public AppProductConversionService(
          IUnitOfWork unitOfWork,
          IMapper mapper,
          IOptions<PaginationOptions> options)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._paginationOptions = options.Value;
        }

        public ApiResponse<List<AppProductConversionGetDto>> GetAllByProduct(
          AppProductConversionFilter filters)
        {
            List<AppProductConversionGetDto> data = new List<AppProductConversionGetDto>();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<List<AppProductConversionGetDto>> allByProduct = new ApiResponse<List<AppProductConversionGetDto>>(data);
            int? appProductsId = filters.AppProductsId;
            int num = 0;
            IQueryable<AppProductConversionGetDto> source;
            if (appProductsId.GetValueOrDefault() > num & appProductsId.HasValue)
                source = this._unitOfWork.AppProductConversionRepository.GetAll().Where<AppProductConversion>((Expression<Func<AppProductConversion, bool>>)(x => x.AppProductsId == filters.AppProductsId)).Select<AppProductConversion, AppProductConversionGetDto>((Expression<Func<AppProductConversion, AppProductConversionGetDto>>)(p => MapAppProductConversion.MapAppProductConversionToAppProductConversionGetDto(p)));
            else
                source = this._unitOfWork.AppProductConversionRepository.GetAll().Select<AppProductConversion, AppProductConversionGetDto>((Expression<Func<AppProductConversion, AppProductConversionGetDto>>)(p => MapAppProductConversion.MapAppProductConversionToAppProductConversionGetDto(p)));
            allByProduct.Data = source.ToList<AppProductConversionGetDto>();
            allByProduct.Meta = metadata;
            return allByProduct;
        }

        public async Task<AppProductConversion> GetById(int id) => await this._unitOfWork.AppProductConversionRepository.GetById(id);

        public async Task<AppProductConversion> Insert(
          AppProductConversion appUnits)
        {
            try
            {
                await this._unitOfWork.AppProductConversionRepository.Add(appUnits);
                await this._unitOfWork.SaveChangesAsync();
                return appUnits;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return (AppProductConversion)null;
            }
        }

        public async Task<ApiResponse<AppProductConversionGetDto>> InsertConversion(
          AppProductConversionCreateDto dto)
        {
            AppProductConversionGetDto resultDto = new AppProductConversionGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppProductConversionGetDto> response = new ApiResponse<AppProductConversionGetDto>(resultDto);
            try
            {
                Decimal? xnumerador = dto.XNumerador;
                Decimal num1 = 0M;
                if (xnumerador.GetValueOrDefault() <= num1 & xnumerador.HasValue)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Numerador Invalido";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                Decimal? ydenominador = dto.YDenominador;
                Decimal num2 = 0M;
                if (ydenominador.GetValueOrDefault() <= num2 & ydenominador.HasValue)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Denominador Invalido";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppProducts appProductsFind = await this._unitOfWork.AppProductsRepository.GetById(dto.AppProductsId.Value);
                if (appProductsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de producto no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppUnits byId = await this._unitOfWork.AppUnitsRepository.GetById(dto.AppUnitsIdBase.Value);
                if (appProductsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de unidad base no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.AppUnitsRepository.GetById(dto.AppUnitsIdAlternativa.Value) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de unidad alternativa no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppProductConversion origen = await this.Insert(MapAppProductConversion.MapAppProductConversionCreateDtoToAppProductConversion(dto));
                if (origen != null)
                {
                    resultDto = MapAppProductConversion.MapAppProductConversionToAppProductConversionGetDto(origen);
                    metadata.IsValid = true;
                    metadata.Message = "Conversion creada Satisfactoriamente!!";
                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Registro No actualizado";
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
                response.Data = resultDto;
                return response;
            }
        }

        public async Task<AppProductConversion> Update(
          AppProductConversion appUnits)
        {
            if (await this.GetById(appUnits.Id) == null)
                throw new Exception("Documento No existe");
            this._unitOfWork.AppProductConversionRepository.Update(appUnits);
            await this._unitOfWork.SaveChangesAsync();
            return await this.GetById(appUnits.Id);
        }

        public async Task<ApiResponse<AppProductConversionGetDto>> UpdateConversion(
          AppProductConversionUpdateDto dto)
        {
            AppProductConversionGetDto resultDto = new AppProductConversionGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppProductConversionGetDto> response = new ApiResponse<AppProductConversionGetDto>(resultDto);
            try
            {
                AppProductConversion conversion = await this.GetById(dto.Id);
                if (conversion == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "No existe registro de conversion para actualizaar";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                Decimal? xnumerador = dto.XNumerador;
                Decimal num1 = 0M;
                if (xnumerador.GetValueOrDefault() <= num1 & xnumerador.HasValue)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Numerador Invalido";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                Decimal? ydenominador = dto.YDenominador;
                Decimal num2 = 0M;
                if (ydenominador.GetValueOrDefault() <= num2 & ydenominador.HasValue)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Denominador Invalido";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppProducts appProductsFind = await this._unitOfWork.AppProductsRepository.GetById(dto.AppProductsId.Value);
                if (appProductsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de producto no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppUnits byId = await this._unitOfWork.AppUnitsRepository.GetById(dto.AppUnitsIdBase.Value);
                if (appProductsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de unidad base no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.AppUnitsRepository.GetById(dto.AppUnitsIdAlternativa.Value) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de unidad alternativa no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                conversion.AppProductsId = dto.AppProductsId;
                conversion.AppUnitsIdAlternativa = dto.AppUnitsIdAlternativa;
                conversion.AppUnitsIdBase = dto.AppUnitsIdBase;
                conversion.XNumerador = dto.XNumerador;
                conversion.YDenominador = dto.YDenominador;
                AppProductConversion origen = await this.Update(conversion);
                if (origen != null)
                {
                    resultDto = MapAppProductConversion.MapAppProductConversionToAppProductConversionGetDto(origen);
                    metadata.IsValid = true;
                    metadata.Message = "Precio actualizado Satisfactoriamente!!";
                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Registro No actualizado";
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
                response.Data = resultDto;
                return response;
            }
        }

        public async Task<bool> Delete(int id)
        {
            await this._unitOfWork.AppProductConversionRepository.Delete(id);
            await this._unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResponse<AppProductConversionGetDto>> DeletePrice(
          int id)
        {
            AppProductConversionGetDto resultDto = new AppProductConversionGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppProductConversionGetDto> response = new ApiResponse<AppProductConversionGetDto>(resultDto);
            try
            {
                if (await this.GetById(id) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "No existe registro de conversion para borrar";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                int num = await this.Delete(id) ? 1 : 0;
                metadata.IsValid = true;
                metadata.Message = "Precio Borrado Satisfactoriamente!!";
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

        public async Task<bool> CopyConversion(AppCopyRecipesDto dto)
        {
            bool result = false;

            var conversion = await _unitOfWork.AppProductConversionRepository.GetAllByProduct(dto.productIdSince);
            if (conversion != null)
            {
                var conversionUntil = await _unitOfWork.AppProductConversionRepository.GetAllByProduct(dto.productIdUntil);
                if (conversionUntil.Count == 0)
                {
                    foreach (var item in conversion)
                    {
                        AppProductConversion appProductConversionNew = new AppProductConversion();
                        appProductConversionNew.AppProductsId = dto.productIdUntil;
                        appProductConversionNew.AppUnitsIdBase = item.AppUnitsIdBase;
                        appProductConversionNew.AppUnitsIdAlternativa = item.AppUnitsIdAlternativa;
                        appProductConversionNew.XNumerador = item.XNumerador;
                        appProductConversionNew.YDenominador = item.YDenominador;
                        await Insert(appProductConversionNew);
                    }
                }
            }

            return result;

        }





    }
}
