using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy672
    {
        public decimal Recnum { get; set; }
        public int IdCuota { get; set; }
        public decimal Porcentaje { get; set; }
        public string UsuarioCrea { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public short Orden { get; set; }
    }
}
