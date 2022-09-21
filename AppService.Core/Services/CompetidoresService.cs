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
    public class CompetidoresService: ICompetidoresService
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;


        public CompetidoresService(IUnitOfWork unitOfWork,
                                     IOptions<PaginationOptions> options,
                                     IMapper mapper

                                     )
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;

        }


        public async Task<ApiResponse<List<CompetidoresGetDto>>> GetByAllFilter(CompetidoresQueryFilter filter)
        {
            List<CompetidoresGetDto> resultDto = new List<CompetidoresGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };


            ApiResponse<List<CompetidoresGetDto>> response = new ApiResponse<List<CompetidoresGetDto>>(resultDto);

            var motivos = await _unitOfWork.CompetidoresRepository.GetAllByFilter(filter);


            resultDto = _mapper.Map<List<CompetidoresGetDto>>(motivos);

            response.Data = resultDto;
            response.Meta = metadata;
            return response;


        }



    }
}
