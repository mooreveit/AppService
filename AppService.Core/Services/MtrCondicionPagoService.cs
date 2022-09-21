using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrCondicionPagoService:IMtrCondicionPagoService
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MtrCondicionPagoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CondicionPagoDto>> GetAll()
        {

            var listCondicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetAll();
            if (listCondicionPago != null)
            {
                List<CondicionPagoDto> listCondicionPagoDto = _mapper.Map<List<CondicionPagoDto>>(listCondicionPago);
                return listCondicionPagoDto;
            }
            else
            {
                return null;
            }


        }

        public async Task<CondicionPagoDto> GetById(short idCondicionPago)
        {
            var condicion = await _unitOfWork.MtrCondicionPagoRepository.GetById(idCondicionPago);
            CondicionPagoDto condicionDto = _mapper.Map<CondicionPagoDto>(condicion);

            return condicionDto;
        }

    }
}
