using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AprobacionesServices : IAprobacionesServices
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;


        public AprobacionesServices(IUnitOfWork unitOfWork,
                                     IOptions<PaginationOptions> options,
                                     IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;

        }


        public async Task<Wsmy639> GetByCotizacionRenglonPrpopuesta(string cotizacion, int renglon, int propuesta)
        {
            return await _unitOfWork.AprobacionesRepository.GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);
        }



        public async Task<ApiResponse<Wsmy639>> CreateAprobacion(string cotizacion, int renglon, int propuesta, string usuarioConectado)
        {

            Wsmy639 resultDto = new Wsmy639();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<Wsmy639> response = new ApiResponse<Wsmy639>(resultDto);
            try
            {
                var cotizacionObject = await _unitOfWork.CotizacionRepository.GetByCotizacion(cotizacion);

                var renglonObject = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(cotizacion, renglon);

                var propuestaObject = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);


                var inserted = await _unitOfWork.AprobacionesRepository.CreaAprobacion(cotizacion, renglon, propuesta, usuarioConectado);


                metadata.IsValid = true;
                metadata.Message = "Solicitud Creada !!";
                response.Data = inserted;
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

        public async Task<ApiResponse<Wsmy639>> CreateAprobacionold(string cotizacion, int renglon, int propuesta, string UsuarioConectado)
        {

            Wsmy639 resultDto = new Wsmy639();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<Wsmy639> response = new ApiResponse<Wsmy639>(resultDto);
            try
            {
                var cotizacionObject = await _unitOfWork.CotizacionRepository.GetByCotizacion(cotizacion);

                var renglonObject = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(cotizacion, renglon);

                var propuestaObject = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);





                var aprobacion = await GetByCotizacionRenglonPrpopuesta(cotizacion, renglon, propuesta);
                if (aprobacion != null)
                {
                    await _unitOfWork.AprobacionesRepository.Delete(aprobacion.Id);
                    await _unitOfWork.SaveChangesAsync();
                }
                //Flujo Aprobación CYPJ = 1
                var IdTipoFlujo = 1;

                Wsmy639 newAprobacion = new Wsmy639();

                var controlCalculo = await _unitOfWork.TEnControlCalculoRepository.GetFirst();
                var idSolicitud = controlCalculo.IdSolicitud + 1;
                controlCalculo.IdSolicitud = idSolicitud;
                _unitOfWork.TEnControlCalculoRepository.Update(controlCalculo);
                await _unitOfWork.SaveChangesAsync();



                // propuestaObject.IdSolicitud = idSolicitud.ToString();
                //_unitOfWork.PropuestaRepository.Update(propuestaObject);


                //await _unitOfWork.SaveChangesAsync();

                newAprobacion.IdSolicitud = idSolicitud;

                newAprobacion.IdUsuario = cotizacionObject.CodVendedor;

                newAprobacion.IdUsuarioApp = UsuarioConectado;

                newAprobacion.IdCliente = cotizacionObject.CodCliente;

                newAprobacion.RazonSocial = cotizacionObject.RazonSocial;

                newAprobacion.Rif = cotizacionObject.Rif;

                newAprobacion.IdProducto = renglonObject.CodProducto;

                newAprobacion.Millares = (decimal)propuestaObject.CantMill;

                newAprobacion.ValorVentaUsd = (decimal)propuestaObject.PrecioUnitarioUsd;

                newAprobacion.ValorVenta = (decimal)propuestaObject.PrecioUnitario;

                newAprobacion.TotalVentaUsd = propuestaObject.TotalPropuestaUsd;

                newAprobacion.TotalVenta = propuestaObject.TotalPropuesta;

                newAprobacion.NombreForma = renglonObject.Descripcion;

                newAprobacion.FlagAprobado = false;


                DateTime dt = DateTime.Now;

                newAprobacion.FechaRegistro = dt;

                newAprobacion.Ano = (short)dt.Year;

                newAprobacion.Mes = (short)dt.Month;

                newAprobacion.RecalcularMargen = "";

                newAprobacion.Duracion = 0;

                newAprobacion.PorcRespSocial = propuestaObject.PorcRespSocial;

                newAprobacion.PorcComRegulada = propuestaObject.PorcComRegulada;

                newAprobacion.PorcMcMinimo = propuestaObject.PorcMcMinimo;

                newAprobacion.PorcTolerancia = propuestaObject.PorcTolerancia;

                newAprobacion.Observaciones = "";

                newAprobacion.Cotizacion = cotizacion;

                newAprobacion.Renglon = renglon;

                newAprobacion.Propuesta = propuesta;

                newAprobacion.FlagEnviado = false;

                newAprobacion.FlagCerrado = false;

                newAprobacion.FlagAprobado = false;




                newAprobacion.IdFlujo = (short)IdTipoFlujo;

                newAprobacion.FlagVolumen = false;

                newAprobacion.IdTablaCpj = 155;

                newAprobacion.PorcCpj = propuestaObject.PorcCpj;

                newAprobacion.BsListaCpj = propuestaObject.BsListaCpj;

                newAprobacion.BsListaCpjminimo = propuestaObject.BsListaCpjminimo;
                newAprobacion.UsdListaCpjminimo = propuestaObject.UsdListaCpjminimo;

                newAprobacion.FlagTipoRechazo = propuestaObject.FlagTipoRechazo;

                newAprobacion.TotalBsListaCpjminimo = propuestaObject.TotalBsListaCpjminimo;
                newAprobacion.TotalUsdListaCpjminimo = propuestaObject.TotalUsdListaCpjminimo;

                newAprobacion.TotalBsListaCpj = propuestaObject.TotalBsListaCpj;
                newAprobacion.TotalUsdListaCpj = propuestaObject.TotalUsdListaCpj;

                newAprobacion.PorcLista = propuestaObject.PorcLista;


                newAprobacion.BsListaCpjminimo = propuestaObject.BsListaCpjminimo;
                newAprobacion.TotalBsListaCpjminimo = propuestaObject.TotalBsListaCpjminimo;



                //****** Campos Usd
                newAprobacion.ValorVentaUsd = (decimal)propuestaObject.PrecioUnitarioUsd;

                newAprobacion.TotalVentaUsd = propuestaObject.TotalPropuestaUsd;

                newAprobacion.UsdListaCpj = propuestaObject.UsdListaCpj;

                newAprobacion.UsdListaCpjminimo = propuestaObject.UsdListaCpjminimo;

                newAprobacion.TotalUsdListaCpjminimo = propuestaObject.TotalUsdListaCpjminimo;

                newAprobacion.TotalUsdListaCpj = propuestaObject.TotalUsdListaCpj;

                newAprobacion.FijarPrecioBs = cotizacionObject.FijarPrecioBs;

                newAprobacion.FijarPrecioBsAprobado = cotizacionObject.FijarPrecioBsAprobado;

                await _unitOfWork.AprobacionesRepository.Add(newAprobacion);
                await _unitOfWork.SaveChangesAsync();

                var inserted = await _unitOfWork.AprobacionesRepository.GetById(newAprobacion.Id);



                metadata.IsValid = true;
                metadata.Message = "Solicitud Creada !!";
                response.Data = inserted;
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




        public async Task<ApiResponse<Wsmy639>> CreateAprobacionAprobada(string cotizacion, int renglon, int propuesta, string usuarioConectado)
        {

            Wsmy639 resultDto = new Wsmy639();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<Wsmy639> response = new ApiResponse<Wsmy639>(resultDto);
            try
            {
                var cotizacionObject = await _unitOfWork.CotizacionRepository.GetByCotizacion(cotizacion);

                var renglonObject = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(cotizacion, renglon);

                var propuestaObject = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);

                var inserted = await _unitOfWork.AprobacionesRepository.CreaAprobacionAprobada(cotizacion, renglon, propuesta, usuarioConectado);



                metadata.IsValid = true;
                metadata.Message = "Solicitud Creada !!";
                response.Data = inserted;
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

        public async Task<ApiResponse<Wsmy639>> CreateAprobacionAprobadaOld(string cotizacion, int renglon, int propuesta, string UsuarioConectado)
        {

            Wsmy639 resultDto = new Wsmy639();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<Wsmy639> response = new ApiResponse<Wsmy639>(resultDto);
            try
            {
                var cotizacionObject = await _unitOfWork.CotizacionRepository.GetByCotizacion(cotizacion);

                var renglonObject = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(cotizacion, renglon);

                var propuestaObject = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);

                var aprobacion = await GetByCotizacionRenglonPrpopuesta(cotizacion, renglon, propuesta);
                if (aprobacion != null)
                {
                    await _unitOfWork.AprobacionesRepository.Delete(aprobacion.Id);
                    await _unitOfWork.SaveChangesAsync();
                }
                //Flujo Aprobación CYPJ = 1
                var IdTipoFlujo = 1;

                Wsmy639 newAprobacion = new Wsmy639();


                var controlCalculo = await _unitOfWork.TEnControlCalculoRepository.GetFirst();
                var idSolicitud = controlCalculo.IdSolicitud + 1;
                controlCalculo.IdSolicitud = idSolicitud;
                _unitOfWork.TEnControlCalculoRepository.Update(controlCalculo);
                await _unitOfWork.SaveChangesAsync();


                propuestaObject.IdSolicitud = idSolicitud.ToString();
                _unitOfWork.PropuestaRepository.Update(propuestaObject);



                //await _unitOfWork.SaveChangesAsync();

                newAprobacion.IdSolicitud = idSolicitud;

                newAprobacion.IdUsuario = cotizacionObject.CodVendedor;

                newAprobacion.IdUsuarioApp = UsuarioConectado;

                newAprobacion.IdCliente = cotizacionObject.CodCliente;

                newAprobacion.RazonSocial = cotizacionObject.RazonSocial;

                newAprobacion.Rif = cotizacionObject.Rif;

                newAprobacion.IdProducto = renglonObject.CodProducto;

                newAprobacion.Millares = (decimal)propuestaObject.CantMill;

                newAprobacion.ValorVentaUsd = (decimal)propuestaObject.PrecioUnitarioUsd;

                newAprobacion.ValorVenta = (decimal)propuestaObject.PrecioUnitario;

                newAprobacion.TotalVentaUsd = propuestaObject.TotalPropuestaUsd;

                newAprobacion.TotalVenta = propuestaObject.TotalPropuesta;

                newAprobacion.NombreForma = renglonObject.Descripcion;




                DateTime dt = DateTime.Now;

                newAprobacion.FechaRegistro = dt;

                newAprobacion.Ano = (short)dt.Year;

                newAprobacion.Mes = (short)dt.Month;

                newAprobacion.RecalcularMargen = "";

                newAprobacion.Duracion = 0;

                newAprobacion.PorcRespSocial = propuestaObject.PorcRespSocial;

                newAprobacion.PorcComRegulada = propuestaObject.PorcComRegulada;

                newAprobacion.PorcMcMinimo = propuestaObject.PorcMcMinimo;

                newAprobacion.PorcTolerancia = propuestaObject.PorcTolerancia;

                newAprobacion.Observaciones = "";

                newAprobacion.Cotizacion = cotizacion;

                newAprobacion.Renglon = renglon;

                newAprobacion.Propuesta = propuesta;

                newAprobacion.FlagAprobado = true;

                newAprobacion.FlagEnviado = true;

                newAprobacion.FlagCerrado = true;

                newAprobacion.IdFlujo = (short)IdTipoFlujo;

                newAprobacion.ValorVentaAprobarUsd = propuestaObject.PrecioUnitarioUsdExterno;

                newAprobacion.FlagVolumen = false;

                newAprobacion.IdTablaCpj = 155;

                newAprobacion.PorcCpj = propuestaObject.PorcCpj;

                newAprobacion.BsListaCpj = propuestaObject.BsListaCpj;

                newAprobacion.BsListaCpjminimo = propuestaObject.BsListaCpjminimo;
                newAprobacion.UsdListaCpjminimo = propuestaObject.UsdListaCpjminimo;

                newAprobacion.FlagTipoRechazo = propuestaObject.FlagTipoRechazo;

                newAprobacion.TotalBsListaCpjminimo = propuestaObject.TotalBsListaCpjminimo;
                newAprobacion.TotalUsdListaCpjminimo = propuestaObject.TotalUsdListaCpjminimo;

                newAprobacion.TotalBsListaCpj = propuestaObject.TotalBsListaCpj;
                newAprobacion.TotalUsdListaCpj = propuestaObject.TotalUsdListaCpj;

                newAprobacion.PorcLista = propuestaObject.PorcLista;


                newAprobacion.BsListaCpjminimo = propuestaObject.BsListaCpjminimo;
                newAprobacion.TotalBsListaCpjminimo = propuestaObject.TotalBsListaCpjminimo;



                //****** Campos Usd
                newAprobacion.ValorVentaUsd = (decimal)propuestaObject.PrecioUnitarioUsd;

                newAprobacion.TotalVentaUsd = propuestaObject.TotalPropuestaUsd;

                newAprobacion.UsdListaCpj = propuestaObject.UsdListaCpj;

                newAprobacion.UsdListaCpjminimo = propuestaObject.UsdListaCpjminimo;

                newAprobacion.TotalUsdListaCpjminimo = propuestaObject.TotalUsdListaCpjminimo;

                newAprobacion.TotalUsdListaCpj = propuestaObject.TotalUsdListaCpj;

                newAprobacion.FijarPrecioBs = cotizacionObject.FijarPrecioBs;

                newAprobacion.FijarPrecioBsAprobado = cotizacionObject.FijarPrecioBsAprobado;

                await _unitOfWork.AprobacionesRepository.Add(newAprobacion);
                await _unitOfWork.SaveChangesAsync();

                var inserted = await _unitOfWork.AprobacionesRepository.GetById(newAprobacion.Id);
                metadata.IsValid = true;
                metadata.Message = "Solicitud Creada !!";
                response.Data = inserted;
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



        public async Task<ApiResponse<Wsmy647>> ActivarWORKFLOW(string cotizacion, int renglon, int propuesta, string usuarioConectado, AppDetailQuotes appDetailQuotes)
        {



            Wsmy647 resultDto = new Wsmy647();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<Wsmy647> response = new ApiResponse<Wsmy647>(resultDto);
            try
            {


                // HdId.Value IdSoicitud wsmy515, 



                // HdRuta.Value
                // HdRuta.Value = Wsmy649.BuscarRuta(HdSubCategoria.Value, HdIdOficina.Value)

                //HdIdNextEst.Value
                //Wsmy649.BuscarAprobador(HdRuta.Value, HdSubCategoria.Value, HdIdOficina.Value, PuntosPorcDebajo, PuntosPorcArriba)
                //IdEstacion

                var cotizacionObject = await _unitOfWork.CotizacionRepository.GetByCotizacion(cotizacion);
                usuarioConectado = cotizacionObject.CodVendedor;
                var renglonObject = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(cotizacion, renglon);

                var propuestaObject = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);

                var cliente = _unitOfWork.MtrClienteRepository.GetById(cotizacionObject.CodCliente);

                var producto = await _unitOfWork.Csmy036Repository.GetByCode(renglonObject.CodProducto);

                var vendedorObject = await _unitOfWork.MtrVendedorRepository.GetByIdAsync(cotizacionObject.CodVendedor);

                var ruta = await _unitOfWork.Wsmy649Repository.BuscarRuta((short)producto.Idsubcategoria, vendedorObject.Oficina);

                var idEstacion = await _unitOfWork.Wsmy649Repository.BuscarAprobador((short)producto.Idsubcategoria, vendedorObject.Oficina, ruta.IdRuta);



                var aprobacion = await GetByCotizacionRenglonPrpopuesta(cotizacion, renglon, propuesta);
                if (aprobacion == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "No se Creo la solicitud!!";
                    response.Data = null;
                    response.Meta = metadata;

                    return response;
                }
                //Flujo Aprobación CYPJ = 1
                var IdTipoFlujo = 1;


                var wsmy647 = await _unitOfWork.Wsmy647Repository.Get(aprobacion.Id, ruta.IdRuta, idEstacion);
                if (wsmy647 == null)
                {

                    //AGREGAMOS LAS OBSERVACIONES
                    Wsmy655 wsmy655New = new Wsmy655();

                    wsmy655New.IdCalculo = aprobacion.Id;

                    wsmy655New.IdEstacion = short.Parse(idEstacion.ToString());

                    wsmy655New.IdUsuario = usuarioConectado;

                    if (appDetailQuotes.ObsSolicitud == null)
                    {
                        appDetailQuotes.ObsSolicitud = "";

                    }

                    wsmy655New.Observaciones = appDetailQuotes.ObsSolicitud;

                    wsmy655New.Fecha = DateTime.Now;

                    await _unitOfWork.Wsmy655Repository.Add(wsmy655New);

                    await _unitOfWork.SaveChangesAsync();



                    Wsmy647 wsmy647New = new Wsmy647();

                    wsmy647New.IdCalculo = aprobacion.Id;

                    wsmy647New.IdRuta = ruta.IdRuta;

                    wsmy647New.IdEstacion = short.Parse(idEstacion.ToString());

                    wsmy647New.IdUsuario = usuarioConectado;

                    var wsmy645 = await _unitOfWork.Wsmy645Repository.EstatusPendiente();

                    wsmy647New.IdEstatus = wsmy645.IdEstatus;

                    wsmy647New.FechaEntrada = DateTime.Now;

                    await _unitOfWork.Wsmy647Repository.Add(wsmy647New);
                    await _unitOfWork.SaveChangesAsync();


                    //ACTUALIZAMOS SOLICITUD

                    var solicitud = await _unitOfWork.AprobacionesRepository.GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);

                    solicitud.FlagEnviado = true;
                    _unitOfWork.AprobacionesRepository.Update(solicitud);
                    await _unitOfWork.SaveChangesAsync();



                    metadata.IsValid = true;
                    metadata.Message = "Solicitud enviada con éxito!!";
                    response.Data = null;
                    response.Meta = metadata;

                    return response;

                }
                else
                {

                    wsmy647.IdCalculo = aprobacion.Id;

                    //AGREGAMOS LAS OBSERVACIONES
                    Wsmy655 wsmy655New = new Wsmy655();

                    wsmy655New.IdCalculo = aprobacion.Id;

                    wsmy655New.IdEstacion = short.Parse(idEstacion.ToString());

                    wsmy655New.IdUsuario = usuarioConectado;


                    if (appDetailQuotes.ObsSolicitud == null)
                    {
                        appDetailQuotes.ObsSolicitud = "";
                    }
                    wsmy655New.Observaciones = appDetailQuotes.ObsSolicitud;

                    wsmy655New.Fecha = DateTime.Now;

                    await _unitOfWork.Wsmy655Repository.Add(wsmy655New);

                    await _unitOfWork.SaveChangesAsync();



                    metadata.IsValid = true;
                    metadata.Message = "Solicitud enviada con éxito!!";
                    response.Data = null;
                    response.Meta = metadata;

                    return response;

                }






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
