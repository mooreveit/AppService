using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry250
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public string ClienteFactur { get; set; }
        public int Cliente { get; set; }
        public string DireccionEmb1 { get; set; }
        public string DireccionEmb2 { get; set; }
        public long NumFaltante { get; set; }
        public long CantidadFalta { get; set; }
        public string CodProducto { get; set; }
        public string NombreForma { get; set; }
        public string OrdenCompra { get; set; }
        public string NombreVendedor { get; set; }
        public long Cantidad { get; set; }
        public short Partes { get; set; }
        public int Basica { get; set; }
        public int Opuesta { get; set; }
        public long CantCaja { get; set; }
        public long NumCaja { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string DireccionEmb3 { get; set; }
    }
}
