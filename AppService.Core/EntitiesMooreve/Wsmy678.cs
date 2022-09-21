using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy678
    {
        public short IdSysFile { get; set; }
        public decimal ValorExcesoCobertura { get; set; }
        public decimal ValorExcesoCoberturaGte { get; set; }
        public decimal ValorMaxExcesoCobertura { get; set; }
        public decimal PorcExcesoCuota { get; set; }
        public decimal PorcExcesoCuotaGte { get; set; }
        public int DiasClienteNuevo { get; set; }
        public int DiasClienteReactivado { get; set; }
        public decimal FactorClienteNuevo { get; set; }
        public decimal FactorClienteNuevoGte { get; set; }
        public short CuotaCliente { get; set; }
        public short CuotaClienteGte { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
    }
}
