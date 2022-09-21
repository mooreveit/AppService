using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy031bk
    {
        public decimal Recnum { get; set; }
        public int NroIr { get; set; }
        public short Item { get; set; }
        public short Mayor { get; set; }
        public short Auxiliar { get; set; }
        public int Ccosto { get; set; }
        public decimal MontoDebito { get; set; }
        public decimal MontoCredito { get; set; }
        public string TipoAplicar { get; set; }
        public int NumeroAplicar { get; set; }
        public string Concepto { get; set; }
        public short ItemIr { get; set; }
        public decimal CtdRecibida { get; set; }
        public long NroOc { get; set; }
        public long TipoPago { get; set; }
        public string CodContrapart { get; set; }
    }
}
