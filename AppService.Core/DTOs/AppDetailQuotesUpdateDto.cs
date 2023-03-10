using System;

namespace AppService.Core.DTOs
{
    public class AppDetailQuotesUpdateDto
    {


        public int Id { get; set; }
        public string Producto { get; set; }
        public int IdProducto { get; set; }
        public string NombreComercialProducto { get; set; }
        public int IdEstatus { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadSolicitada { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioUsd { get; set; }
        public decimal TotalUsd { get; set; }
        public int IdUnidad { get; set; }
        public string Observaciones { get; set; }
        public int DiasEntrega { get; set; }
        public string UsuarioConectado { get; set; }
        public decimal PrecioLista { get; set; }
        public int QuantityPerPackage { get; set; }
        public bool SolicitarPrecio { get; set; }
        public string ObsSolicitud { get; set; }


        public decimal? ValorConvertido { get; set; }
        public decimal? UnitPriceBaseProduction { get; set; }
        public decimal? UnitPriceConverted { get; set; }
        public decimal? CantidadPorUnidadProduccion { get; set; }
        public long OrdenAnterior { get; set; }
        public Decimal MedidaBasica { get; set; }

        public Decimal MedidaOpuesta { get; set; }

        public int CalculoId { get; set; }
        public AppConversionUnitGenericCreateDto? AppConversionUnitGenericCreateDto { get; set; }

    }
}
