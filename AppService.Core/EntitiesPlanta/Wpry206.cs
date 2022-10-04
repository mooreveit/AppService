using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry206
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public int Formas { get; set; }
        public string Maq { get; set; }
        public DateTime? Fecha { get; set; }
        public int Nroreo { get; set; }
        public short Mescon { get; set; }
        public short Parte { get; set; }
        public string Doblado { get; set; }
        public string Tipo { get; set; }
        public short Turno { get; set; }
        public long Operador { get; set; }
        public short Producto { get; set; }
        public int PiesRodados { get; set; }
        public int PiesPlan { get; set; }
        public short CodigoOperacio { get; set; }
        public decimal Tiempo { get; set; }
        public short Anchos { get; set; }
    }
}
