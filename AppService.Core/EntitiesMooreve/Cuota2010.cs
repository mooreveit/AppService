using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cuota2010
    {
        public decimal? MesContable { get; set; }
        public decimal? AñoContable { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public short? CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public string CodigoSupervisor { get; set; }
        public string NombreSupervisor { get; set; }
        public string ProductoMayor { get; set; }
        public decimal? CuotaVentas { get; set; }
        public string TipoCuota { get; set; }
        public string ProductoCuota { get; set; }
        public int? IdProductoCuota { get; set; }
        public decimal? RcuotaVentas { get; set; }
    }
}
