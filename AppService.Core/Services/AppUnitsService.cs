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
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppUnitsService: IAppUnitsService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly PaginationOptions _paginationOptions;

        public AppUnitsService(IUnitOfWork unitOfWork, IMapper mapper, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _paginationOptions = options.Value;
        }

        public async Task<ApiResponse<List<AppUnitsGetDto>>> GetAll(AppUnitsQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            List<AppUnitsGetDto> resultDto = new List<AppUnitsGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
            ApiResponse<List<AppUnitsGetDto>> response = new ApiResponse<List<AppUnitsGetDto>>(resultDto);


            var appUnits = await _unitOfWork.AppUnitsRepository.GetAllFilter(filters);
            if (appUnits!=null)
            {
                List<AppUnitsGetDto> appUnitsDto = _mapper.Map<List<AppUnitsGetDto>>(appUnits);

                response.Data = appUnitsDto;
                response.Meta = metadata;
                return response;
            }
            else
            {
                return null;
            }

           
        }

        public async Task<ApiResponse<List<AppUnitsGetDto>>> GetAppUnitsWithConversion(AppUnitsQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            List<AppUnitsGetDto> resultDto = new List<AppUnitsGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppUnitsGetDto>> response = new ApiResponse<List<AppUnitsGetDto>>(resultDto);


            var appUnits = await _unitOfWork.AppUnitsRepository.GetAppUnitsWithConversion(filters);
            if (appUnits != null)
            {
                List<AppUnitsGetDto> appUnitsDto = _mapper.Map<List<AppUnitsGetDto>>(appUnits);

                response.Data = appUnitsDto;
                response.Meta = metadata;
                return response;
            }
            else
            {
                return null;
            }


        }

       
        public async Task<AppUnits> GetById(int id)
        {
            return await _unitOfWork.AppUnitsRepository.GetById(id);
        }

        public async Task<AppUnits> Insert(AppUnits appUnits)
        {


            await _unitOfWork.AppUnitsRepository.Add(appUnits);
            await _unitOfWork.SaveChangesAsync();
            return appUnits;


        }


        public async Task<AppUnits> Update(AppUnits appUnits)
        {

            var appUnitsFind = await GetById(appUnits.Id);
            if (appUnitsFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppUnitsRepository.Update(appUnits);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appUnits.Id);


        }

        public async Task<bool> Delete(short id)
        {
            await _unitOfWork.AppUnitsRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }



    }
}
