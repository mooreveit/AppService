using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy013
    {
        public decimal Recnum { get; set; }
        public short Codigo { get; set; }
        public string UnidadDesde { get; set; }
        public string UnidadHasta { get; set; }
        public string Descripcion { get; set; }
        public string Operando { get; set; }
        public decimal Factor { get; set; }
    }
}
