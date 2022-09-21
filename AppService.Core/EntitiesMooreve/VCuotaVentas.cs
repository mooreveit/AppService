using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VCuotaVentas
    {
        public decimal? MesContable { get; set; }
        public decimal? AnoContable { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public short? CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public decimal? CuotaProductoMayor { get; set; }
        public string ProductoMayor { get; set; }
    }
}
