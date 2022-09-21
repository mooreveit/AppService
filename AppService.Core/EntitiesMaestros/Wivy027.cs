using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy027
    {
        public decimal Recnum { get; set; }
        public int NroIr { get; set; }
        public short Item { get; set; }
        public string Codigo { get; set; }
        public int NroReq { get; set; }
        public short ItemRc { get; set; }
        public long NroOc { get; set; }
        public short ItemOc { get; set; }
        public decimal CtdRecibida { get; set; }
        public decimal BsUnitario { get; set; }
        public decimal DoUnitario { get; set; }
        public string Descripcion1 { get; set; }
        public string ProductoCli { get; set; }
    }
}
