using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppPriceServices : IAppPriceServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppRecipesByAppDetailQuotesService _appRecipesByAppDetailQuotesService;

        public AppPriceServices(
          IUnitOfWork unitOfWork,
          IMapper mapper,
          IAppRecipesByAppDetailQuotesService appRecipesByAppDetailQuotesService)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._appRecipesByAppDetailQuotesService = appRecipesByAppDetailQuotesService;
        }

        public async Task<AppPrice> Add(AppPrice entity)
        {
            await this._unitOfWork.AppPriceRepository.Add(entity);
            await this._unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            await this._unitOfWork.AppPriceRepository.Delete(id);
            await this._unitOfWork.SaveChangesAsync();
        }

        public async Task<ApiResponse<List<AppPriceGetDto>>> GetAllByAppProduct(
          int appProductId)
        {
            List<AppPriceGetDto> resultDto = new List<AppPriceGetDto>();
            List<AppPrice> allByAppProduct1 = await this._unitOfWork.AppPriceRepository.GetAllByAppProduct(appProductId);
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<List<AppPriceGetDto>> response = new ApiResponse<List<AppPriceGetDto>>(resultDto);
            List<AppPriceGetDto> appPriceDto = this._mapper.Map<List<AppPriceGetDto>>((object)allByAppProduct1);
            foreach (AppPriceGetDto item in appPriceDto)
            {
                AppProducts byId = await this._unitOfWork.AppProductsRepository.GetById(item.AppproductsId);
                item.AppProduct = this._mapper.Map<AppProductsGetDto>((object)byId);
            }
            response.Meta = metadata;
            response.Data = appPriceDto;
            ApiResponse<List<AppPriceGetDto>> allByAppProduct2 = response;
            resultDto = (List<AppPriceGetDto>)null;
            metadata = (Metadata)null;
            response = (ApiResponse<List<AppPriceGetDto>>)null;
            appPriceDto = (List<AppPriceGetDto>)null;
            return allByAppProduct2;
        }

        public async Task<AppPrice> GetById(int id) => await this._unitOfWork.AppPriceRepository.GetById(id);

        public async Task<AppPrice> Update(AppPrice entity)
        {
            try
            {
                if (await this.GetById(entity.Id) == null)
                    throw new Exception("Producto No existe");
                this._unitOfWork.AppPriceRepository.Update(entity);
                await this._unitOfWork.SaveChangesAsync();
                return await this.GetById(entity.Id);
            }
            catch (Exception ex)
            {
                string message = ex.InnerException.Message;
                return (AppPrice)null;
            }
        }

        public async Task<ApiResponse<AppPriceGetDto>> InsertPrice(
          AppPriceCreateDto appPriceCreateDto)
        {
            AppPriceGetDto resultDto = new AppPriceGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(resultDto);
            try
            {
                if (appPriceCreateDto.Desde <= 0M)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cantidad desde Invalida";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (appPriceCreateDto.Hasta < appPriceCreateDto.Desde)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cantidad hasta Invalida";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.AppPriceRepository.GetByProductoDesdeHastaId(appPriceCreateDto.AppproductsId, appPriceCreateDto.Desde, appPriceCreateDto.Hasta) != null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Ya existe este rango de precio, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppProducts byId = await this._unitOfWork.AppProductsRepository.GetById(appPriceCreateDto.AppproductsId);
                if (byId == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de producto no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppProductsGetDto productDto = this._mapper.Map<AppProductsGetDto>((object)byId);
                AppPrice source = await this.Add(this._mapper.Map<AppPrice>((object)appPriceCreateDto));
                if (source != null)
                {
                    resultDto = this._mapper.Map<AppPriceGetDto>((object)source);
                    resultDto.AppProduct = productDto;
                    metadata.IsValid = true;
                    metadata.Message = "Precio creado Satisfactoriamente!!";
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

        public async Task<ApiResponse<AppPriceGetDto>> GetAppPriceDtoById(
          int id)
        {
            AppPriceGetDto data = new AppPriceGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(data);
            AppPrice appPrice = await this.GetById(id);
            AppProductsGetDto appProductsGetDto = this._mapper.Map<AppProductsGetDto>((object)await this._unitOfWork.AppProductsRepository.GetById(appPrice.AppproductsId));
            AppPriceGetDto appPriceGetDto = this._mapper.Map<AppPriceGetDto>((object)appPrice);
            appPriceGetDto.AppProduct = appProductsGetDto;
            response.Meta = metadata;
            response.Data = appPriceGetDto;
            ApiResponse<AppPriceGetDto> appPriceDtoById = response;
            metadata = (Metadata)null;
            response = (ApiResponse<AppPriceGetDto>)null;
            appPrice = (AppPrice)null;
            return appPriceDtoById;
        }

        public async Task<ApiResponse<AppPriceGetDto>> GetPrice(
          int apprpoductId,
          Decimal cantidad)
        {
            AppPriceGetDto resultDto = new AppPriceGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(resultDto);
            if (await this._unitOfWork.AppProductsRepository.GetById(apprpoductId) == null)
            {
                metadata.IsValid = false;
                metadata.Message = "Codigo de producto no existe, verifique por favor";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            if (cantidad <= 0M)
            {
                metadata.IsValid = false;
                metadata.Message = "Cantidad debe ser mayor a cero, verifique por favor";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            if (await this._unitOfWork.AppPriceRepository.ProductExist(apprpoductId))
                response = await this.GetByProductoCantidad(apprpoductId, cantidad);
            else
                response = await this.GetByProductoCantidadCalculado(apprpoductId, cantidad);
            return response;
        }

        public async Task<ApiResponse<AppPriceGetDto>> GetByProductoCantidadCalculado(
          int apprpoductId,
          Decimal cantidad)
        {
            AppPriceGetDto resultDto = new AppPriceGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(resultDto);
            AppProducts byId = await this._unitOfWork.AppProductsRepository.GetById(apprpoductId);
            if (byId == null)
            {
                metadata.IsValid = false;
                metadata.Message = "Codigo de producto no existe, verifique por favor";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            if (cantidad <= 0M)
            {
                metadata.IsValid = false;
                metadata.Message = "Cantidad debe ser mayor a cero, verifique por favor";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            AppProductsGetDto productDto = this._mapper.Map<AppProductsGetDto>((object)byId);
            AppPriceGetDto productoCantidad = await this._appRecipesByAppDetailQuotesService.GetPrecioProductoCantidad(apprpoductId, cantidad);
            if (productoCantidad != null)
            {
                productoCantidad.AppProduct = productDto;
                response.Meta = metadata;
                response.Data = productoCantidad;
            }
            return response;
        }

        public async Task<ApiResponse<AppPriceGetDto>> GetByProductoCantidad(
          int apprpoductId,
          Decimal cantidad)
        {
            AppPriceGetDto resultDto = new AppPriceGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(resultDto);
            AppProducts byId = await this._unitOfWork.AppProductsRepository.GetById(apprpoductId);
            if (byId == null)
            {
                metadata.IsValid = false;
                metadata.Message = "Codigo de producto no existe, verifique por favor";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            if (cantidad <= 0M)
            {
                metadata.IsValid = false;
                metadata.Message = "CAntidad debe ser mayor a cero, verifique por favor";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            AppProductsGetDto productDto = this._mapper.Map<AppProductsGetDto>((object)byId);
            AppPrice productoCantidad = await this._unitOfWork.AppPriceRepository.GetByProductoCantidad(apprpoductId, cantidad);
            if (productoCantidad != null)
            {
                AppPriceGetDto appPriceGetDto = this._mapper.Map<AppPriceGetDto>((object)productoCantidad);
                appPriceGetDto.AppProduct = productDto;
                response.Meta = metadata;
                response.Data = appPriceGetDto;
            }
            else if (await this._unitOfWork.AppPriceRepository.ProductExist(apprpoductId))
            {
                AppPrice firstPriceByProduct = await this._unitOfWork.AppPriceRepository.GetFirstPriceByProduct(apprpoductId);
                if (firstPriceByProduct != null)
                {
                    AppPriceGetDto appPriceGetDto = this._mapper.Map<AppPriceGetDto>((object)firstPriceByProduct);
                    appPriceGetDto.AppProduct = productDto;
                    response.Meta = metadata;
                    response.Data = appPriceGetDto;
                }
            }
            return response;
        }

        public async Task<ApiResponse<AppPriceGetDto>> UpdatePrice(
          AppPriceUpdateDto appPriceUpdateDto)
        {
            AppPriceGetDto resultDto = new AppPriceGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(resultDto);
            try
            {
                AppPrice appPrice = await this.GetById(appPriceUpdateDto.Id);
                if (appPrice == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "No existe registro deprecio para actualizaar";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (appPriceUpdateDto.Desde <= 0M)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cantidad desde Invalida";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (appPriceUpdateDto.Hasta < appPriceUpdateDto.Desde)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cantidad hasta Invalida";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                AppProducts appProductsFind = await this._unitOfWork.AppProductsRepository.GetById(appPriceUpdateDto.AppproductsId);
                if (appProductsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo de producto no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                appPrice.Desde = appPriceUpdateDto.Desde;
                appPrice.Hasta = appPriceUpdateDto.Hasta;
                appPrice.Precio = appPriceUpdateDto.Precio;
                AppPrice source = await this.Update(appPrice);
                if (source != null)
                {
                    resultDto = this._mapper.Map<AppPriceGetDto>((object)source);
                    resultDto.AppProduct = this._mapper.Map<AppProductsGetDto>((object)appProductsFind);
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

        public async Task<bool> Delete(short id)
        {
            await this._unitOfWork.AppProductsRepository.Delete((int)id);
            await this._unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResponse<AppPriceGetDto>> DeletePrice(int id)
        {
            AppPriceGetDto resultDto = new AppPriceGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(resultDto);
            try
            {
                if (await this.GetById(id) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "No existe registro de precio para borrar";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                await this.Delete(id);
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
    }
}
