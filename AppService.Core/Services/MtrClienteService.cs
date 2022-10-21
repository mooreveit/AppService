using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Clientes;
using AppService.Core.Entities;
using AppService.Core.EntitiesClientes;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrClienteService : IMtrClienteService
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

            var clientes = await _unitOfWork.MtrClienteRepository.ListClientesPorUsuario(filter);






            return clientes;

        }


        public async Task<MtrCliente> GetByIdAsync(string id)
        {
            return await _unitOfWork.MtrClienteRepository.GetByIdAsync(id);
        }

        public MtrCliente GetById(string id)
        {
            return _unitOfWork.MtrClienteRepository.GetById(id);
        }


        public async Task<List<MtrDirecciones>> GetDireccionestByCodigo(string codigo)
        {
            var listDirecciones = await _unitOfWork.MtrDireccionesRepository.GetByIdCliente(codigo);


            return listDirecciones;
        }

        public async Task<List<MtrDireccionesDto>> GetDireccionestDtoByCodigo(string codigo)
        {
            var direcciones = await GetDireccionestByCodigo(codigo);
            direcciones = direcciones.Where(x => x.Inactivo == false).ToList();
            List<MtrDireccionesDto> result = new List<MtrDireccionesDto>();

            if (direcciones != null)
            {
                result = _mapper.Map<List<MtrDireccionesDto>>(direcciones);
            }


            return result;

        }

        public async Task<ApiResponse<OdooClienteTipoSectorRamo>> UpdateTipoSectorRamoPorCliente(OdooClienteTipoSectorRamo dto)
        {


            OdooClienteTipoSectorRamo resultDto = new OdooClienteTipoSectorRamo();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<OdooClienteTipoSectorRamo> response = new ApiResponse<OdooClienteTipoSectorRamo>(resultDto);

            if (dto.Tipo < 1)
            {
                metadata.IsValid = false;
                metadata.Message = "Tipo de Negocio Invalido (1 o 2)";
                response.Data = null;
                response.Meta = metadata;
                return response;
            }

            if (dto.Tipo > 2)
            {
                metadata.IsValid = false;
                metadata.Message = "Tipo de Negocio Invalido(1 o 2)";
                response.Data = null;
                response.Meta = metadata;
                return response;
            }

            if (dto.DescripcionSector.IsNullOrEmpty())
            {
                metadata.IsValid = false;
                metadata.Message = "Descripcion de Sector Ivalida";
                response.Data = null;
                response.Meta = metadata;
                return response;
            }
            if (dto.DescripcionRamo.IsNullOrEmpty())
            {
                metadata.IsValid = false;
                metadata.Message = "Descripcion de Ramo Ivalida";
                response.Data = null;
                response.Meta = metadata;
                return response;
            }

            var sector = await _unitOfWork.Wsmy065Repository.GetSectorBySector(dto.Sector);
            var ramo = await _unitOfWork.Wsmy065Repository.GetByRamo(dto.Ramo);

            if (sector == null && dto.Sector > 0 && !dto.DescripcionSector.IsNullOrEmpty())
            {

                Wsmy064 wsmy064 = new Wsmy064();
                wsmy064.Sector = dto.Sector;
                wsmy064.NombreSector = dto.DescripcionSector;
                wsmy064.FechaCreacion = DateTime.Now;
                wsmy064.FlagInactiva = false;
                await _unitOfWork.Wsmy065Repository.AddSector(wsmy064);

            }
            if (ramo == null && dto.Ramo > 0 && !dto.DescripcionRamo.IsNullOrEmpty())
            {

                Wsmy065 wsmy065 = new Wsmy065();
                wsmy065.Sector = dto.Sector;
                wsmy065.Ramo = dto.Ramo;
                wsmy065.NombreRamo = dto.DescripcionRamo;
                wsmy065.FechaCreacion = DateTime.Now;
                wsmy065.FlagInactiva = false;
                await _unitOfWork.Wsmy065Repository.AddRamo(wsmy065);

            }



            var mtrCliente = GetById(dto.IdCliente);
            if (mtrCliente == null)
            {
                metadata.IsValid = false;
                metadata.Message = "Cliente no existe";
                response.Data = null;
                response.Meta = metadata;
                return response;
            }
            else
            {
                mtrCliente.TipoNegocio = dto.Tipo.ToString();
                mtrCliente.SubSegmentoa = dto.Ramo.ToString();
                mtrCliente.Segmento = dto.Sector.ToString();
                _unitOfWork.MtrClienteRepository.Update(mtrCliente);

            }

            var csmy003 = await _unitOfWork.Wsmy065Repository.GetClienteCsmy003(dto.IdCliente);
            if (csmy003 != null)
            {
                csmy003.TipoNegocio = dto.Tipo.ToString();
                csmy003.SubSegmentoa = dto.Ramo.ToString();
                csmy003.Segmento = dto.Sector.ToString();
                _unitOfWork.Wsmy065Repository.UpdateCsmy003(csmy003);

            }
            await _unitOfWork.SaveChangesAsync();

            metadata.IsValid = true;
            metadata.Message = "Cliente Actualizado Satisfactoriamente";
            response.Data = dto;
            response.Meta = metadata;
            return response;


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
