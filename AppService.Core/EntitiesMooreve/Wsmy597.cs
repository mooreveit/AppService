using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy597
    {
        public short IdRegistro { get; set; }
        public short IdConversionMedida { get; set; }
        public short EnteroFraccion { get; set; }
        public short NumeradorFraccion { get; set; }
        public short DenominadorFraccion { get; set; }
        public decimal MedidaPulgadas { get; set; }
        public decimal MedidaCentimetros { get; set; }
        public string FlagCajas { get; set; }
        public string FlagInactivo { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime FechaUpdate { get; set; }
    }
}
