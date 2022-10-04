using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry105
    {
        public decimal Recnum { get; set; }
        public short CodigoMaquina { get; set; }
        public string LineaProd { get; set; }
        public short Anchos { get; set; }
        public string RolloDoblado { get; set; }
        public long Bsxhora { get; set; }
        public int Piesxhora { get; set; }
        public long BsxhoraCon { get; set; }
        public int PiesxhoraCon { get; set; }
        public decimal? HorasXOrden { get; set; }
        public decimal? ObjVelocidad { get; set; }
        public long? Rbsxhora { get; set; }
        public long? RbsxhoraCon { get; set; }
    }
}
