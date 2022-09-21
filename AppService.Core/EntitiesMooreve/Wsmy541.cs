using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy541
    {
        public Wsmy541()
        {
            Wsmy546 = new HashSet<Wsmy546>();
        }

        public int IdPrograma { get; set; }
        public int IdEstacion { get; set; }
        public string NombreEstacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdUsuarioActualiza { get; set; }

        public virtual ICollection<Wsmy546> Wsmy546 { get; set; }
    }
}
