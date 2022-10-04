using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class DetalleBacklogEstacion
    {
        public long Orden { get; set; }
        public long JobId { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estacion { get; set; }
        public string Linea { get; set; }
        public string Familia { get; set; }
        public string Titulo { get; set; }
        public string Prensa { get; set; }
        public string Colectora { get; set; }
        public decimal? CantidadProgramada { get; set; }
        public decimal? Pendiente { get; set; }
        public short? Partes { get; set; }
        public string CodProducto { get; set; }
        public decimal? Pies { get; set; }
        public decimal? Piesxhoramaq { get; set; }
        public decimal? Bsxhoramaq { get; set; }
        public decimal? Horasxturno { get; set; }
        public decimal? Dias { get; set; }
        public string Cliente { get; set; }
        public string IdCalendario { get; set; }
        public long? CantidadEstacion { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioVentaUsd { get; set; }
        public string LineaCalendario { get; set; }
        public string GrupoCalendario { get; set; }
        public decimal? DiasEstacion { get; set; }
        public int Est { get; set; }
    }
}
