using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry030
    {
        public decimal Recnum { get; set; }
        public string CodigoProducto { get; set; }
        public int MedidaBasica { get; set; }
        public int MedidaNoBasic { get; set; }
        public short NoDePartes { get; set; }
        public int CantidadMinima { get; set; }
        public short NoColectora { get; set; }
    }
}
