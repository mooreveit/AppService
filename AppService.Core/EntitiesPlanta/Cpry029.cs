using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry029
    {
        public decimal Recnum { get; set; }
        public string CodigoProducto { get; set; }
        public int MedidaBasica { get; set; }
        public int MedidaNoBasic { get; set; }
        public short CantidadTintas { get; set; }
        public short NoDePartes { get; set; }
        public int CantidadMillar { get; set; }
        public short NoPrensa { get; set; }
    }
}
