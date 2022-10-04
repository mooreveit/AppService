using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VBacklogPapel
    {
        public long Orden { get; set; }
        public short? Partes { get; set; }
        public string Cliente { get; set; }
        public string IdEstacion { get; set; }
        public string Estacion { get; set; }
        public string Genero { get; set; }
        public string TipoPapel { get; set; }
        public string IdPapel { get; set; }
        public decimal? KilosPapel { get; set; }
        public int Medida { get; set; }
        public decimal? Millares { get; set; }
        public decimal? BsVenta { get; set; }
        public string Linea { get; set; }
        public string Producto { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string JobRetenido { get; set; }
        public string IdEstatusOrden { get; set; }
        public string EstatusOrden { get; set; }
    }
}
