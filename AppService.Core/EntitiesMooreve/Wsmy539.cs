using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy539
    {
        public decimal IdPronostico { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string IdVendedor { get; set; }
        public int IdProductoCuota { get; set; }
        public decimal Monto { get; set; }
        public short IdOficina { get; set; }
        public string IdSupervisor { get; set; }
        public string IdGerente { get; set; }
        public int IdRuta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string IdUsuarioActualiza { get; set; }

        public virtual Wsmy540 IdRutaNavigation { get; set; }
    }
}
