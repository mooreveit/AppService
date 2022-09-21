using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrClienteService: IMtrClienteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;

        public MtrClienteService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;
        }


        public async Task<IEnumerable<MtrCliente>> ListClientesPorUsuario(MtrClienteQueryFilter filter)
        {

            filter.PageNumber = filter.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filter.PageNumber;
            filter.PageSize = filter.PageSize == 0 ? _paginationOptions.DefaultPageSize : filter.PageSize;

            var clientes= await _unitOfWork.MtrClienteRepository.ListClientesPorUsuario(filter);
            

           

          

            return clientes;
            
        }
        
       
        public async Task<MtrCliente> GetByIdAsync(string id)
        {
            return await _unitOfWork.MtrClienteRepository.GetByIdAsync(id);
        }

        public  MtrCliente GetById(string id)
        {
            return  _unitOfWork.MtrClienteRepository.GetById(id);
        }


        public async Task<List<MtrDirecciones>> GetDireccionestByCodigo(string codigo)
        {
             var listDirecciones= await _unitOfWork.MtrDireccionesRepository.GetByIdCliente(codigo);


            return listDirecciones;
        }

        public async Task<List<MtrDireccionesDto>> GetDireccionestDtoByCodigo(string codigo)
        {
            var direcciones = await GetDireccionestByCodigo(codigo);

            List<MtrDireccionesDto> result = new List<MtrDireccionesDto>();

            if (direcciones!=null)
            {
                 result = _mapper.Map<List<MtrDireccionesDto>>(direcciones);
            }
            
            
            return result;

        }



        public async Task<MtrDireccionesDto> GetDireccionestDtoById(decimal id)
        {
            var direccion = await _unitOfWork.MtrDireccionesRepository.GetById(id);

            MtrDireccionesDto result = new MtrDireccionesDto();

            if (direccion != null)
            {
                result = _mapper.Map<MtrDireccionesDto>(direccion);
            }
            else
            {
                result = null;
            }


            return result;

        }

    }
}
