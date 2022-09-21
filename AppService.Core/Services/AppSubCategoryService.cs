using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppSubCategoryService: IAppSubCategoryService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AppSubCategoryService(IUnitOfWork unitOfWork,
                                    IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse<List<AppSubCategoryGetDto>>> GetAll(AppSubCategoryQueryFilter filter)
        {
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
            List<AppSubCategoryGetDto> resultDto = new List<AppSubCategoryGetDto>();
            ApiResponse<List<AppSubCategoryGetDto>> response = new ApiResponse<List<AppSubCategoryGetDto>>(resultDto);

            var appSubCategory = await _unitOfWork.AppSubCategoryRepository.GetAllFilter(filter);
            resultDto = _mapper.Map<List<AppSubCategoryGetDto>>(appSubCategory);
           
            response.Meta = metadata;
            response.Data = resultDto;
            return response;

           
        }

        public async Task<AppSubCategory> GetById(int id)
        {
            return await _unitOfWork.AppSubCategoryRepository.GetById(id);
        }

        public async Task<AppSubCategory> Insert(AppSubCategory appSubCategory)
        {


            await _unitOfWork.AppSubCategoryRepository.Add(appSubCategory);
            await _unitOfWork.SaveChangesAsync();
            return appSubCategory;


        }


        public async Task<AppSubCategory> Update(AppSubCategory appSubCategory)
        {

            var appSubCategoryFind = await GetById(appSubCategory.Id);
            if (appSubCategoryFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppSubCategoryRepository.Update(appSubCategory);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appSubCategory.Id);


        }

        public async Task<bool> Delete(short id)
        {
            await _unitOfWork.AppSubCategoryRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

    }
}
