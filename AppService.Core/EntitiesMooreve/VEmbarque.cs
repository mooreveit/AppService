using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VEmbarque
    {
        public long? Orden { get; set; }
        public long? Job { get; set; }
        public int Documento { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Venta { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tipo { get; set; }
        public int Docafecta { get; set; }
        public decimal? Copy { get; set; }
    }
}
