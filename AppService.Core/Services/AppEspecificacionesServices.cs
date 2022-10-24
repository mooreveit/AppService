using AppService.Core.CustomEntities;
using AppService.Core.DTOs.Especificaciones;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
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
    public class AppEspecificacionesServices : IAppEspecificacionesServices
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;


        public AppEspecificacionesServices(IUnitOfWork unitOfWork,
                                     IOptions<PaginationOptions> options,
                                     IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;

        }

        public async Task<ApiResponse<EspecificacionesGetDto>> GetAllFilter(PartesFilter filter)
        {


            EspecificacionesGetDto resultDto = new EspecificacionesGetDto();
            List<PartesGetDto> resultPartesDto = new List<PartesGetDto>();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<EspecificacionesGetDto> response = new ApiResponse<EspecificacionesGetDto>(resultDto);

            try
            {

                AppDetailQuotes appDetailQuotes = await _unitOfWork.AppDetailQuotesRepository.GetById(filter.IdAppDetailQuote);

                List<Wpry240> wpry240 = await _unitOfWork.Wpry240Repository.GetByCotizacion(filter.Cotizacion);

                var appProducts = await _unitOfWork.AppProductsRepository.GetById(appDetailQuotes.IdProducto);

                Wsmy406 aplicacionProducto = await this._unitOfWork.Wsmy406Repository.GetByProduct(appProducts.ExternalCode.Trim());

                if (wpry240 != null && appDetailQuotes != null)
                {

                    foreach (Wpry240 item in wpry240)
                    {

                        PartesGetDto itemPartesGetDto = new PartesGetDto();
                        itemPartesGetDto.Cotizacion = item.Cotizacion;
                        itemPartesGetDto.Renglon = item.Renglon;
                        itemPartesGetDto.Propuesta = item.Propuesta;
                        itemPartesGetDto.IdParte = item.IdParte;
                        itemPartesGetDto.IdPapel = item.IdPapel;



                        if (appDetailQuotes.MedidaBasica > 0)
                        {
                            itemPartesGetDto.MedidaBasica = appDetailQuotes.MedidaBasica.ToString();
                            itemPartesGetDto.MedidaOpuesta = appDetailQuotes.MedidaOpuesta.ToString();

                        }
                        else
                        {
                            var recipeByproductCodeBasica = await _unitOfWork.AppRecipesRepository.GetListRecipesByProductIdVariableCode(filter.IdProducto, "MEDIDABASICA");
                            if (recipeByproductCodeBasica.Count > 0)
                            {
                                var recipe = recipeByproductCodeBasica.FirstOrDefault();
                                itemPartesGetDto.MedidaBasica = recipe.DescriptionSearch;

                            }
                            var recipeByproductCodeOpuesta = await _unitOfWork.AppRecipesRepository.GetListRecipesByProductIdVariableCode(filter.IdProducto, "MEDIDAOPUESTA");
                            if (recipeByproductCodeOpuesta.Count > 0)
                            {
                                var recipe = recipeByproductCodeOpuesta.FirstOrDefault();
                                itemPartesGetDto.MedidaOpuesta = recipe.DescriptionSearch;
                            }


                        }

                        itemPartesGetDto.FrasesMarginales = item.FrasesMarginales;
                        itemPartesGetDto.TipoPapel = item.TipoPapel;
                        itemPartesGetDto.Gramaje = item.Gramaje;


                        List<TintasGetDto> listTintasGetDto = new List<TintasGetDto>();
                        var tintasParte = await _unitOfWork.Wpry241Repository.GetByCotizacionRenglonPropuestaParte(item.Cotizacion, item.Renglon, item.Propuesta, item.IdParte);
                        if (tintasParte.Count > 0)
                        {
                            itemPartesGetDto.TintasFrente = "";
                            itemPartesGetDto.TintasRespaldo = "";
                            foreach (var itemTintas in tintasParte)
                            {
                                TintasGetDto itemTintasGetDto = new TintasGetDto();
                                itemTintasGetDto.Cotizacion = item.Cotizacion;
                                itemTintasGetDto.Renglon = item.Renglon;
                                itemTintasGetDto.Propuesta = item.Propuesta;
                                itemTintasGetDto.IdParte = item.IdParte;
                                itemTintasGetDto.IdUbicacion = itemTintas.IdUbicacion;
                                itemTintasGetDto.IdTinta = itemTintas.IdTinta;
                                listTintasGetDto.Add(itemTintasGetDto);
                                if (itemTintasGetDto.IdUbicacion == 1)
                                {
                                    if (itemPartesGetDto.TintasFrente == "")
                                    {
                                        itemPartesGetDto.TintasFrente = itemTintas.IdTinta;
                                    }
                                    else
                                    {
                                        itemPartesGetDto.TintasFrente = itemPartesGetDto.TintasFrente + ";" + itemTintas.IdTinta;
                                    }

                                }
                                else
                                {
                                    if (itemPartesGetDto.TintasRespaldo == "")
                                    {
                                        itemPartesGetDto.TintasRespaldo = itemTintas.IdTinta;
                                    }
                                    else
                                    {
                                        itemPartesGetDto.TintasRespaldo = itemPartesGetDto.TintasRespaldo + ";" + itemTintas.IdTinta;
                                    }

                                }
                            }


                        }
                        List<PapelesTipoGramaje> papelesValidos = new List<PapelesTipoGramaje>();
                        var wimy001 = await _unitOfWork.Wimy001Repository.GetListByTipoPapelGramaje(item.TipoPapel.Trim(), item.Gramaje.Trim());
                        if (wimy001.Count > 0)
                        {

                            foreach (var itemWimy001 in wimy001)
                            {
                                PapelesTipoGramaje papeleValido = new PapelesTipoGramaje();
                                papeleValido.IdPapel = itemWimy001.Codigo;
                                papeleValido.TipoPapel = item.TipoPapel.Trim();
                                papeleValido.Gramaje = item.Gramaje.Trim();
                                papelesValidos.Add(papeleValido);
                            }

                        }

                        List<AppVariablesEspecificacionesPartesGetDto> appVariablesEspecificacionesPartesGetDto = new List<AppVariablesEspecificacionesPartesGetDto>();

                        var appVariablesEspecificaciones = await _unitOfWork.AppVariablesEspecificacionesPartesRepository.GetByCodAplicacion(aplicacionProducto.CodAplicacion);
                        if (appVariablesEspecificaciones.Count > 0)
                        {
                            foreach (var itemappVariablesEspecificaciones in appVariablesEspecificaciones)
                            {
                                AppVariablesEspecificacionesPartesGetDto itemAppVariablesEspecificacionesPartesGetDto = new AppVariablesEspecificacionesPartesGetDto();
                                itemAppVariablesEspecificacionesPartesGetDto.Id = itemappVariablesEspecificaciones.Id;
                                itemAppVariablesEspecificacionesPartesGetDto.CodAplicacion = itemappVariablesEspecificaciones.CodAplicacion;
                                itemAppVariablesEspecificacionesPartesGetDto.IdVariable = itemappVariablesEspecificaciones.IdVariable;
                                itemAppVariablesEspecificacionesPartesGetDto.NombreVariable = itemappVariablesEspecificaciones.NombreVariable;
                                itemAppVariablesEspecificacionesPartesGetDto.FlagObligatorio = itemappVariablesEspecificaciones.FlagObligatorio;
                                itemAppVariablesEspecificacionesPartesGetDto.FlagGralParte = itemappVariablesEspecificaciones.FlagGralParte;
                                itemAppVariablesEspecificacionesPartesGetDto.Orden = itemappVariablesEspecificaciones.Orden;
                                List<AppValoresVariablesEspecificacionesPartesGetDto> appValoresVariablesEspecificacionesPartesGetDto = new List<AppValoresVariablesEspecificacionesPartesGetDto>();
                                var valores = await _unitOfWork.AppValoresVariablesEspecificacionesPartesRepository.GetListByIdVariable(itemappVariablesEspecificaciones.IdVariable);
                                if (valores.Count > 0)
                                {

                                    foreach (var itemvalores in valores)
                                    {
                                        AppValoresVariablesEspecificacionesPartesGetDto itemAppValoresVariablesEspecificacionesPartesGetDto = new AppValoresVariablesEspecificacionesPartesGetDto();
                                        itemAppValoresVariablesEspecificacionesPartesGetDto.Id = itemvalores.Id;
                                        itemAppValoresVariablesEspecificacionesPartesGetDto.IdVariable = itemvalores.IdVariable;
                                        itemAppValoresVariablesEspecificacionesPartesGetDto.Valor = itemvalores.Valor;
                                        itemAppValoresVariablesEspecificacionesPartesGetDto.FlagMultipleValor = itemvalores.FlagMultipleValor;
                                        var especificacionesParteCotizacion = await _unitOfWork.Wpry251Repository.GetByCotizacionRenglonPropuestaVariableParte(item.Cotizacion, item.Renglon, item.Propuesta, itemvalores.IdVariable, item.IdParte);
                                        if (especificacionesParteCotizacion != null)
                                        {
                                            itemAppValoresVariablesEspecificacionesPartesGetDto.ValorReal = especificacionesParteCotizacion.Valor;
                                        }
                                        else
                                        {
                                            itemAppValoresVariablesEspecificacionesPartesGetDto.ValorReal = "";
                                        }
                                        itemAppValoresVariablesEspecificacionesPartesGetDto.Cheked = true;
                                        if (itemAppValoresVariablesEspecificacionesPartesGetDto.Valor != itemAppValoresVariablesEspecificacionesPartesGetDto.ValorReal)
                                        {
                                            itemAppValoresVariablesEspecificacionesPartesGetDto.ValorReal = "";
                                            itemAppValoresVariablesEspecificacionesPartesGetDto.Cheked = false;
                                        }


                                        appValoresVariablesEspecificacionesPartesGetDto.Add(itemAppValoresVariablesEspecificacionesPartesGetDto);
                                    }
                                    itemAppVariablesEspecificacionesPartesGetDto.AppValoresVariablesEspecificacionesPartesGetDto = appValoresVariablesEspecificacionesPartesGetDto;
                                }
                                appVariablesEspecificacionesPartesGetDto.Add(itemAppVariablesEspecificacionesPartesGetDto);

                            }

                        }

                        itemPartesGetDto.AppVariablesEspecificacionesPartesGetDto = appVariablesEspecificacionesPartesGetDto;
                        itemPartesGetDto.ListTintasGetDto = listTintasGetDto;
                        itemPartesGetDto.PapelesValidos = papelesValidos;
                        resultPartesDto.Add(itemPartesGetDto);
                    }

                    List<TintasValidasGetDto> listTintasValidasGetDto = new List<TintasValidasGetDto>();
                    var tintas = await _unitOfWork.Wpry240Repository.GetListTintasActivas();
                    if (tintas.Count > 0)
                    {
                        foreach (var itemTintas in tintas)
                        {
                            TintasValidasGetDto itemTintasValidasGetDto = new TintasValidasGetDto();
                            itemTintasValidasGetDto.Codigo = itemTintas.Codigo.Trim();
                            listTintasValidasGetDto.Add(itemTintasValidasGetDto);
                        }

                    }


                    List<AppVariablesEspecificacionesGeneralGetDto> appVariablesEspecificacionesGeneralGetDto = new List<AppVariablesEspecificacionesGeneralGetDto>();
                    var appVariablesEspecificacionesGenerales = await _unitOfWork.AppVariablesEspecificacionesPartesRepository.GetByCodAplicacionGeneral(aplicacionProducto.CodAplicacion);
                    if (appVariablesEspecificacionesGenerales.Count > 0)
                    {
                        foreach (var itemappVariablesEspecificaciones in appVariablesEspecificacionesGenerales)
                        {
                            AppVariablesEspecificacionesGeneralGetDto itemAppVariablesEspecificacionesGeneralGetDto = new AppVariablesEspecificacionesGeneralGetDto();
                            itemAppVariablesEspecificacionesGeneralGetDto.Id = itemappVariablesEspecificaciones.Id;
                            itemAppVariablesEspecificacionesGeneralGetDto.CodAplicacion = itemappVariablesEspecificaciones.CodAplicacion;
                            itemAppVariablesEspecificacionesGeneralGetDto.IdVariable = itemappVariablesEspecificaciones.IdVariable;
                            itemAppVariablesEspecificacionesGeneralGetDto.NombreVariable = itemappVariablesEspecificaciones.NombreVariable;
                            itemAppVariablesEspecificacionesGeneralGetDto.FlagObligatorio = itemappVariablesEspecificaciones.FlagObligatorio;
                            itemAppVariablesEspecificacionesGeneralGetDto.FlagGralParte = itemappVariablesEspecificaciones.FlagGralParte;
                            itemAppVariablesEspecificacionesGeneralGetDto.Orden = itemappVariablesEspecificaciones.Orden;
                            List<AppValoresVariablesEspecificacionesGeneralGetDto> listAppValoresVariablesEspecificacionesGeneralGetDto = new List<AppValoresVariablesEspecificacionesGeneralGetDto>();
                            var valores = await _unitOfWork.AppValoresVariablesEspecificacionesPartesRepository.GetListByIdVariable(itemappVariablesEspecificaciones.IdVariable);
                            if (valores.Count > 0)
                            {

                                foreach (var itemvalores in valores)
                                {
                                    AppValoresVariablesEspecificacionesGeneralGetDto itemAppValoresVariablesEspecificacionesGeneralGetDto = new AppValoresVariablesEspecificacionesGeneralGetDto();
                                    itemAppValoresVariablesEspecificacionesGeneralGetDto.Id = itemvalores.Id;
                                    itemAppValoresVariablesEspecificacionesGeneralGetDto.IdVariable = itemvalores.IdVariable;
                                    itemAppValoresVariablesEspecificacionesGeneralGetDto.Valor = itemvalores.Valor;
                                    itemAppValoresVariablesEspecificacionesGeneralGetDto.FlagMultipleValor = itemvalores.FlagMultipleValor;
                                    var especificacionesParteCotizacion = await _unitOfWork.Wpry251Repository.GetByCotizacionRenglonPropuestaVariableParte(filter.Cotizacion, 1, 1, itemvalores.IdVariable, 0);
                                    if (especificacionesParteCotizacion != null)
                                    {
                                        itemAppValoresVariablesEspecificacionesGeneralGetDto.ValorReal = especificacionesParteCotizacion.Valor;
                                    }
                                    else
                                    {
                                        itemAppValoresVariablesEspecificacionesGeneralGetDto.ValorReal = "";
                                    }
                                    itemAppValoresVariablesEspecificacionesGeneralGetDto.Cheked = true;
                                    if (itemAppValoresVariablesEspecificacionesGeneralGetDto.Valor != itemAppValoresVariablesEspecificacionesGeneralGetDto.ValorReal)
                                    {
                                        itemAppValoresVariablesEspecificacionesGeneralGetDto.ValorReal = "";
                                        itemAppValoresVariablesEspecificacionesGeneralGetDto.Cheked = false;
                                    }


                                    listAppValoresVariablesEspecificacionesGeneralGetDto.Add(itemAppValoresVariablesEspecificacionesGeneralGetDto);
                                }
                                itemAppVariablesEspecificacionesGeneralGetDto.AppValoresVariablesEspecificacionesGeneralGetDto = listAppValoresVariablesEspecificacionesGeneralGetDto;
                            }
                            appVariablesEspecificacionesGeneralGetDto.Add(itemAppVariablesEspecificacionesGeneralGetDto);

                        }

                    }
                    resultDto.AppVariablesEspecificacionesGeneralGetDto = appVariablesEspecificacionesGeneralGetDto;

                    resultDto.ListTintasValidasGetDto = listTintasValidasGetDto;
                    resultDto.ListPartesGetDto = resultPartesDto;

                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }
                else
                {

                    metadata.IsValid = true;
                    metadata.Message = "No Data....";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
            }
            catch (Exception ex)
            {


                metadata.IsValid = false;
                //metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }



        }


        public async Task<ApiResponse<EspecificacionesGetDto>> UpdateEspecificaciones(EspecificacionesUpdateDto dto)
        {

            EspecificacionesGetDto resultDto = new EspecificacionesGetDto();
            List<PartesGetDto> resultPartesDto = new List<PartesGetDto>();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<EspecificacionesGetDto> response = new ApiResponse<EspecificacionesGetDto>(resultDto);
            try
            {
                //*********ACTUALIZAMOS LAS CARACTERISTICAS GENERALES***********
                foreach (var item in dto.appVariablesEspecificacionesGeneralGetDto)
                {

                    var especificacionesGenerales = await _unitOfWork.Wpry251Repository.GetListByCotizacionRenglonPropuestaVariableParte(dto.PartesFilter.Cotizacion, dto.PartesFilter.Renglon, dto.PartesFilter.Propuesta, item.IdVariable, 0);
                    if (especificacionesGenerales.Count > 0)
                    {

                        _unitOfWork.Wpry251Repository.DeleteRange(especificacionesGenerales);
                        await _unitOfWork.SaveChangesAsync();
                    }

                    foreach (var itemDetail in item.AppValoresVariablesEspecificacionesGeneralGetDto.Where(x => x.ValorReal.Length > 0).ToList())
                    {


                        Wpry251 wpry251 = new Wpry251();
                        wpry251.Cotizacion = dto.PartesFilter.Cotizacion;
                        wpry251.Renglon = dto.PartesFilter.Renglon;
                        wpry251.Propuesta = dto.PartesFilter.Propuesta;
                        wpry251.IdVariable = itemDetail.IdVariable;
                        wpry251.IdParte = 0;
                        wpry251.Valor = itemDetail.ValorReal;
                        wpry251.FechaRegistro = DateTime.Now;
                        _unitOfWork.Wpry251Repository.Add(wpry251);
                        await _unitOfWork.SaveChangesAsync();

                    }
                }



                foreach (var item in dto.partesGetDto)
                {


                    //*********ACTUALIZAMOS LAS CARACTERISTICAS POR PARTE***********
                    foreach (var itemVariables in item.AppVariablesEspecificacionesPartesGetDto)
                    {
                        var especificacionesGenerales = await _unitOfWork.Wpry251Repository.GetListByCotizacionRenglonPropuestaVariableParte(dto.PartesFilter.Cotizacion, dto.PartesFilter.Renglon, dto.PartesFilter.Propuesta, itemVariables.IdVariable, item.IdParte);
                        if (especificacionesGenerales != null)
                        {

                            _unitOfWork.Wpry251Repository.DeleteRange(especificacionesGenerales);
                            await _unitOfWork.SaveChangesAsync();
                        }
                        foreach (var itemDetail in itemVariables.AppValoresVariablesEspecificacionesPartesGetDto.Where(x => x.ValorReal.Length > 0).ToList())
                        {



                            Wpry251 wpry251 = new Wpry251();
                            wpry251.Cotizacion = dto.PartesFilter.Cotizacion;
                            wpry251.Renglon = dto.PartesFilter.Renglon;
                            wpry251.Propuesta = dto.PartesFilter.Propuesta;
                            wpry251.IdVariable = itemDetail.IdVariable;
                            wpry251.IdParte = item.IdParte;
                            wpry251.Valor = itemDetail.ValorReal;
                            wpry251.FechaRegistro = DateTime.Now;
                            _unitOfWork.Wpry251Repository.Add(wpry251);
                            await _unitOfWork.SaveChangesAsync();

                        }
                    }

                    //*********************ACTUALIZAMOS LOS PAPELES Y TINTAS*****************************

                    var parte = await _unitOfWork.Wpry240Repository.GetByCotizacionRenglonPropuestaParte(item.Cotizacion, item.Renglon, item.Propuesta, item.IdParte);
                    if (parte != null)
                    {

                        parte.IdPapel = item.IdPapel;
                        parte.FrasesMarginales = item.FrasesMarginales;
                        _unitOfWork.Wpry240Repository.Update(parte);
                        await _unitOfWork.SaveChangesAsync();

                        //*************BORRAMOS TODAS LAS TINTAS Y LAS AGREGAMOS NUEVAMENTE**************************************
                        var tintas = await _unitOfWork.Wpry241Repository.GetByCotizacionRenglonPropuestaParte(item.Cotizacion, item.Renglon, item.Propuesta, item.IdParte);
                        if (tintas.Count > 0)
                        {
                            await _unitOfWork.Wpry241Repository.DeleteRange(tintas);
                            await _unitOfWork.SaveChangesAsync();
                        }


                        if (!item.TintasFrenteNew.IsNullOrEmpty())
                        {

                            var lisTintasFrente = item.TintasFrenteNew.Split(';').ToList();
                            foreach (var itemTintaFrente in lisTintasFrente)
                            {
                                Wpry241 wpry241Insert = new Wpry241();
                                wpry241Insert.Cotizacion = item.Cotizacion;
                                wpry241Insert.Renglon = item.Renglon;
                                wpry241Insert.Propuesta = item.Propuesta;
                                wpry241Insert.IdParte = item.IdParte;
                                wpry241Insert.IdUbicacion = 1;
                                wpry241Insert.IdTinta = itemTintaFrente;
                                wpry241Insert.FechaRegistro = DateTime.Now;
                                await _unitOfWork.Wpry241Repository.Add(wpry241Insert);
                                await _unitOfWork.SaveChangesAsync();
                            }
                        }

                        if (!item.TintasRespaldoNew.IsNullOrEmpty())
                        {

                            var lisTintasRespaldo = item.TintasFrenteNew.Split(';').ToList();
                            foreach (var itemTintaRespaldo in lisTintasRespaldo)
                            {
                                Wpry241 wpry241Insert = new Wpry241();
                                wpry241Insert.Cotizacion = item.Cotizacion;
                                wpry241Insert.Renglon = item.Renglon;
                                wpry241Insert.Propuesta = item.Propuesta;
                                wpry241Insert.IdParte = item.IdParte;
                                wpry241Insert.IdUbicacion = 2;
                                wpry241Insert.IdTinta = itemTintaRespaldo;
                                wpry241Insert.FechaRegistro = DateTime.Now;
                                await _unitOfWork.Wpry241Repository.Add(wpry241Insert);
                                await _unitOfWork.SaveChangesAsync();
                            }
                        }
                    }
                }



                var resultado = await GetAllFilter(dto.PartesFilter);
                return resultado;
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
