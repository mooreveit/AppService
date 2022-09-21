using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppVariableSearchService : IAppVariableSearchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppVariableSearchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<AppVariableSearch>> GetAll() => await this._unitOfWork.AppVariableSearchRepository.GetAll();

        public async Task<ApiResponse<List<AppVariableSearchGetDto>>> GetAllBySubCategory(
          int subCategory)
        {
            List<AppVariableSearchGetDto> data = new List<AppVariableSearchGetDto>();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<List<AppVariableSearchGetDto>> response = new ApiResponse<List<AppVariableSearchGetDto>>(data);
            List<AppVariableSearchGetDto> variablesGetDto = this._mapper.Map<List<AppVariableSearchGetDto>>((object)(await this._unitOfWork.AppVariableSearchRepository.GetAllBySubCategory(subCategory)).OrderBy<AppVariableSearch, int?>((Func<AppVariableSearch, int?>)(x => x.AppVariableId)).ToList<AppVariableSearch>());
            foreach (AppVariableSearchGetDto item in variablesGetDto)
            {
                AppVariables byId = await this._unitOfWork.AppVariablesRepository.GetById(item.AppVariableId.Value);
                if (byId != null)
                    item.VariableDescription = byId.Description;
            }
            response.Data = variablesGetDto;
            metadata.IsValid = true;
            metadata.Message = "";
            response.Meta = metadata;
            ApiResponse<List<AppVariableSearchGetDto>> allBySubCategory = response;
            metadata = (Metadata)null;
            response = (ApiResponse<List<AppVariableSearchGetDto>>)null;
            variablesGetDto = (List<AppVariableSearchGetDto>)null;
            return allBySubCategory;
        }

        public async Task<ApiResponse<List<AppVariableSearchGroupByVariableGetDto>>> GetAllBySubCategoryGroupByVariable(int subCategory)
        {
            List<AppVariableSearchGroupByVariableGetDto> resultDto = new List<AppVariableSearchGroupByVariableGetDto>();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };

            ApiResponse<List<AppVariableSearchGroupByVariableGetDto>> response = new ApiResponse<List<AppVariableSearchGroupByVariableGetDto>>(resultDto);

            List<AppVariableSearch> variables = await this._unitOfWork.AppVariableSearchRepository.GetAllBySubCategory(subCategory);

            foreach (AppVariableSearch appVariableSearch in variables)
            {
                AppVariableSearch item = appVariableSearch;

                AppVariableSearchGroupByVariableGetDto itemAppVariableSearchGroupByVariableGetDto = new AppVariableSearchGroupByVariableGetDto();

                itemAppVariableSearchGroupByVariableGetDto.AppVariableId = item.AppVariableId;

                AppVariables byId = await this._unitOfWork.AppVariablesRepository.GetById(item.AppVariableId.Value);
                if (byId != null)
                    itemAppVariableSearchGroupByVariableGetDto.VariableDescription = byId.Description;

                List<AppVariableSearch> list = variables.Where<AppVariableSearch>((Func<AppVariableSearch, bool>)(x =>
                {
                    int? appVariableId1 = x.AppVariableId;
                    int? appVariableId2 = item.AppVariableId;
                    return appVariableId1.GetValueOrDefault() == appVariableId2.GetValueOrDefault() & appVariableId1.HasValue == appVariableId2.HasValue;
                })).ToList<AppVariableSearch>();

                itemAppVariableSearchGroupByVariableGetDto.AppVariableSearchGetDto = this._mapper.Map<List<AppVariableSearchGetDto>>((object)list.OrderBy<AppVariableSearch, int?>((Func<AppVariableSearch, int?>)(x => x.AppVariableId)).ToList<AppVariableSearch>());

                if (resultDto.Where<AppVariableSearchGroupByVariableGetDto>((Func<AppVariableSearchGroupByVariableGetDto, bool>)(x =>
                {
                    int? appVariableId3 = x.AppVariableId;
                    int? appVariableId4 = item.AppVariableId;
                    return appVariableId3.GetValueOrDefault() == appVariableId4.GetValueOrDefault() & appVariableId3.HasValue == appVariableId4.HasValue;
                })).FirstOrDefault<AppVariableSearchGroupByVariableGetDto>() == null)

                    resultDto.Add(itemAppVariableSearchGroupByVariableGetDto);
                itemAppVariableSearchGroupByVariableGetDto = (AppVariableSearchGroupByVariableGetDto)null;
            }

            response.Data = resultDto.OrderBy(x => x.VariableDescription).ToList();
            metadata.IsValid = true;
            metadata.Message = "";
            response.Meta = metadata;
            ApiResponse<List<AppVariableSearchGroupByVariableGetDto>> categoryGroupByVariable = response;
            resultDto = (List<AppVariableSearchGroupByVariableGetDto>)null;
            metadata = (Metadata)null;
            response = (ApiResponse<List<AppVariableSearchGroupByVariableGetDto>>)null;
            variables = (List<AppVariableSearch>)null;
            return categoryGroupByVariable;
        }

        public async Task<AppVariableSearch> GetById(int id) => await this._unitOfWork.AppVariableSearchRepository.GetById(id);

        public async Task<AppVariableSearch> Insert(
          AppVariableSearch appVariableSearch)
        {
            await this._unitOfWork.AppVariableSearchRepository.Add(appVariableSearch);
            await this._unitOfWork.SaveChangesAsync();
            return appVariableSearch;
        }

        public async Task<AppVariableSearch> Update(
          AppVariableSearch appVariableSearch)
        {
            if (await this.GetById(appVariableSearch.Id) == null)
                throw new Exception("Documento No existe");
            this._unitOfWork.AppVariableSearchRepository.Update(appVariableSearch);
            await this._unitOfWork.SaveChangesAsync();
            return await this.GetById(appVariableSearch.Id);
        }

        public async Task<bool> Delete(int id)
        {
            await this._unitOfWork.AppVariableSearchRepository.Delete(id);
            await this._unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteBySubCategory(int subCategoryId)
        {
            await this._unitOfWork.AppVariableSearchRepository.DeleteBySubCategory(subCategoryId);
            await this._unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task CreateVariableSearchTextBySubcategoryVariableSearchTex(
          int appSubCategoryId,
          int appVariableId,
          string searchText)
        {
            if (await this._unitOfWork.AppVariableSearchRepository.GetVariableSearchTextBySubcategoryVariableSearchTex(appSubCategoryId, appVariableId, searchText) != null)
                return;
            AppVariableSearch appVariableSearch = await this.Insert(new AppVariableSearch()
            {
                AppVariableId = new int?(appVariableId),
                AppSubCategoryId = new int?(appSubCategoryId),
                SearchText = searchText
            });
        }
    }
}
