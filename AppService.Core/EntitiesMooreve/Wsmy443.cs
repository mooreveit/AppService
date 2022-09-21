using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy443
    {
        public decimal IdCuota { get; set; }
        public int? MesContable { get; set; }
        public int? AnoContable { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public short? CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public string CodigoSupervisor { get; set; }
        public string NombreSupervisor { get; set; }
        public string ProductoMayor { get; set; }
        public decimal? CuotaVentas { get; set; }
        public string TipoCuota { get; set; }
        public int? IdProductoCuota { get; set; }
        public int? IdSubCategoria { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? CuotaFinal { get; set; }
        public string TituloOficina { get; set; }
        public string SubCategoria { get; set; }
        public string GerenteOficina { get; set; }
        public decimal? CuotaAcumulada { get; set; }
        public decimal? RcuotaVentas { get; set; }
        public decimal? RcuotaFinal { get; set; }
        public decimal? RcuotaAcumulada { get; set; }
        public decimal CuotaPiesCuadrado { get; set; }
        public decimal CuotaPiesCuadradoFinal { get; set; }
    }
}
