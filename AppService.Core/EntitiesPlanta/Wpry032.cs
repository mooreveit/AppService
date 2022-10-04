using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry032
    {
        public decimal Recnum { get; set; }
        public short UltProgr { get; set; }
        public short UltAnulacion { get; set; }
        public short UltMotivo { get; set; }
        public decimal MesesBacklogP { get; set; }
        public string PapelPlan { get; set; }
        public string PapelPrel { get; set; }
        public string PapelProg { get; set; }
        public string PapelPren { get; set; }
        public string Clientes { get; set; }
        public string InternasStock { get; set; }
        public string InternasCcs { get; set; }
        public string InternasImp { get; set; }
        public short AnoCerrado { get; set; }
        public short MesCerrado { get; set; }
    }
}
