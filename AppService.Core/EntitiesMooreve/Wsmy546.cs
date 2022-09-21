using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy546
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string IdVendedor { get; set; }
        public int IdRuta { get; set; }
        public int IdEstacion { get; set; }
        public int Secuencia { get; set; }
        public int IdRol { get; set; }
        public string IdEstatus { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Wsmy541 IdEstacionNavigation { get; set; }
        public virtual Wsmy544 IdEstatusNavigation { get; set; }
        public virtual Wsmy540 IdRutaNavigation { get; set; }
    }
}
