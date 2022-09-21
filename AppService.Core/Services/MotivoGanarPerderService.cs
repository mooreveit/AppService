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
    public class MotivoGanarPerderService: IMotivoGanarPerderService
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;
      

        public MotivoGanarPerderService(IUnitOfWork unitOfWork,
                                     IOptions<PaginationOptions> options,
                                     IMapper mapper
                                     
                                     )
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;
           
        }


        public async Task<ApiResponse<List<MotivoGanarPerderGetDto>>> GetByCondicion(MotivoGanarPerderQueryFilter filter)
        {
            List<MotivoGanarPerderGetDto> resultDto = new List<MotivoGanarPerderGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };


            ApiResponse<List<MotivoGanarPerderGetDto>> response = new ApiResponse<List<MotivoGanarPerderGetDto>>(resultDto);

            var motivos = await _unitOfWork.MotivoGanarPerderRepository.GetAllByCondicion(filter.Condicion);


            resultDto = _mapper.Map<List<MotivoGanarPerderGetDto>>(motivos);

            response.Data = resultDto;
            response.Meta = metadata;
            return response;

           
        }



    }
}
