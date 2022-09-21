using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.SapEstadoCuentaResult;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CobEstadoCuentaController : ControllerBase
    {
        private readonly ICobEstadoCuentaService _cobEstadoCuentaService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IMtrClienteService _mtrClienteService;
        private readonly ISapClient _sapClient;
        private readonly PaginationOptions _paginationOptions;

        //Constructor
        public CobEstadoCuentaController(ICobEstadoCuentaService cobEstadoCuentaService,
                                            IMapper mapper,
                                            IUriService uriService,
                                            IOptions<PaginationOptions> options,
                                            IOfdTipoDocumentoService ofdTipoDocumentoService,
                                            IMtrClienteService mtrClienteService,
                                            ISapClient sapClient)
        {

         

            _cobEstadoCuentaService = cobEstadoCuentaService;
            _mapper = mapper;
            _uriService = uriService;
            _mtrClienteService = mtrClienteService;
            _sapClient = sapClient;
            _paginationOptions = options.Value;
        }

        //
        /// <summary>
        /// Retorna los datos del Estado de Cuenta el cliente
        /// Filtros a aplicar CobEstadoCuentaFilter, si en el objeto incluye IdCliente, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar CobEstadoCuentaFilter, si en el objeto incluye IdCliente, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobEstadoCuentaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public async Task<IActionResult> GetEstadoCuenta(CobEstadoCuentaQueryFilter filters)
        {
            List<CobEstadoCuentaDto> result = new List<CobEstadoCuentaDto>();
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };
            ApiResponse<IEnumerable<CobEstadoCuentaDto>> response = new ApiResponse<IEnumerable<CobEstadoCuentaDto>>(result);

            string userSap = _paginationOptions.UserSap;
            string passwordSap = _paginationOptions.PasswordSap;
           

            var meta = await _sapClient.GetToken(userSap, passwordSap);
            if (!meta.IsValid)
            {
                metadata.IsValid = false;
                metadata.Message = "No tenemos conexion a SAP.....Intente mas tarde(Validando Conexion. CobEstadoCuentaController line 84)";

                response.Data = result;
                response.Meta = metadata;


                return Ok(response);

            }
           


            PagedList<CobEstadoDeCuenta> listEstadoCuenta;

              listEstadoCuenta = await _cobEstadoCuentaService.GetEstadoCuenta(filters);

            if (listEstadoCuenta==null)
            {

                response.Meta = metadata;
                return Ok(response);
            }
           




            IEnumerable<CobEstadoCuentaDto> listEstadoCuentaDto = _mapper.Map<IEnumerable<CobEstadoCuentaDto>>(listEstadoCuenta);

           
            foreach (var item in listEstadoCuentaDto)
            {
                var cliente = await _mtrClienteService.GetByIdAsync(item.IdCliente);
               

              
                item.Saldo = item.Rpaap;
                decimal decimalValue = (decimal)item.Saldo;
                item.SaldoString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                decimalValue = (decimal)item.Iva;
                item.IvaString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                decimalValue = (decimal)item.MontoOriginal;
                item.MontoOriginalString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                decimalValue = (decimal)item.BaseImponible;
                item.BaseImponibleString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                

                item.searchText = item.Rpdct + "-" + item.Rpdoc.ToString() + "- Cliente: " + cliente.Nombre.Trim() + "- Saldo: " + item.SaldoString;
                result.Add(item);
            }


            metadata.IsValid = true;
            metadata.Message = "";
            metadata.TotalCount = listEstadoCuenta.TotalCount;
            metadata.PageSize = listEstadoCuenta.PageSize;
            metadata.CurrentPage = listEstadoCuenta.CurrentPage;
            metadata.TotalPage = listEstadoCuenta.TotalPage;
            metadata.HasNextPage = listEstadoCuenta.HasNextPage;
            metadata.HasPreviousPage = listEstadoCuenta.HasPreviousPage;
            metadata.NextPageUrl = "";       // _uriService.GetGeneralCobranzaPaginationUri(filters, "").ToString(),
            metadata.PreviousPageUrl = "";   // _uriService.GetGeneralCobranzaPaginationUri(filters, "").ToString(),


            response.Data = result;
            response.Meta = metadata;
           

            return Ok(response);
        }


        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobEstadoCuentaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetEstadoCuentaMultiMoneda(CobEstadoCuentaQueryFilter filters)
        {
            List<CobEstadoCuentaMultiMoneda> result = new List<CobEstadoCuentaMultiMoneda>();
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };
            ApiResponse<IEnumerable<CobEstadoCuentaMultiMoneda>> response = new ApiResponse<IEnumerable<CobEstadoCuentaMultiMoneda>>(result);

            string userSap = _paginationOptions.UserSap;
            string passwordSap = _paginationOptions.PasswordSap;


            var meta = await _sapClient.GetToken(userSap, passwordSap);
            if (!meta.IsValid)
            {
                metadata.IsValid = false;
                metadata.Message = "No tenemos conexion a SAP.....Intente mas tarde(Validando Conexion. CobEstadoCuentaController line 84)";

                response.Data = result;
                response.Meta = metadata;


                return Ok(response);

            }

            await _cobEstadoCuentaService.GenerateEstadoCuentaMultimoneda();
           // result = await _cobEstadoCuentaService.GetEstadoCuentaMultimoneda(filters);
        


            

            if (result == null)
            {

                response.Meta = metadata;
                return Ok(response);
            }


        


            metadata.IsValid = true;
            metadata.Message = "";
            metadata.TotalCount = 1;
            metadata.PageSize = 1;
            metadata.CurrentPage = 1;
            metadata.TotalPage = 1;
            metadata.HasNextPage = false;
            metadata.HasPreviousPage =false;
            metadata.NextPageUrl = "";       // _uriService.GetGeneralCobranzaPaginationUri(filters, "").ToString(),
            metadata.PreviousPageUrl = "";   // _uriService.GetGeneralCobranzaPaginationUri(filters, "").ToString(),


            response.Data = result;
            response.Meta = metadata;


            return Ok(response);
        }


    }
}