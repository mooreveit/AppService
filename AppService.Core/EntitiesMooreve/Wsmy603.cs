using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy603
    {
        public long IdRegistro { get; set; }
        public long Orden { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoCaja { get; set; }
        public int CantidadCajasEmpaques { get; set; }
        public int CantidadUnidades { get; set; }
        public decimal LargoEmpaque { get; set; }
        public decimal AltoEmpaque { get; set; }
        public decimal AnchoEmpaque { get; set; }
        public decimal PesoCaja { get; set; }
        public decimal Volumen { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime? FechaUpdate { get; set; }
    }
}
