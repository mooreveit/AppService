using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class ValoresCotizacionDto
    {

        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? TotalPropuesta { get; set; }

        public decimal? PrecioUnitarioUsd { get; set; }
        public decimal? TotalPropuestaUsd { get; set; }

        public float? CantMill { get; set; }
        public decimal? CantFormas { get; set; }



        public decimal? PrecioUnitarioExterno { get; set; }
        public decimal? TotalPropuestaExterno { get; set; }
        public decimal? PrecioUnitarioUsdExterno { get; set; }
        public decimal? TotalPropuestaUsdExterno { get; set; }
        public decimal? CantidadExterno { get; set; }
        public int? IdUnidadExterna { get; set; }
        public string CodeUnidadExterna { get; set; }
        public string DescripcionUnidadExterna { get; set; }
        public decimal? ValorConvertidoExterno { get; set; }
        public decimal? CantidadPorUnidadProduccion { get; set; }
        public decimal? CantidadSolicitadaExterna { get; set; }
        public int? IdUnidadPrecio { get; set; }
        public string CodeUnidaPrecio { get; set; }
        public decimal? CantidadXCaja { get; set; }
        public long? OrdenAnterior { get; set; }


    }
}
