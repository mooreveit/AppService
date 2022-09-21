using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy596
    {
        public int IdRegistro { get; set; }
        public int CodigoJde { get; set; }
        public string CodigoInterno { get; set; }
        public string Descripcion { get; set; }
        public decimal PesoKilogramos { get; set; }
        public short IdMedidaLargo { get; set; }
        public short IdMedidaAncho { get; set; }
        public short IdMedidaAltura { get; set; }
        public string FlagInactivo { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime FechaUpdate { get; set; }
    }
}
