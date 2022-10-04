using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry205
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public string Producto { get; set; }
        public short Partes { get; set; }
        public short Parte { get; set; }
        public string Metodo { get; set; }
        public string Papel { get; set; }
        public long CantidadC { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal ValorLista { get; set; }
        public string FlagEmbarque { get; set; }
        public string FlagColectora { get; set; }
        public string FlagAcabado { get; set; }
        public string Linea { get; set; }
        public short TipoProducto { get; set; }
        public decimal Porcterminacion { get; set; }
        public DateTime? NuevaFechaEnt { get; set; }
        public long CantidadE { get; set; }
        public long CantidadA { get; set; }
        public decimal? RprecioLista { get; set; }
        public decimal? RvalorLista { get; set; }
    }
}
