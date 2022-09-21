using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class XlsCuotas
    {
        public int? MesContable { get; set; }
        public int? AnoContable { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public int? CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public string CodigoSupervisor { get; set; }
        public string NombreSupervisor { get; set; }
        public string ProductoMayor { get; set; }
        public int? CuotaVentas { get; set; }
        public string TipoCuota { get; set; }
        public string ProductoCuota { get; set; }
        public int? IdProductoCuota { get; set; }
    }
}
