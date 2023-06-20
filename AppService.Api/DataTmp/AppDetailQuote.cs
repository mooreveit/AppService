using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppDetailQuote
    {
        public AppDetailQuote()
        {
            AppDetailQuotesConversionUnits = new HashSet<AppDetailQuotesConversionUnit>();
        }

        public int Id { get; set; }
        public int AppGeneralQuotesId { get; set; }
        public string Cotizacion { get; set; }
        public string Producto { get; set; }
        public int IdProducto { get; set; }
        public string NombreComercialProducto { get; set; }
        public int IdEstatus { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioUsd { get; set; }
        public decimal TotalUsd { get; set; }
        public int IdUnidad { get; set; }
        public string Observaciones { get; set; }
        public int DiasEntrega { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? ValorConvertido { get; set; }
        public decimal? UnitPriceBaseProduction { get; set; }
        public decimal? UnitPriceConverted { get; set; }
        public int? RazonGanadaPerdida { get; set; }
        public int? Competidor { get; set; }
        public int? QuantityPerPackage { get; set; }
        public string ObsSolicitud { get; set; }
        public decimal? CantidadSolicitada { get; set; }
        public decimal? CantidadPorUnidadProduccion { get; set; }
        public bool? SolicitarPrecio { get; set; }
        public decimal? Rprecio { get; set; }
        public decimal? Rtotal { get; set; }
        public int? CalculoId { get; set; }
        public decimal? MedidaBasica { get; set; }
        public decimal? MedidaOpuesta { get; set; }
        public long? Orden { get; set; }
        public int? OdooId { get; set; }
        public long? OrdenAnterior { get; set; }
        public string Papeles { get; set; }
        public string Tintas { get; set; }
        public string Medidas { get; set; }
        public int? CantPartes { get; set; }
        public int? CantTintas { get; set; }
        public string TipoPapeles { get; set; }
        public decimal? PorcIva { get; set; }
        public decimal? Iva { get; set; }
        public decimal? TotalConIva { get; set; }

        public virtual AppGeneralQuote AppGeneralQuotes { get; set; }
        public virtual AppStatusQuote IdEstatusNavigation { get; set; }
        public virtual AppProduct IdProductoNavigation { get; set; }
        public virtual AppUnit IdUnidadNavigation { get; set; }
        public virtual ICollection<AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnits { get; set; }
    }
}
