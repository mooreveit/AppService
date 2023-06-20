using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Guiahist
    {
        public int? Guia { get; set; }
        public decimal? Documento { get; set; }
        public DateTime? Despachada { get; set; }
        public DateTime? Entregada { get; set; }
        public string Hora { get; set; }
        public short? Dias { get; set; }
        public decimal? Orden { get; set; }
        public int? Bultos { get; set; }
        public int? Peso { get; set; }
        public decimal? Flete { get; set; }
        public string Zona { get; set; }
        public string Cliente { get; set; }
        public string Oficina { get; set; }
        public string Status { get; set; }
    }
}
