using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry066
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public long CtdProgramada { get; set; }
        public long CtdFacturada { get; set; }
        public long CtdDespachada { get; set; }
        public long CtdEstacion { get; set; }
        public string Prensa { get; set; }
        public string Colectora { get; set; }
        public string AreaActual { get; set; }
        public decimal VentaTotal { get; set; }
        public decimal ListaTotal { get; set; }
        public short DiasAtraso { get; set; }
        public DateTime? FechaProgramad { get; set; }
        public string Retenido { get; set; }
        public string NombreForma { get; set; }
        public string CteFacturar { get; set; }
        public int Cliente { get; set; }
        public string PlantaFactura { get; set; }
        public string Cotizacion { get; set; }
        public string Vendedor { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public decimal Concesion { get; set; }
        public string Dolares { get; set; }
        public DateTime? FechaFactura { get; set; }
        public decimal? RventaTotal { get; set; }
        public decimal? RlistaTotal { get; set; }
    }
}
