using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry080
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public string Archivo { get; set; }
        public short Nulos { get; set; }
        public string Cliente { get; set; }
        public short CabezalesMax { get; set; }
        public short Partes { get; set; }
        public short Digitos { get; set; }
        public string PrefijoNum { get; set; }
        public long ValorInicial { get; set; }
        public short RolloInicial { get; set; }
        public long ValorFinal { get; set; }
        public long FormasRollo { get; set; }
        public string Texto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModif { get; set; }
        public short Separacion { get; set; }
        public string Literal { get; set; }
        public string Posicion { get; set; }
    }
}
