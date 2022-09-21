using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpey223
    {
        public int Recnum { get; set; }
        public long Orden { get; set; }
        public DateTime? Fecha { get; set; }
        public string CodigoProducto { get; set; }
        public short? TipoOrden { get; set; }
        public short? CodigoMaquina { get; set; }
        public string NombreMaquina { get; set; }
        public short? TipoMaquina { get; set; }
        public string NombreTipoMaquina { get; set; }
        public short? NumeroPartes { get; set; }
        public short? Anchos { get; set; }
        public long? FormasRodadas { get; set; }
        public int? Cajas { get; set; }
        public string Usuario { get; set; }
    }
}
