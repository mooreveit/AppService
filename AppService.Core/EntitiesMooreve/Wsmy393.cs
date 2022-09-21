using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy393
    {
        public decimal IdDoc { get; set; }
        public string Cotizacion { get; set; }
        public int Propuesta { get; set; }
        public int Calculo { get; set; }
        public string Referencia { get; set; }
        public byte[] Blob { get; set; }
        public string NumCot { get; set; }
        public string Diseno { get; set; }
        public string NomArchivo { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public short? Oficina { get; set; }
        public string Vendedor { get; set; }
        public string Usuario { get; set; }
        public string Ubicacion { get; set; }
    }
}
