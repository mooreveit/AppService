using AppService.Core.CustomEntities;
using AppService.Core.DTOs.Especificaciones;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
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
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }



        }



    }
}
