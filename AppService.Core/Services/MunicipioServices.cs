using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
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
    public class MunicipioServices: IMunicipioServices
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;
        public MunicipioServices(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options,
                                IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;
        }

        public async Task<ApiResponse<List<MunicipioGetDto>>> GetAllFilter(MunicipioQueryFilter filter)
        {
            List<MunicipioGetDto> resultDto = new List<MunicipioGetDto>();


           
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
            ApiResponse<List<MunicipioGetDto>> response = new ApiResponse<List<MunicipioGetDto>>(resultDto);
            try
            {
                var municipios = await _unitOfWork.Winy243Repository.GetAllFilter(filter);
                List<MunicipioGetDto> municipiosDto = _mapper.Map<List<MunicipioGetDto>>(municipios);
                response.Data = municipiosDto;
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



    }
}
