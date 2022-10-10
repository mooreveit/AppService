using AppService.Core.Entities;
using System;
using System.Collections.Generic;

namespace AppService.Core.DTOs.Repeticiones
{
    public class ListaRepeticiones
    {
        public List<AppOrdenProductoRepeticionGetDto> AppOrdenProductoRepeticionGetDto { get; set; }
        public List<AppRepeticionClienteProducto> AppRepeticionClienteProducto { get; set; }
        public List<AppRepeticionClienteNombreForma> AppRepeticionClienteNombreForma { get; set; }
        public List<AppRepeticionClienteBasica> AppRepeticionClienteBasica { get; set; }
        public List<AppRepeticionClienteOpuesta> AppRepeticionClienteOpuesta { get; set; }
        public List<AppRepeticionClientePartes> AppRepeticionClientePartes { get; set; }
        public List<AppRepeticionClienteTintas> AppRepeticionClienteTintas { get; set; }
        public List<AppRepeticionClientePapelPrimeraParte> AppRepeticionClientePapelPrimeraParte { get; set; }
        public List<AppRepeticionClientePapelSegundaParte> AppRepeticionClientePapelSegundaParte { get; set; }
        public List<AppRepeticionClientePapelTerceraParte> AppRepeticionClientePapelTerceraParte { get; set; }
        public List<AppRepeticionClientePapelCuartaParte> AppRepeticionClientePapelCuartaParte { get; set; }
        public List<AppRepeticionClientePapelQuintaParte> AppRepeticionClientePapelQuintaParte { get; set; }

    }


    public class AppOrdenProductoRepeticionGetDto
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Orden { get; set; }
        public DateTime Fecha { get; set; }
        public string FechaString { get; set; }
        public int AppproductsId { get; set; }
        public string AppproductsDecription { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }

        public string NombreForma { get; set; }
        public int MedidaBase { get; set; }
        public int MedidaVariable { get; set; }
        public int PartesFormula { get; set; }
        public int CantTintas { get; set; }
        public string PapelPrimeraParte { get; set; }
        public string PapelSegundaParte { get; set; }
        public string PapelTerceraParte { get; set; }
        public string PapelCuartaParte { get; set; }
        public string PapelQuintaParte { get; set; }
        public decimal MedidaBaseDecimal { get; set; }
        public decimal MedidaVariableDecimal { get; set; }
        public string BasicaHumano { get; set; }
        public string OpuestaHumano { get; set; }
        public long? CantidadOrdenada { get; set; }
        public decimal? Millares { get; set; }
        public decimal? PrecioUnitarioUsd { get; set; }
        public decimal? TotalPropuestaUsd { get; set; }

    }



}
