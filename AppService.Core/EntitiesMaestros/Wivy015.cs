using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy015
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; }
        public int Proveedor { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public int NroReq { get; set; }
        public short ItemRc { get; set; }
        public int NroOc { get; set; }
        public short ItemOc { get; set; }
        public int NroIr { get; set; }
        public decimal CtdRecibida { get; set; }
        public short FormaPago { get; set; }
        public short Mescon { get; set; }
        public decimal BsUnitario { get; set; }
        public decimal DoUnitario { get; set; }
        public string Descripcion1 { get; set; }
    }
}
