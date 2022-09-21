using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy348
    {
        public decimal IdFile { get; set; }
        public string Cotizacion { get; set; }
        public int Propuesta { get; set; }
        public int Calculo { get; set; }
        public decimal Orden { get; set; }
        public string Archivo { get; set; }
        public string RutaActual { get; set; }
        public DateTime? FechaTrans { get; set; }
        public string HoraTrans { get; set; }
        public string UserDiseno { get; set; }
        public DateTime? FechaTransPre { get; set; }
        public string HoraTrasnPre { get; set; }
        public string NumCot { get; set; }
        public string Vendedor { get; set; }
        public short? Oficina { get; set; }
    }
}
