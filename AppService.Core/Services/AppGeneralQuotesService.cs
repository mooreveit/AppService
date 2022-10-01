using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Cotizaciones.Recibir;
using AppService.Core.Entities;
using AppService.Core.EntitiesFacturacion;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppGeneralQuotesService : IAppGeneralQuotesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOfdCotizacionService _ofdCotizacionService;
        private readonly IMtrClienteService _mtrClienteService;
        private readonly IAppDetailQuotesService _appDetailQuotesService;
        private readonly ICotizacionService _cotizacionService;
        private readonly PaginationOptions _paginationOptions;

        public AppGeneralQuotesService(IUnitOfWork unitOfWork,
                                       IOptions<PaginationOptions> options,
                                        IMapper mapper,
                                        IOfdCotizacionService ofdCotizacionService,
                                        IMtrClienteService mtrClienteService,
                                        IAppDetailQuotesService appDetailQuotesService,
                                        ICotizacionService cotizacionService
                                        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _ofdCotizacionService = ofdCotizacionService;
            _mtrClienteService = mtrClienteService;
            _appDetailQuotesService = appDetailQuotesService;
            _cotizacionService = cotizacionService;
            _paginationOptions = options.Value;
        }

        public async Task<AppGeneralQuotes> GetById(int id)
        {
            return await _unitOfWork.AppGeneralQuotesRepository.GetById(id);
        }

        public async Task<AppGeneralQuotes> GetByIdForUpdate(int id)
        {
            return await _unitOfWork.AppGeneralQuotesRepository.GetByIdForUpdate(id);
        }

        public async Task<AppGeneralQuotesGetDto> GetAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {

            //await _cotizacionService.IntegrarCotizacion(300,true);


            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;


            AppGeneralQuotes quotes = await _unitOfWork.AppGeneralQuotesRepository.GetByCotizacions(filters.Cotizacion);
            if (quotes != null)
            {
                AppGeneralQuotesGetDto appGeneralQuotesGetDto = _mapper.Map<AppGeneralQuotesGetDto>(quotes);

                MtrVendedor mtrVendedor = _unitOfWork.MtrVendedorRepository.GetById(appGeneralQuotesGetDto.IdVendedor);
                if (mtrVendedor != null)
                {
                    MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(mtrVendedor);
                    appGeneralQuotesGetDto.MtrVendedorDto = mtrVendedorDto;
                }



                MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(appGeneralQuotesGetDto.IdCliente);
                if (mtrCliente != null)
                {
                    MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                    appGeneralQuotesGetDto.MtrClienteDto = mtrClienteDto;


                }

                MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById(appGeneralQuotesGetDto.IdContacto);
                if (mtrContactos != null)
                {

                    //MtrContactosDto mtrContactosDto = new MtrContactosDto();
                    //mtrContactosDto.IdContacto = mtrContactos.IdContacto;
                    //mtrContactosDto.Cargo = mtrContactos.Email;

                    MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(mtrContactos);
                    appGeneralQuotesGetDto.MtrContactosDto = mtrContactosDto;
                }



                MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesGetDto.IdDireccionEntregar);
                if (direccionEntregar != null)
                {
                    MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                    appGeneralQuotesGetDto.MtrDireccionesEntregarDto = direccionEntregarDto;
                }



                MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesGetDto.IdDireccionFacturar);
                if (direccionFacturar != null)
                {
                    MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                    appGeneralQuotesGetDto.MtrDireccionesFacturarDto = direccionFacturarDto;

                }

                MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(appGeneralQuotesGetDto.IdCondPago);
                if (condicionPago != null)
                {
                    CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                    appGeneralQuotesGetDto.CondicionPagoDto = condicionPagoDto;

                }

                MtrTipoMoneda mtrTipoMoneda = await _unitOfWork.MtrTipoMonedaRepository.GetById(appGeneralQuotesGetDto.IdMtrTipoMoneda);
                if (mtrTipoMoneda != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(mtrTipoMoneda);
                    appGeneralQuotesGetDto.MtrTipoMonedaDto = mtrTipoMonedaDto;

                }

                //if (quotes.IntegrarCotizacion == false)
                //{
                //    var actualizar = await _unitOfWork.AppGeneralQuotesRepository.VerificarStatus(appGeneralQuotesGetDto.Id);
                //    if (actualizar != appGeneralQuotesGetDto.IdEstatus)
                //    {
                //        appGeneralQuotesGetDto.IdEstatus = actualizar;
                //        await _unitOfWork.SaveChangesAsync();
                //    }
                //}



                AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotesGetDto.IdEstatus);
                if (appStatusQuote != null)
                {
                    AppStatusQuoteGetDto appStatusQuoteDto = _mapper.Map<AppStatusQuoteGetDto>(appStatusQuote);
                    appGeneralQuotesGetDto.AppStatusQuoteGetDto = appStatusQuoteDto;
                    appGeneralQuotesGetDto.ClaseCss = appStatusQuoteDto.ClaseCss;

                }

                appGeneralQuotesGetDto.PorcFlete = await GetFleteByIdDireccionEntrega(appGeneralQuotesGetDto.IdDireccionEntregar);


                var permiteAdicionarDetalle = await _unitOfWork.AppGeneralQuotesRepository.PermiteAdicionarDetalle(appGeneralQuotesGetDto.Id);
                appGeneralQuotesGetDto.PermiteAdicionarDetalle = permiteAdicionarDetalle;

                appGeneralQuotesGetDto.AppGeneralQuotesActionSheetDto = await GetAppGeneralQuotesActionSheetDto(appGeneralQuotesGetDto.Id, appStatusQuote, appGeneralQuotesGetDto.Cotizacion);

                ApiResponse<List<AppDetailQuotesGetDto>> listDetail = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(appGeneralQuotesGetDto.Id);
                if (listDetail != null)
                {
                    appGeneralQuotesGetDto.AppDetailQuotesGetDto = listDetail.Data;
                }




                return appGeneralQuotesGetDto;
            }
            else
            {
                return null;
            }





        }

        public async Task<PagedList<AppGeneralQuotesGetDto>> GetAllAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {


            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;


            List<AppGeneralQuotes> quotes = await _unitOfWork.AppGeneralQuotesRepository.GetAll(filters);
            if (quotes.Count > 0)
            {
                List<AppGeneralQuotesGetDto> appGeneralQuotesGetDto = new List<AppGeneralQuotesGetDto>();

                foreach (var item in quotes)
                {

                    AppGeneralQuotesGetDto itemAppGeneralQuotesGetDto = _mapper.Map<AppGeneralQuotesGetDto>(item);

                    if (item.IdVendedorNavigation != null)
                    {
                        MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(item.IdVendedorNavigation);
                        itemAppGeneralQuotesGetDto.MtrVendedorDto = mtrVendedorDto;
                    }


                    if (item.IdClienteNavigation != null)
                    {
                        MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(item.IdClienteNavigation);
                        itemAppGeneralQuotesGetDto.MtrClienteDto = mtrClienteDto;
                        if (item.IdCliente == "000000")
                        {
                            itemAppGeneralQuotesGetDto.MtrClienteDto.Descripcion = item.IdCliente.Trim() + "-" + item.RazonSocial.Trim() + " RIF: " + item.Rif.ToString();
                        }
                    }


                    if (item.IdContactoNavigation != null)
                    {
                        MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(item.IdContactoNavigation);
                        itemAppGeneralQuotesGetDto.MtrContactosDto = mtrContactosDto;
                    }


                    MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionEntregar);
                    if (direccionEntregar != null)
                    {
                        MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                        itemAppGeneralQuotesGetDto.MtrDireccionesEntregarDto = direccionEntregarDto;
                    }



                    MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionFacturar);
                    if (direccionFacturar != null)
                    {
                        MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                        itemAppGeneralQuotesGetDto.MtrDireccionesFacturarDto = direccionFacturarDto;

                    }

                    MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(item.IdCondPago);
                    if (condicionPago != null)
                    {
                        CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                        itemAppGeneralQuotesGetDto.CondicionPagoDto = condicionPagoDto;

                    }


                    if (item.IdMtrTipoMonedaNavigation != null)
                    {
                        MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(item.IdMtrTipoMonedaNavigation);
                        itemAppGeneralQuotesGetDto.MtrTipoMonedaDto = mtrTipoMonedaDto;

                    }


                    if (item.IdEstatusNavigation != null)
                    {
                        AppStatusQuoteGetDto appStatusQuoteDto = _mapper.Map<AppStatusQuoteGetDto>(item.IdEstatusNavigation);
                        itemAppGeneralQuotesGetDto.AppStatusQuoteGetDto = appStatusQuoteDto;
                        itemAppGeneralQuotesGetDto.ClaseCss = item.IdEstatusNavigation.ClaseCss;

                    }

                    if (item.IdCliente == "000000")
                    {

                        var municipio = await _unitOfWork.Winy243Repository.GetById((decimal)item.IdMunicipio);
                        if (municipio != null)
                        {
                            itemAppGeneralQuotesGetDto.PorcFlete = municipio.PorcFlete;
                            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                            itemAppGeneralQuotesGetDto.MunicipioGetDto = municipioGetDto;
                        }

                    }
                    else
                    {
                        itemAppGeneralQuotesGetDto.PorcFlete = await GetFleteByIdDireccionEntrega(item.IdDireccionEntregar);
                        var municipio = await _unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregar.Estado, direccionEntregar.Municipio);
                        if (municipio != null)
                        {
                            itemAppGeneralQuotesGetDto.IdMunicipio = municipio.Recnum;
                            itemAppGeneralQuotesGetDto.descripcionMunicipio = municipio.DescMunicipio;
                            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                            itemAppGeneralQuotesGetDto.MunicipioGetDto = municipioGetDto;
                        }
                    }

                    var permiteAdicionarDetalle = await _unitOfWork.AppGeneralQuotesRepository.PermiteAdicionarDetalle(item.Id);
                    itemAppGeneralQuotesGetDto.PermiteAdicionarDetalle = permiteAdicionarDetalle;

                    itemAppGeneralQuotesGetDto.AppGeneralQuotesActionSheetDto = await GetAppGeneralQuotesActionSheetDto(item.Id, item.IdEstatusNavigation, item.Cotizacion);


                    ApiResponse<List<AppDetailQuotesGetDto>> listDetail = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(item.Id);
                    if (listDetail != null)
                    {
                        //itemAppGeneralQuotesGetDto.ProductosCotizados = await _appDetailQuotesService.DescripcionProductosCotizadosAppGeneralQuotesId(item.Id);
                        itemAppGeneralQuotesGetDto.ProductosCotizados = "";
                        foreach (var itemDetail in listDetail.Data)
                        {
                            itemAppGeneralQuotesGetDto.ProductosCotizados = itemAppGeneralQuotesGetDto.ProductosCotizados + "" + itemDetail.NombreComercialProducto;
                        }
                        itemAppGeneralQuotesGetDto.AppDetailQuotesGetDto = listDetail.Data;
                    }

                    itemAppGeneralQuotesGetDto.FechaString = item.Fecha.ToString("dd/MM/yyyy");

                    appGeneralQuotesGetDto.Add(itemAppGeneralQuotesGetDto);

                }
                PagedList<AppGeneralQuotesGetDto> pagedResult = PagedList<AppGeneralQuotesGetDto>.Create(appGeneralQuotesGetDto, filters.PageNumber, filters.PageSize);




                //List<AppGeneralQuotesGetDto> appGeneralQuotesGetDto = _mapper.Map<List<AppGeneralQuotesGetDto>>(quotes);

                //foreach (AppGeneralQuotesGetDto item in appGeneralQuotesGetDto)
                //{


                //    MtrVendedor mtrVendedor = _unitOfWork.MtrVendedorRepository.GetById(item.IdVendedor);
                //    if (mtrVendedor != null)
                //    {
                //        MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(mtrVendedor);
                //        item.MtrVendedorDto = mtrVendedorDto;
                //    }



                //    MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(item.IdCliente);
                //    if (mtrCliente != null)
                //    {
                //        MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                //        item.MtrClienteDto = mtrClienteDto;
                //        if (item.IdCliente == "000000")
                //        {
                //            item.MtrClienteDto.Descripcion = item.IdCliente.Trim() + "-" + item.RazonSocial.Trim() + " RIF: " + item.Rif.ToString();

                //        }

                //    }

                //    MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById(item.IdContacto);
                //    if (mtrContactos != null)
                //    {

                //        MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(mtrContactos);
                //        item.MtrContactosDto = mtrContactosDto;
                //    }



                //    MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionEntregar);
                //    if (direccionEntregar != null)
                //    {
                //        MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                //        item.MtrDireccionesEntregarDto = direccionEntregarDto;
                //    }



                //    MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionFacturar);
                //    if (direccionFacturar != null)
                //    {
                //        MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                //        item.MtrDireccionesFacturarDto = direccionFacturarDto;

                //    }

                //    MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(item.IdCondPago);
                //    if (condicionPago != null)
                //    {
                //        CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                //        item.CondicionPagoDto = condicionPagoDto;

                //    }

                //    MtrTipoMoneda mtrTipoMoneda = await _unitOfWork.MtrTipoMonedaRepository.GetById(item.IdMtrTipoMoneda);
                //    if (mtrTipoMoneda != null)
                //    {
                //        MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(mtrTipoMoneda);
                //        item.MtrTipoMonedaDto = mtrTipoMonedaDto;

                //    }




                //    AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(item.IdEstatus);
                //    if (appStatusQuote != null)
                //    {
                //        AppStatusQuoteGetDto appStatusQuoteDto = _mapper.Map<AppStatusQuoteGetDto>(appStatusQuote);
                //        item.AppStatusQuoteGetDto = appStatusQuoteDto;
                //        item.ClaseCss = appStatusQuote.ClaseCss;

                //    }

                //    if (item.IdCliente == "000000")
                //    {

                //        var municipio = await _unitOfWork.Winy243Repository.GetById(item.IdMunicipio);
                //        if (municipio != null)
                //        {
                //            item.PorcFlete = municipio.PorcFlete;
                //            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                //            item.MunicipioGetDto = municipioGetDto;
                //        }

                //    }
                //    else
                //    {
                //        item.PorcFlete = await GetFleteByIdDireccionEntrega(item.IdDireccionEntregar);
                //        var municipio = await _unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregar.Estado, direccionEntregar.Municipio);
                //        if (municipio != null)
                //        {
                //            item.IdMunicipio = municipio.Recnum;
                //            item.descripcionMunicipio = municipio.DescMunicipio;
                //            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                //            item.MunicipioGetDto = municipioGetDto;
                //        }
                //    }



                //    var permiteAdicionarDetalle = await _unitOfWork.AppGeneralQuotesRepository.PermiteAdicionarDetalle(item.Id);
                //    item.PermiteAdicionarDetalle = permiteAdicionarDetalle;

                //    item.AppGeneralQuotesActionSheetDto = await GetAppGeneralQuotesActionSheetDto(item.Id, appStatusQuote, item.Cotizacion);


                //    ApiResponse<List<AppDetailQuotesGetDto>> listDetail = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(item.Id);
                //    if (listDetail != null)
                //    {
                //        item.AppDetailQuotesGetDto = listDetail.Data;
                //    }

                //    item.FechaString = item.Fecha.ToString("dd/MM/yyyy");
                //}

                //PagedList<AppGeneralQuotesGetDto> pagedResult = PagedList<AppGeneralQuotesGetDto>.Create(appGeneralQuotesGetDto, filters.PageNumber, filters.PageSize);



                return pagedResult;
            }
            else
            {
                return null;
            }





        }

        public async Task<AppGeneralQuotesGetDto> GetOneAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {


            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;


            List<AppGeneralQuotes> quotes = await _unitOfWork.AppGeneralQuotesRepository.GetAll(filters);
            if (quotes.Count > 0)
            {
                List<AppGeneralQuotesGetDto> appGeneralQuotesGetDto = _mapper.Map<List<AppGeneralQuotesGetDto>>(quotes);
                foreach (AppGeneralQuotesGetDto item in appGeneralQuotesGetDto)
                {


                    MtrVendedor mtrVendedor = _unitOfWork.MtrVendedorRepository.GetById(item.IdVendedor);
                    if (mtrVendedor != null)
                    {
                        MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(mtrVendedor);
                        item.MtrVendedorDto = mtrVendedorDto;
                    }



                    MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(item.IdCliente);
                    if (mtrCliente != null)
                    {
                        MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                        item.MtrClienteDto = mtrClienteDto;
                        if (item.IdCliente == "000000")
                        {
                            item.MtrClienteDto.Descripcion = item.IdCliente.Trim() + "-" + item.RazonSocial.Trim() + " RIF: " + item.Rif.ToString();

                        }

                    }

                    MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById(item.IdContacto);
                    if (mtrContactos != null)
                    {

                        MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(mtrContactos);
                        item.MtrContactosDto = mtrContactosDto;
                    }



                    MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionEntregar);
                    if (direccionEntregar != null)
                    {
                        MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                        item.MtrDireccionesEntregarDto = direccionEntregarDto;
                    }



                    MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionFacturar);
                    if (direccionFacturar != null)
                    {
                        MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                        item.MtrDireccionesFacturarDto = direccionFacturarDto;

                    }

                    MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(item.IdCondPago);
                    if (condicionPago != null)
                    {
                        CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                        item.CondicionPagoDto = condicionPagoDto;

                    }

                    MtrTipoMoneda mtrTipoMoneda = await _unitOfWork.MtrTipoMonedaRepository.GetById(item.IdMtrTipoMoneda);
                    if (mtrTipoMoneda != null)
                    {
                        MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(mtrTipoMoneda);
                        item.MtrTipoMonedaDto = mtrTipoMonedaDto;

                    }
                    //if (item.IntegrarCotizacion == false)
                    //{
                    //    var actualizar = await _unitOfWork.AppGeneralQuotesRepository.VerificarStatus(item.Id);
                    //    if (actualizar != item.IdEstatus)
                    //    {
                    //        item.IdEstatus = actualizar;
                    //        await _unitOfWork.SaveChangesAsync();
                    //    }

                    //}



                    AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(item.IdEstatus);
                    if (appStatusQuote != null)
                    {
                        AppStatusQuoteGetDto appStatusQuoteDto = _mapper.Map<AppStatusQuoteGetDto>(appStatusQuote);
                        item.AppStatusQuoteGetDto = appStatusQuoteDto;

                    }

                    if (item.IdCliente == "000000")
                    {

                        var municipio = await _unitOfWork.Winy243Repository.GetById(item.IdMunicipio);
                        if (municipio != null)
                        {
                            item.PorcFlete = municipio.PorcFlete;
                            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                            item.MunicipioGetDto = municipioGetDto;
                        }

                    }
                    else
                    {
                        item.PorcFlete = await GetFleteByIdDireccionEntrega(item.IdDireccionEntregar);
                        var municipio = await _unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregar.Estado, direccionEntregar.Municipio);
                        if (municipio != null)
                        {
                            item.IdMunicipio = municipio.Recnum;
                            item.descripcionMunicipio = municipio.DescMunicipio;
                            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                            item.MunicipioGetDto = municipioGetDto;
                        }
                    }



                    var permiteAdicionarDetalle = await _unitOfWork.AppGeneralQuotesRepository.PermiteAdicionarDetalle(item.Id);
                    item.PermiteAdicionarDetalle = permiteAdicionarDetalle;

                    item.AppGeneralQuotesActionSheetDto = await GetAppGeneralQuotesActionSheetDto(item.Id, appStatusQuote, item.Cotizacion);


                    ApiResponse<List<AppDetailQuotesGetDto>> listDetail = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(item.Id);
                    if (listDetail != null)
                    {
                        item.AppDetailQuotesGetDto = listDetail.Data;
                    }

                    item.FechaString = item.Fecha.ToString("dd/MM/yyyy");
                }

                //PagedList<AppGeneralQuotesGetDto> pagedResult = PagedList<AppGeneralQuotesGetDto>.Create(appGeneralQuotesGetDto, filters.PageNumber, filters.PageSize);

                var result = appGeneralQuotesGetDto.FirstOrDefault();

                return result;
            }
            else
            {
                return null;
            }





        }



        public async Task<PagedList<AppGeneralQuotesGetDto>> GetAllSimpleAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {





            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;


            List<AppGeneralQuotes> quotes = await _unitOfWork.AppGeneralQuotesRepository.GetAll(filters);
            if (quotes.Count > 0)
            {
                List<AppGeneralQuotesGetDto> appGeneralQuotesGetDto = _mapper.Map<List<AppGeneralQuotesGetDto>>(quotes);
                foreach (AppGeneralQuotesGetDto item in appGeneralQuotesGetDto)
                {






                    MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(item.IdCliente);
                    if (mtrCliente != null)
                    {
                        MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                        item.MtrClienteDto = mtrClienteDto;
                        if (item.IdCliente == "000000")
                        {
                            item.MtrClienteDto.Descripcion = item.IdCliente.Trim() + "-" + item.RazonSocial.Trim() + " RIF: " + item.Rif.ToString();

                        }

                    }














                    var actualizar = await _unitOfWork.AppGeneralQuotesRepository.VerificarStatus(item.Id);
                    if (actualizar != item.IdEstatus)
                    {
                        item.IdEstatus = actualizar;
                        await _unitOfWork.SaveChangesAsync();
                    }


                    AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(item.IdEstatus);
                    if (appStatusQuote != null)
                    {
                        AppStatusQuoteGetDto appStatusQuoteDto = _mapper.Map<AppStatusQuoteGetDto>(appStatusQuote);
                        item.AppStatusQuoteGetDto = appStatusQuoteDto;

                    }









                    item.FechaString = item.Fecha.ToString("dd/MM/yyyy");
                }

                PagedList<AppGeneralQuotesGetDto> pagedResult = PagedList<AppGeneralQuotesGetDto>.Create(appGeneralQuotesGetDto, filters.PageNumber, filters.PageSize);



                return pagedResult;
            }
            else
            {
                return null;
            }





        }

        public async Task<AppGeneralQuotes> Insert(AppGeneralQuotes appGeneralQuotes)
        {
            try
            {
                await _unitOfWork.AppGeneralQuotesRepository.Add(appGeneralQuotes);

                await _unitOfWork.SaveChangesAsync();
                return appGeneralQuotes;
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
                throw;
            }

        }

        public async Task<ApiResponse<AppGeneralQuotesGetDto>> InsertGeneralQuotes(
         AppGeneralQuotesCreateDto appGeneralQuotesCreateDto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);
            try
            {
                MtrCliente cliente = await this._mtrClienteService.GetByIdAsync(appGeneralQuotesCreateDto.IdCliente);
                if (cliente == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cliente No Existe!!! " + appGeneralQuotesCreateDto.IdCliente;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                MtrDirecciones direccionEntregarValidate = await this._unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesCreateDto.IdDireccionEntregar);
                if (direccionEntregarValidate == null && appGeneralQuotesCreateDto.IdCliente != "000000")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Direccion Entregar No Existe!!! " + appGeneralQuotesCreateDto.IdCliente;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.MtrContactosRepository.GetById(appGeneralQuotesCreateDto.IdContacto) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.MtrCondicionPagoRepository.GetById(appGeneralQuotesCreateDto.IdCondPago) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Condicion de Pago No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.MtrTipoMonedaRepository.GetById(appGeneralQuotesCreateDto.IdMtrTipoMoneda) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (appGeneralQuotesCreateDto.OrdenCompra.Length > 16)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Longitud Maxima de Orden de Compra es 16 !!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                appGeneralQuotesCreateDto.Fecha = DateTime.Now;
                if (appGeneralQuotesCreateDto.IdCliente != "000000")
                {
                    appGeneralQuotesCreateDto.Rif = cliente.NoRegTribut;
                    appGeneralQuotesCreateDto.RazonSocial = cliente.Nombre;
                    appGeneralQuotesCreateDto.Direccion = cliente.Direccion + " " + cliente.Direccion1;
                }
                AppGeneralQuotes appGeneralQuotes = this._mapper.Map<AppGeneralQuotes>((object)appGeneralQuotesCreateDto);
                appGeneralQuotes.IdVendedor = !(appGeneralQuotesCreateDto.IdCliente != "000000") ? appGeneralQuotesCreateDto.UsuarioActualiza : cliente.Vendedor1.Trim();
                if (appGeneralQuotesCreateDto.IdCliente == "000000")
                {
                    appGeneralQuotes.IdMunicipio = new Decimal?(appGeneralQuotesCreateDto.IdMunicipio);
                    Winy243 byId = await _unitOfWork.Winy243Repository.GetById(appGeneralQuotesCreateDto.IdMunicipio);
                    if (byId != null)
                        appGeneralQuotes.DescripcionMunicipio = byId.DescMunicipio;
                }
                else
                {
                    Winy243 byEstadoMunicipio = await this._unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregarValidate.Estado.ToString(), direccionEntregarValidate.Municipio.ToString());
                    if (byEstadoMunicipio != null)
                    {
                        appGeneralQuotes.IdMunicipio = new Decimal?(byEstadoMunicipio.Recnum);
                        appGeneralQuotes.DescripcionMunicipio = byEstadoMunicipio.DescMunicipio;
                    }
                }
                appGeneralQuotes.Cotizacion = this._unitOfWork.CotizacionRepository.ProximaCotizacion(appGeneralQuotes.IdVendedor);
                appGeneralQuotes.IdEstatus = 1;
                appGeneralQuotes.CreatedAt = DateTime.Now;
                appGeneralQuotes.FechaActualiza = DateTime.Now;
                appGeneralQuotes.FechaCaducidad = DateTime.Now.AddDays(1.0);
                appGeneralQuotes.DiasVigencia = 1;
                appGeneralQuotes.ObservacionPostergar = "";
                appGeneralQuotes.IdDireccionFacturar = cliente.IdDireccion.Value;
                appGeneralQuotes.UsuarioActualiza = appGeneralQuotesCreateDto.UsuarioActualiza;
                appGeneralQuotes.UserCreate = appGeneralQuotesCreateDto.UsuarioActualiza;
                appGeneralQuotes.Proximo = new int?(0);
                appGeneralQuotes.FijarPrecioBs = new bool?(appGeneralQuotesCreateDto.FijarPrecioBs);
                appGeneralQuotes.Orden = new long?(0L);
                if (appGeneralQuotes.ObservacionPostergar == null)
                    appGeneralQuotes.ObservacionPostergar = "";
                AppStatusQuote appStatusQuote = await this._unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);
                MtrVendedor byId1 = this._unitOfWork.MtrVendedorRepository.GetById(appGeneralQuotes.IdVendedor);
                if (appGeneralQuotesCreateDto.IdCliente != "000000")
                {
                    appGeneralQuotes.SearchText = appGeneralQuotes.Cotizacion + "-" + appGeneralQuotes.IdVendedor + "-" + byId1.Nombre.Trim() + "-" + appGeneralQuotes.IdCliente + "-" + cliente.Nombre.Trim() + "-" + appGeneralQuotes.IdVendedor + "-" + byId1.Nombre.Trim() + "-" + appGeneralQuotes.IdCliente + "-" + appGeneralQuotes.RazonSocial.Trim() + "-" + appStatusQuote.Descripcion.Trim();
                }
                else
                {
                    appGeneralQuotes.SearchText = appGeneralQuotes.Cotizacion + "-" + appGeneralQuotes.IdVendedor + "-" + byId1.Nombre.Trim() + "-" + appStatusQuote.Descripcion.Trim();
                    appGeneralQuotes.IdDireccionEntregar = 1M;
                    appGeneralQuotes.IdDireccionFacturar = 1M;
                }
                AppGeneralQuotes AppGeneralQuotesInserted = await this.Insert(appGeneralQuotes);
                if (AppGeneralQuotesInserted != null)
                {
                    await this._cotizacionService.IntegrarCotizacion(AppGeneralQuotesInserted.Id, false);
                    AppGeneralQuotesActionSheetDto quotesActionSheetDto = await this.GetAppGeneralQuotesActionSheetDto(AppGeneralQuotesInserted.Id, appStatusQuote, AppGeneralQuotesInserted.Cotizacion);
                    resultDto = this._mapper.Map<AppGeneralQuotesGetDto>((object)AppGeneralQuotesInserted);
                    MtrVendedor byId2 = this._unitOfWork.MtrVendedorRepository.GetById(resultDto.IdVendedor);
                    if (byId2 != null)
                        resultDto.MtrVendedorDto = this._mapper.Map<MtrVendedorDto>((object)byId2);
                    MtrCliente byId3 = this._unitOfWork.MtrClienteRepository.GetById(resultDto.IdCliente);
                    if (byId3 != null)
                        resultDto.MtrClienteDto = this._mapper.Map<MtrClienteDto>((object)byId3);
                    MtrContactos byId4 = await this._unitOfWork.MtrContactosRepository.GetById(resultDto.IdContacto);
                    if (byId4 != null)
                        resultDto.MtrContactosDto = this._mapper.Map<MtrContactosDto>((object)byId4);
                    MtrDirecciones byId5 = await this._unitOfWork.MtrDireccionesRepository.GetById(resultDto.IdDireccionEntregar);
                    if (byId5 != null)
                        resultDto.MtrDireccionesEntregarDto = this._mapper.Map<MtrDireccionesDto>((object)byId5);
                    MtrDirecciones byId6 = await this._unitOfWork.MtrDireccionesRepository.GetById(resultDto.IdDireccionFacturar);
                    if (byId6 != null)
                        resultDto.MtrDireccionesFacturarDto = this._mapper.Map<MtrDireccionesDto>((object)byId6);
                    MtrCondicionPago byId7 = await this._unitOfWork.MtrCondicionPagoRepository.GetById(resultDto.IdCondPago);
                    if (byId7 != null)
                        resultDto.CondicionPagoDto = this._mapper.Map<CondicionPagoDto>((object)byId7);
                    MtrTipoMoneda byId8 = await this._unitOfWork.MtrTipoMonedaRepository.GetById(resultDto.IdMtrTipoMoneda);
                    if (byId8 != null)
                        resultDto.MtrTipoMonedaDto = this._mapper.Map<MtrTipoMonedaDto>((object)byId8);
                    metadata.IsValid = true;
                    metadata.Message = "Cotizacion: " + resultDto.Cotizacion + " creada Satisfactoriamente!!";
                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Registro No actualizado";
                }
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
        }


        public async Task<ApiResponse<AppGeneralQuotesGetDto>> RegresarAGrabacionCotizacion(
          AppGeneralQuotesCopyDto dto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);
            try
            {




                AppGeneralQuotes appGeneralQuotes = await this.GetByIdForUpdate(dto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }


                var cotizacionTieneOrden = await _unitOfWork.PropuestaRepository.CotizacionTieneOrden(appGeneralQuotes.Cotizacion);
                if (cotizacionTieneOrden)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion Tiene Orden!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                appGeneralQuotes.IdEstatus = 1;
                var res = await this.Update(appGeneralQuotes);


                List<AppDetailQuotes> appDetailQuotesList = await this._unitOfWork.AppDetailQuotesRepository.GeSimpletByAppGeneralQuotesId(dto.Id);
                if (appDetailQuotesList != null)
                {
                    foreach (AppDetailQuotes entity in appDetailQuotesList)
                    {
                        entity.IdEstatus = 1;
                        this._unitOfWork.AppDetailQuotesRepository.Update(entity);
                        await this._unitOfWork.SaveChangesAsync();
                    }
                }

                await this._cotizacionService.IntegrarCotizacion(appGeneralQuotes.Id, true);
                AppStatusQuote byId = await this._unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);
                AppGeneralQuotesActionSheetDto quotesActionSheetDto = await this.GetAppGeneralQuotesActionSheetDto(appGeneralQuotes.Id, byId, appGeneralQuotes.Cotizacion);
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
        }

        public async Task<ApiResponse<AppGeneralQuotesGetDto>> CopiarGeneralQuotes(
          AppGeneralQuotesCopyDto dto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);
            try
            {
                AppGeneralQuotes appGeneralQuotes = await this.GetById(dto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                string cotizacion = this._unitOfWork.CotizacionRepository.ProximaCotizacion(appGeneralQuotes.IdVendedor);

                var appGeneralQuotes1 = new AppGeneralQuotes()
                {
                    IdVendedor = appGeneralQuotes.IdVendedor,
                    IdCliente = appGeneralQuotes.IdCliente.Trim(),
                    Fecha = DateTime.Now,
                    Observaciones = appGeneralQuotes.Observaciones,
                    DiasVigencia = 1,
                    FechaCaducidad = DateTime.Now.AddDays(1.0),
                    FechaPostergada = appGeneralQuotes.FechaPostergada,
                    IdEstatus = 1,
                    IdCondPago = appGeneralQuotes.IdCondPago,
                    IdContacto = appGeneralQuotes.IdContacto,
                    ObservacionPostergar = appGeneralQuotes.ObservacionPostergar,
                    IdDireccionFacturar = appGeneralQuotes.IdDireccionFacturar,
                    IdDireccionEntregar = appGeneralQuotes.IdDireccionEntregar,
                    OrdenCompra = appGeneralQuotes.OrdenCompra,
                    UsuarioActualiza = appGeneralQuotes.UsuarioActualiza,
                    FechaActualiza = appGeneralQuotes.FechaActualiza,
                    UserCreate = dto.UsuarioActualiza,
                    UserUpdate = dto.UsuarioActualiza,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Cotizacion = cotizacion,
                    SearchText = appGeneralQuotes.SearchText,
                    Proximo = 0,
                    IdMtrTipoMoneda = appGeneralQuotes.IdMtrTipoMoneda,
                    FijarPrecioBs = appGeneralQuotes.FijarPrecioBs,
                    Rif = appGeneralQuotes.Rif,
                    RazonSocial = appGeneralQuotes.RazonSocial,
                    Direccion = appGeneralQuotes.Direccion,
                    IdMunicipio = appGeneralQuotes.IdMunicipio,
                    DescripcionMunicipio = appGeneralQuotes.DescripcionMunicipio,
                    IntegrarCotizacion = appGeneralQuotes.IntegrarCotizacion,
                    Orden = appGeneralQuotes.Orden,
                    OrdenAnterior = appGeneralQuotes.OrdenAnterior
                };

                //AppGeneralQuotes appGeneralQuotes1 = await this.ClonarAppGeneralQuotes(appGeneralQuotes);




                AppGeneralQuotes appGeneralQuotesInserted = await this.Insert(appGeneralQuotes1);
                //await this._unitOfWork.SaveChangesAsync();
                List<AppDetailQuotes> appDetailQuotesList = await this._unitOfWork.AppDetailQuotesRepository.GeSimpletByAppGeneralQuotesId(dto.Id);
                if (appDetailQuotesList != null)
                {
                    foreach (AppDetailQuotes item in appDetailQuotesList)
                    {
                        AppDetailQuotes appDetailQuotesNew = await this.ClonarAppDetailQuotes(item);
                        appDetailQuotesNew.AppGeneralQuotesId = appGeneralQuotesInserted.Id;
                        appDetailQuotesNew.Cotizacion = cotizacion;
                        appDetailQuotesNew.FechaRegistro = DateTime.Now;
                        appDetailQuotesNew.CreatedAt = DateTime.Now;
                        appDetailQuotesNew.UserCreate = dto.UsuarioActualiza;
                        appDetailQuotesNew.UpdatedAt = new DateTime?(DateTime.Now);
                        appDetailQuotesNew.UserUpdate = dto.UsuarioActualiza;
                        appDetailQuotesNew.IdEstatus = 1;
                        await this._unitOfWork.AppDetailQuotesRepository.Add(appDetailQuotesNew);
                        await this._unitOfWork.SaveChangesAsync();
                        AppDetailQuotes newDetail = await this._unitOfWork.AppDetailQuotesRepository.GetByQuetesProduct(cotizacion, appDetailQuotesNew.IdProducto);
                        List<AppDetailQuotesConversionUnit> appDetailQuotesId = await this._unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(item.Id);
                        if (appDetailQuotesId != null)
                        {
                            foreach (AppDetailQuotesConversionUnit appDetailQuotesConversionUnit in appDetailQuotesId)
                            {
                                AppDetailQuotesConversionUnit quotesConversionUnit = new AppDetailQuotesConversionUnit();
                                AppDetailQuotesConversionUnit entity = await this.ClonarAppDetailQuotesConvesion(appDetailQuotesConversionUnit);
                                entity.AppDetailQuotesId = new int?(newDetail.Id);
                                this._unitOfWork.AppDetailQuotesConversionUnitRepository.Add(entity);
                                await this._unitOfWork.SaveChangesAsync();
                            }
                        }
                        appDetailQuotesNew = (AppDetailQuotes)null;
                        newDetail = (AppDetailQuotes)null;
                    }
                }
                await this._cotizacionService.IntegrarCotizacion(appGeneralQuotesInserted.Id, true);
                AppStatusQuote byId = await this._unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotesInserted.IdEstatus);
                AppGeneralQuotesActionSheetDto quotesActionSheetDto = await this.GetAppGeneralQuotesActionSheetDto(appGeneralQuotesInserted.Id, byId, appGeneralQuotesInserted.Cotizacion);
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
        }

        public async Task<ApiResponse<AppGeneralQuotesGetDto>> UpdateGeneralQuotes(
          AppGeneralQuotesUpdateDto appGeneralQuotesUpdateDto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);
            try
            {
                AppGeneralQuotes appGeneralQuotes = await this.GetByIdForUpdate(appGeneralQuotesUpdateDto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! " + appGeneralQuotesUpdateDto.Cotizacion;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                MtrCliente cliente = await this._mtrClienteService.GetByIdAsync(appGeneralQuotesUpdateDto.IdCliente);
                if (cliente == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cliente No Existe!!! " + appGeneralQuotesUpdateDto.IdCliente;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                MtrDirecciones direccionEntregarValidate = await this._unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesUpdateDto.IdDireccionEntregar);
                if (direccionEntregarValidate == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Direccion Entregar No Existe!!! " + appGeneralQuotesUpdateDto.IdDireccionEntregar.ToString();
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                //else
                //{
                //    if (direccionEntregarValidate.Codigo != appGeneralQuotesUpdateDto.IdCliente)
                //    {
                //        metadata.IsValid = false;
                //        metadata.Message = "Direccion Entregar No Corresponde al Cliente!!! " + appGeneralQuotesUpdateDto.IdDireccionEntregar.ToString();
                //        response.Meta = metadata;
                //        response.Data = resultDto;
                //        return response;
                //    }
                //}


                if (await this._unitOfWork.MtrContactosRepository.GetById(appGeneralQuotesUpdateDto.IdContacto) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.MtrCondicionPagoRepository.GetById(appGeneralQuotesUpdateDto.IdCondPago) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Condicion de Pago No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (await this._unitOfWork.MtrTipoMonedaRepository.GetById(appGeneralQuotesUpdateDto.IdMtrTipoMoneda) == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (appGeneralQuotesUpdateDto.OrdenCompra.Length > 16)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Longitud Maxima de Orden de Compra es 16 !!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (appGeneralQuotesUpdateDto.IdCliente != "000000")
                {
                    appGeneralQuotesUpdateDto.Rif = cliente.NoRegTribut;
                    appGeneralQuotesUpdateDto.RazonSocial = cliente.Nombre;
                    appGeneralQuotesUpdateDto.Direccion = cliente.Direccion + " " + cliente.Direccion1;
                }
                appGeneralQuotes.Rif = appGeneralQuotesUpdateDto.Rif;
                appGeneralQuotes.RazonSocial = appGeneralQuotesUpdateDto.RazonSocial;
                appGeneralQuotes.Direccion = appGeneralQuotesUpdateDto.Direccion;
                appGeneralQuotes.IdCliente = appGeneralQuotesUpdateDto.IdCliente;
                if (appGeneralQuotesUpdateDto.IdCliente == "000000")
                {
                    appGeneralQuotes.IdMunicipio = new Decimal?(appGeneralQuotesUpdateDto.IdMunicipio);
                    Winy243 byId = await this._unitOfWork.Winy243Repository.GetById(appGeneralQuotesUpdateDto.IdMunicipio);
                    if (byId != null)
                        appGeneralQuotes.DescripcionMunicipio = byId.DescMunicipio;
                }
                else
                {
                    Winy243 byEstadoMunicipio = await this._unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregarValidate.Estado, direccionEntregarValidate.Municipio);
                    if (byEstadoMunicipio != null)
                    {
                        appGeneralQuotes.IdMunicipio = new Decimal?(byEstadoMunicipio.Recnum);
                        appGeneralQuotes.DescripcionMunicipio = byEstadoMunicipio.DescMunicipio;
                    }
                }
                appGeneralQuotes.IdVendedor = !(appGeneralQuotesUpdateDto.IdCliente != "000000") ? appGeneralQuotesUpdateDto.UsuarioActualiza : cliente.Vendedor1.Trim();
                appGeneralQuotes.Observaciones = appGeneralQuotesUpdateDto.Observaciones;
                appGeneralQuotes.IdCondPago = appGeneralQuotesUpdateDto.IdCondPago;
                appGeneralQuotes.IdContacto = appGeneralQuotesUpdateDto.IdContacto;
                appGeneralQuotes.IdDireccionFacturar = cliente.IdDireccion.Value;
                appGeneralQuotes.IdDireccionEntregar = appGeneralQuotesUpdateDto.IdDireccionEntregar;
                appGeneralQuotes.OrdenCompra = appGeneralQuotesUpdateDto.OrdenCompra;
                appGeneralQuotes.UsuarioActualiza = appGeneralQuotesUpdateDto.UsuarioActualiza;
                appGeneralQuotes.FechaActualiza = DateTime.Now;
                appGeneralQuotes.Proximo = new int?(0);
                appGeneralQuotes.IdMtrTipoMoneda = new long?(appGeneralQuotesUpdateDto.IdMtrTipoMoneda);
                if (appGeneralQuotesUpdateDto.FechaPostergada.HasValue)
                    appGeneralQuotes.FechaPostergada = appGeneralQuotesUpdateDto.FechaPostergada;
                if (appGeneralQuotesUpdateDto.ObservacionPostergar != "" && appGeneralQuotesUpdateDto.ObservacionPostergar != null)
                    appGeneralQuotes.ObservacionPostergar = appGeneralQuotesUpdateDto.ObservacionPostergar;
                else
                    appGeneralQuotesUpdateDto.ObservacionPostergar = "";
                appGeneralQuotes.FijarPrecioBs = new bool?(appGeneralQuotesUpdateDto.FijarPrecioBs);
                AppStatusQuote appStatusQuote = await this._unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);
                MtrVendedor byId1 = this._unitOfWork.MtrVendedorRepository.GetById(appGeneralQuotes.IdVendedor);
                if (appGeneralQuotesUpdateDto.IdCliente != "000000")
                {
                    appGeneralQuotes.SearchText = appGeneralQuotes.Cotizacion + "-" + appGeneralQuotes.IdVendedor + "-" + byId1.Nombre.Trim() + "-" + appGeneralQuotes.IdCliente + "-" + cliente.Nombre.Trim() + appGeneralQuotes.IdVendedor + "-" + byId1.Nombre.Trim() + "-" + appGeneralQuotes.IdCliente + "-" + appGeneralQuotes.RazonSocial.Trim() + "-" + appStatusQuote.Descripcion.Trim();
                }
                else
                {
                    appGeneralQuotes.SearchText = appGeneralQuotes.Cotizacion + "-" + appGeneralQuotes.IdVendedor + "-" + byId1.Nombre.Trim() + "-" + appGeneralQuotes.IdCliente + "-" + appGeneralQuotes.RazonSocial.Trim() + "-" + appStatusQuote.Descripcion.Trim();
                    appGeneralQuotes.IdDireccionEntregar = 1M;
                    appGeneralQuotes.IdDireccionFacturar = 1M;
                }
                AppGeneralQuotes AppGeneralQuotesUpdated = await this.Update(appGeneralQuotes);
                await this._cotizacionService.IntegrarCotizacion(appGeneralQuotes.Id, true);
                AppGeneralQuotesActionSheetDto quotesActionSheetDto = await this.GetAppGeneralQuotesActionSheetDto(appGeneralQuotes.Id, appStatusQuote, appGeneralQuotes.Cotizacion);
                AppGeneralQuotesGetDto appGeneralQuotes1 = await this.GetOneAppGeneralQuotes(new AppGeneralQuotesQueryFilter()
                {
                    Cotizacion = AppGeneralQuotesUpdated.Cotizacion,
                    UsuarioConectado = appGeneralQuotesUpdateDto.UsuarioActualiza
                });
                if (AppGeneralQuotesUpdated != null)
                {
                    metadata.IsValid = true;
                    metadata.Message = "Cotizacion: " + appGeneralQuotes1.Cotizacion + " Actualizada Satisfactoriamente!!";
                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Registro No actualizado";
                }
                response.Meta = metadata;
                response.Data = appGeneralQuotes1;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
        }


        public async Task<ApiResponse<bool>> DeleteGeneralQuotes(AppGeneralQuotesDeleteDto appGeneralQuotesDeleteDto)
        {
            bool resultDto = new bool();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);

            try
            {

                AppGeneralQuotes appGeneralQuotes = await GetById(appGeneralQuotesDeleteDto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! " + appGeneralQuotesDeleteDto.Cotizacion;
                    response.Meta = metadata;
                    response.Data = false;
                    return response;
                }

                AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);
                if (appStatusQuote.FlagModificar == "X")
                {

                    await _cotizacionService.DeleteCotizacion(appGeneralQuotes);

                    var detail = await _unitOfWork.AppDetailQuotesRepository.GetByAppGeneralQuotesId(appGeneralQuotes.Id);
                    if (detail != null && detail.Count > 0)
                    {
                        foreach (var item in detail)
                        {

                            var detailConversion = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(item.Id);
                            if (detailConversion != null && detailConversion.Count > 0)
                            {
                                foreach (var itemConversion in detailConversion)
                                {
                                    await _unitOfWork.AppDetailQuotesConversionUnitRepository.Delete(itemConversion.Id);
                                    await _unitOfWork.SaveChangesAsync();
                                }
                            }


                            await _unitOfWork.AppDetailQuotesRepository.Delete(item.Id);
                            await _unitOfWork.SaveChangesAsync();
                        }
                    }
                    await Delete(appGeneralQuotesDeleteDto.Id);


                }



                metadata.IsValid = true;
                metadata.Message = $"Cotizacion: {appGeneralQuotesDeleteDto.Cotizacion} Eliminada Satisfactoriamente!!";

                response.Meta = metadata;
                response.Data = resultDto;

                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;

                metadata.Message = ex.InnerException.Message;

                response.Meta = metadata;
                response.Data = resultDto;

                return response;

            }





        }


        public async Task<AppGeneralQuotes> Update(AppGeneralQuotes appGeneralQuotes)
        {
            //appGeneralQuotes.IntegrarCotizacion = true;
            _unitOfWork.AppGeneralQuotesRepository.Update(appGeneralQuotes);
            await _unitOfWork.SaveChangesAsync();


            return await GetById(appGeneralQuotes.Id);

        }

        public async Task Delete(int id)
        {

            await _unitOfWork.AppGeneralQuotesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }


        public string ProximaCotizacion(string Cod_Vendedor)
        {

            string proximaCotizacion = _unitOfWork.AppGeneralQuotesRepository.ProximaCotizacion(Cod_Vendedor);


            return proximaCotizacion;

        }

        public async Task<ApiResponse<AppGeneralQuotesGetDto>> EnviarAlCliente(
       AppGeneralQuotesChangeStatusDto dto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);
            try
            {
                var appGeneralQuotes = await this.GetByIdForUpdate(dto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                if (appGeneralQuotes.IdEstatus != 1)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No esta en grabacion!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                appGeneralQuotes.IdEstatus = 2;
                var res = await this.Update(appGeneralQuotes);

                ApiResponse<List<AppDetailQuotesGetDto>> appGeneralQuotesId = await this._appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(dto.Id);
                if (appGeneralQuotesId.Data.Count > 0)
                {
                    foreach (AppDetailQuotesGetDto detailQuotesGetDto in appGeneralQuotesId.Data)
                    {
                        var entity = await this._appDetailQuotesService.GetById(detailQuotesGetDto.Id);
                        if (entity != null)
                        {
                            Decimal precioUsd = entity.PrecioUsd;
                            Decimal? unitPriceConverted = entity.UnitPriceConverted;
                            Decimal valueOrDefault = unitPriceConverted.GetValueOrDefault();
                            //if (precioUsd < valueOrDefault & unitPriceConverted.HasValue)
                            //{
                            //    metadata.IsValid = false;
                            //    metadata.Message = "Precio de Venta es menor a la Lista..Enviar a Aprobacion!!! ";
                            //    response.Meta = metadata;
                            //    response.Data = resultDto;
                            //    return response;
                            //}

                            entity.IdEstatus = 2;
                            this._unitOfWork.AppDetailQuotesRepository.Update(entity);
                            await this._unitOfWork.SaveChangesAsync();



                        }
                    }




                    await this._cotizacionService.IntegrarCotizacion(appGeneralQuotes.Id, true);
                    AppStatusQuote byId1 = await this._unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);
                    AppGeneralQuotesActionSheetDto quotesActionSheetDto = await this.GetAppGeneralQuotesActionSheetDto(appGeneralQuotes.Id, byId1, appGeneralQuotes.Cotizacion);
                    resultDto = await this.GetAppGeneralQuotes(new AppGeneralQuotesQueryFilter()
                    {
                        Cotizacion = appGeneralQuotes.Cotizacion
                    });
                    metadata.IsValid = true;
                    metadata.Message = "Cotizacion Enviada al cliente!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                metadata.IsValid = false;
                metadata.Message = "Cotizacion No tiene Productos cargados!!! ";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }
        }

        public async Task<AppGeneralQuotesActionSheetDto> GetAppGeneralQuotesActionSheetDto(
          int AppGeneralQuotesId,
          AppStatusQuote appStatusQuote,
          string cotizacion)
        {
            AppGeneralQuotesActionSheetDto resultDto = new AppGeneralQuotesActionSheetDto()
            {
                Cancel = true
            };
            AppGeneralQuotes generalQuotes = await this.GetById(AppGeneralQuotesId);
            if (generalQuotes != null)
            {
                resultDto.ExistQuotes = true;
                resultDto.RetornarAGrabacion = false;
                if (appStatusQuote.PrimeraEstacion != "X" && !generalQuotes.TieneOrden)
                    resultDto.RetornarAGrabacion = true;
                if (appStatusQuote.FlagModificar == "X")
                {
                    resultDto.Actualizar = true;
                    resultDto.Eliminar = true;
                }
                else
                {
                    resultDto.Actualizar = false;
                    resultDto.Eliminar = false;
                }
                if (appStatusQuote.PrimeraEstacion == "X")
                {
                    var requiereAprobacion = await this._appDetailQuotesService.RequiereAprobacionAppGeneralQuotesId(AppGeneralQuotesId);
                    if (requiereAprobacion)
                    {
                        resultDto.EnviarAlCliente = false;
                        resultDto.Imprimir = false;
                    }
                    else
                    {
                        resultDto.EnviarAlCliente = true;
                        resultDto.Imprimir = true;
                    }

                }
                else
                {
                    resultDto.EnviarAlCliente = false;
                    resultDto.RetornarAGrabacion = true;
                }

                if (appStatusQuote.Id > 1)
                {
                    resultDto.Imprimir = true;
                }
                else
                {
                    resultDto.Imprimir = false;
                }

                resultDto.EnviarAprobacionPrecio = false;
                resultDto.GanarPerder = false;
                if (appStatusQuote.FlagEnEspera == "X")
                    resultDto.GanarPerder = true;

                var cotizacionTieneOrden = await _unitOfWork.PropuestaRepository.CotizacionTieneOrden(generalQuotes.Cotizacion);
                if (cotizacionTieneOrden)
                {
                    resultDto.RetornarAGrabacion = false;
                }
                /*generalQuotes.Actualizar = resultDto.Actualizar;
                 generalQuotes.EnviarAlCliente = resultDto.EnviarAlCliente;
                 generalQuotes.EnviarAprobacionPrecio = resultDto.EnviarAprobacionPrecio;
                 generalQuotes.GanarPerder = resultDto.GanarPerder;
                 generalQuotes.Postergar = resultDto.Postergar;
                 generalQuotes.Eliminar = resultDto.Eliminar;
                 generalQuotes.Cancel = resultDto.Cancel;
                 generalQuotes.ExistQuotes = resultDto.ExistQuotes;
                 generalQuotes.Imprimir = resultDto.ExistQuotes;
                 generalQuotes.RetornarAGrabacion = resultDto.ExistQuotes;*/
                //AppGeneralQuotes appGeneralQuotes = await this.Update(generalQuotes);
            }
            else
                resultDto.ExistQuotes = false;
            AppGeneralQuotesActionSheetDto quotesActionSheetDto = resultDto;
            resultDto = (AppGeneralQuotesActionSheetDto)null;
            generalQuotes = (AppGeneralQuotes)null;
            return quotesActionSheetDto;
        }

        public async Task<AppGeneralQuotes> ClonarAppGeneralQuotes(
          AppGeneralQuotes appGeneralQuotes)
        {
            return new AppGeneralQuotes()
            {
                IdVendedor = appGeneralQuotes.IdVendedor,
                IdCliente = appGeneralQuotes.IdCliente.Trim(),
                Fecha = appGeneralQuotes.Fecha,
                Observaciones = appGeneralQuotes.Observaciones,
                DiasVigencia = appGeneralQuotes.DiasVigencia,
                FechaCaducidad = appGeneralQuotes.FechaCaducidad,
                FechaPostergada = appGeneralQuotes.FechaPostergada,
                IdEstatus = appGeneralQuotes.IdEstatus,
                IdCondPago = appGeneralQuotes.IdCondPago,
                IdContacto = appGeneralQuotes.IdContacto,
                ObservacionPostergar = appGeneralQuotes.ObservacionPostergar,
                IdDireccionFacturar = appGeneralQuotes.IdDireccionFacturar,
                IdDireccionEntregar = appGeneralQuotes.IdDireccionEntregar,
                OrdenCompra = appGeneralQuotes.OrdenCompra,
                UsuarioActualiza = appGeneralQuotes.UsuarioActualiza,
                FechaActualiza = appGeneralQuotes.FechaActualiza,
                UserCreate = appGeneralQuotes.UserCreate,
                UserUpdate = appGeneralQuotes.UserUpdate,
                CreatedAt = appGeneralQuotes.CreatedAt,
                UpdatedAt = appGeneralQuotes.UpdatedAt,
                Cotizacion = appGeneralQuotes.Cotizacion,
                SearchText = appGeneralQuotes.SearchText,
                Proximo = appGeneralQuotes.Proximo,
                IdMtrTipoMoneda = appGeneralQuotes.IdMtrTipoMoneda,
                FijarPrecioBs = appGeneralQuotes.FijarPrecioBs,
                Rif = appGeneralQuotes.Rif,
                RazonSocial = appGeneralQuotes.RazonSocial,
                Direccion = appGeneralQuotes.Direccion,
                IdMunicipio = appGeneralQuotes.IdMunicipio,
                DescripcionMunicipio = appGeneralQuotes.DescripcionMunicipio,
                IntegrarCotizacion = appGeneralQuotes.IntegrarCotizacion,
                Orden = appGeneralQuotes.Orden,
                OrdenAnterior = appGeneralQuotes.OrdenAnterior
            };
        }

        public async Task<AppDetailQuotes> ClonarAppDetailQuotes(
          AppDetailQuotes appDetailQuotes)
        {
            return new AppDetailQuotes()
            {
                AppGeneralQuotesId = appDetailQuotes.AppGeneralQuotesId,
                Cotizacion = appDetailQuotes.Cotizacion,
                Producto = appDetailQuotes.Producto,
                IdProducto = appDetailQuotes.IdProducto,
                NombreComercialProducto = appDetailQuotes.NombreComercialProducto,
                IdEstatus = appDetailQuotes.IdEstatus,
                Cantidad = appDetailQuotes.Cantidad,
                CantidadSolicitada = appDetailQuotes.CantidadSolicitada,
                Precio = appDetailQuotes.Precio,
                Total = appDetailQuotes.Total,
                PrecioUsd = appDetailQuotes.PrecioUsd,
                TotalUsd = appDetailQuotes.TotalUsd,
                IdUnidad = appDetailQuotes.IdUnidad,
                Observaciones = appDetailQuotes.Observaciones,
                DiasEntrega = appDetailQuotes.DiasEntrega,
                FechaRegistro = appDetailQuotes.FechaRegistro,
                UserCreate = appDetailQuotes.UserCreate,
                UserUpdate = appDetailQuotes.UserUpdate,
                CreatedAt = appDetailQuotes.CreatedAt,
                UpdatedAt = appDetailQuotes.UpdatedAt,
                RazonGanadaPerdida = appDetailQuotes.RazonGanadaPerdida,
                Competidor = appDetailQuotes.Competidor,
                ObsSolicitud = appDetailQuotes.ObsSolicitud,
                ValorConvertido = appDetailQuotes.ValorConvertido,
                UnitPriceBaseProduction = appDetailQuotes.UnitPriceBaseProduction,
                UnitPriceConverted = appDetailQuotes.UnitPriceConverted,
                CantidadPorUnidadProduccion = appDetailQuotes.CantidadPorUnidadProduccion,
                QuantityPerPackage = appDetailQuotes.QuantityPerPackage,
                SolicitarPrecio = appDetailQuotes.SolicitarPrecio,
                MedidaBasica = appDetailQuotes.MedidaBasica,
                MedidaOpuesta = appDetailQuotes.MedidaOpuesta
            };
        }

        public async Task<AppDetailQuotesConversionUnit> ClonarAppDetailQuotesConvesion(
          AppDetailQuotesConversionUnit appDetailQuotesConversionUnit)
        {
            return new AppDetailQuotesConversionUnit()
            {
                AppDetailQuotesId = appDetailQuotesConversionUnit.AppDetailQuotesId,
                AppVariableId = appDetailQuotesConversionUnit.AppVariableId,
                Description = appDetailQuotesConversionUnit.Description,
                Value = appDetailQuotesConversionUnit.Value,
                Formula = appDetailQuotesConversionUnit.Formula,
                FormulaValue = appDetailQuotesConversionUnit.FormulaValue,
                SumValue = appDetailQuotesConversionUnit.SumValue,
                OrderCalculate = appDetailQuotesConversionUnit.OrderCalculate,
                Code = appDetailQuotesConversionUnit.Code
            };
        }

        public async Task<Decimal> GetFleteByIdDireccionEntrega(Decimal id)
        {
            MtrDirecciones byId = await this._unitOfWork.MtrDireccionesRepository.GetById(id);
            Decimal direccionEntrega;
            if (byId != null)
            {
                Winy243 byEstadoMunicipio = await this._unitOfWork.Winy243Repository.GetByEstadoMunicipio(byId.Estado, byId.Municipio);
                direccionEntrega = byEstadoMunicipio == null ? 0M : byEstadoMunicipio.PorcFlete.Value;
            }
            else
                direccionEntrega = 0M;
            return direccionEntrega;
        }
        public async Task<Decimal> GetFleteByIdMunicipo(Decimal id)
        {
            decimal result = 0;

            Winy243 municipio = await this._unitOfWork.Winy243Repository.GetById(id);
            if (municipio != null)
            {
                result = (decimal)municipio.PorcFlete;
            }


            return result;
        }


        //#####################################################################################################################################
        // S E R V I C E S  O D D O 
        //#####################################################################################################################################
        public async Task<ApiResponse<GeneralGetDto>> OdooGeneralUpdate(GeneralUpdateDto dto)
        {
            GeneralGetDto resultDto = new GeneralGetDto();
            Metadata metadata = new Metadata()
            {
                IsValid = true,
                Message = ""
            };
            ApiResponse<GeneralGetDto> response = new ApiResponse<GeneralGetDto>(resultDto);

            try
            {
                var general = await GetById(dto.Id);
                if (general != null)//update
                {
                    AppGeneralQuotesUpdateDto appGeneralQuotesUpdateDto = new AppGeneralQuotesUpdateDto();

                    //appGeneralQuotesUpdateDto.Id = dto.Id;
                    //appGeneralQuotesUpdateDto.Cotizacion = dto.Cotizacion;
                    appGeneralQuotesUpdateDto.IdCliente = dto.IdCliente;
                    appGeneralQuotesUpdateDto.IdDireccionFacturar = dto.IdDireccionFacturar;
                    appGeneralQuotesUpdateDto.IdDireccionEntregar = dto.IdDireccionEntregar;
                    appGeneralQuotesUpdateDto.IdCondPago = dto.IdCondPago;
                    appGeneralQuotesUpdateDto.IdContacto = dto.IdContacto;
                    appGeneralQuotesUpdateDto.IdMtrTipoMoneda = dto.IdMtrTipoMoneda;
                    appGeneralQuotesUpdateDto.OrdenCompra = dto.OrdenCompra;
                    appGeneralQuotesUpdateDto.Observaciones = dto.Observaciones;
                    appGeneralQuotesUpdateDto.UsuarioActualiza = dto.UsuarioActualiza;

                    appGeneralQuotesUpdateDto.FijarPrecioBs = dto.FijarPrecioBs;
                    appGeneralQuotesUpdateDto.Rif = dto.Rif;
                    appGeneralQuotesUpdateDto.RazonSocial = dto.RazonSocial;
                    appGeneralQuotesUpdateDto.Direccion = dto.Direccion;
                    appGeneralQuotesUpdateDto.FechaPostergada = null;
                    appGeneralQuotesUpdateDto.ObservacionPostergar = "";
                    appGeneralQuotesUpdateDto.IdMunicipio = dto.IdMunicipio;
                    var resultUpdate = await UpdateGeneralQuotes(appGeneralQuotesUpdateDto);
                    if (resultUpdate.Meta.IsValid)
                    {
                        GeneralGetDto generalGetDto = new GeneralGetDto();
                        generalGetDto.Id = resultUpdate.Data.Id;
                        generalGetDto.Cotizacion = resultUpdate.Data.Cotizacion;
                        generalGetDto.IdCliente = resultUpdate.Data.IdCliente;
                        generalGetDto.IdDireccionFacturar = resultUpdate.Data.IdDireccionFacturar;
                        generalGetDto.IdDireccionEntregar = resultUpdate.Data.IdDireccionEntregar;
                        generalGetDto.IdCondPago = resultUpdate.Data.IdCondPago;
                        generalGetDto.IdContacto = resultUpdate.Data.IdContacto;
                        generalGetDto.IdMtrTipoMoneda = resultUpdate.Data.IdMtrTipoMoneda;
                        generalGetDto.OrdenCompra = resultUpdate.Data.OrdenCompra;
                        generalGetDto.Observaciones = resultUpdate.Data.Observaciones;

                        generalGetDto.Rif = resultUpdate.Data.Rif;
                        generalGetDto.RazonSocial = resultUpdate.Data.RazonSocial;
                        generalGetDto.Direccion = resultUpdate.Data.Direccion;
                        generalGetDto.IdMunicipio = resultUpdate.Data.IdMunicipio;
                        metadata = resultUpdate.Meta;
                        response.Meta = metadata;
                        response.Data = generalGetDto;
                        return response;
                    }
                    else
                    {
                        metadata = resultUpdate.Meta;
                        response.Meta = metadata;
                        response.Data = null;
                        return response;
                    }

                }
                else//insert
                {
                    AppGeneralQuotesCreateDto appGeneralQuotesCreateDto = new AppGeneralQuotesCreateDto();


                    appGeneralQuotesCreateDto.IdCliente = dto.IdCliente;
                    appGeneralQuotesCreateDto.IdDireccionFacturar = dto.IdDireccionFacturar;
                    appGeneralQuotesCreateDto.IdDireccionEntregar = dto.IdDireccionEntregar;
                    appGeneralQuotesCreateDto.IdCondPago = dto.IdCondPago;
                    appGeneralQuotesCreateDto.IdContacto = dto.IdContacto;
                    appGeneralQuotesCreateDto.IdMtrTipoMoneda = dto.IdMtrTipoMoneda;
                    appGeneralQuotesCreateDto.OrdenCompra = dto.OrdenCompra;
                    appGeneralQuotesCreateDto.Observaciones = dto.Observaciones;
                    appGeneralQuotesCreateDto.UsuarioActualiza = dto.UsuarioActualiza;
                    appGeneralQuotesCreateDto.FijarPrecioBs = dto.FijarPrecioBs;
                    appGeneralQuotesCreateDto.Rif = dto.Rif;
                    appGeneralQuotesCreateDto.RazonSocial = dto.RazonSocial;
                    appGeneralQuotesCreateDto.Direccion = dto.Direccion;
                    appGeneralQuotesCreateDto.IdMunicipio = dto.IdMunicipio;
                    var resultUpdate = await InsertGeneralQuotes(appGeneralQuotesCreateDto);
                    if (resultUpdate.Meta.IsValid)
                    {
                        GeneralGetDto generalGetDto = new GeneralGetDto();
                        generalGetDto.Id = resultUpdate.Data.Id;
                        generalGetDto.Cotizacion = resultUpdate.Data.Cotizacion;
                        generalGetDto.IdCliente = resultUpdate.Data.IdCliente;
                        generalGetDto.IdDireccionFacturar = resultUpdate.Data.IdDireccionFacturar;
                        generalGetDto.IdDireccionEntregar = resultUpdate.Data.IdDireccionEntregar;
                        generalGetDto.IdCondPago = resultUpdate.Data.IdCondPago;
                        generalGetDto.IdContacto = resultUpdate.Data.IdContacto;
                        generalGetDto.IdMtrTipoMoneda = resultUpdate.Data.IdMtrTipoMoneda;
                        generalGetDto.OrdenCompra = resultUpdate.Data.OrdenCompra;
                        generalGetDto.Observaciones = resultUpdate.Data.Observaciones;

                        generalGetDto.Rif = resultUpdate.Data.Rif;
                        generalGetDto.RazonSocial = resultUpdate.Data.RazonSocial;
                        generalGetDto.Direccion = resultUpdate.Data.Direccion;
                        generalGetDto.IdMunicipio = resultUpdate.Data.IdMunicipio;
                        metadata = resultUpdate.Meta;
                        response.Meta = metadata;
                        response.Data = generalGetDto;
                        return response;
                    }
                    else
                    {
                        metadata = resultUpdate.Meta;
                        response.Meta = metadata;
                        response.Data = null;
                        return response;
                    }

                }

            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }

        }



        public async Task<List<string>> GetListCotizaciones()
        {
            return await _unitOfWork.CotizacionRepository.GetListCotizaciones();
        }

    }

}
