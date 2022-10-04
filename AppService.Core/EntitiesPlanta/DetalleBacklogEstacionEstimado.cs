using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class DetalleBacklogEstacionEstimado
    {
        public decimal Id { get; set; }
        public string Origen { get; set; }
        public decimal? FechaEstimacionJuliana { get; set; }
        public DateTime? FechaEstimacion { get; set; }
        public string Cotizacion { get; set; }
        public long? Orden { get; set; }
        public long? JobId { get; set; }
        public DateTime? FechaEntrega { get; set; }
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
        public string LineaCalendario { get; set; }
        public string GrupoCalendario { get; set; }
        public decimal? DiasEstacion { get; set; }
        public int Est { get; set; }
        public int? CantHorasCadaTurno { get; set; }
        public int? CantTurnosMaquina { get; set; }
        public int? DiasPeriodo { get; set; }
        public decimal? FechaUltimaProduccionMes { get; set; }
        public string Papel { get; set; }
        public decimal? AñoMesUltimaProduccion { get; set; }
        public decimal? AñoMesEntrega { get; set; }
        public string Estatus { get; set; }
        public decimal? AñoMesEstimacion { get; set; }
        public decimal? Rbsxhoramaq { get; set; }
        public decimal? RprecioVenta { get; set; }
    }
}
