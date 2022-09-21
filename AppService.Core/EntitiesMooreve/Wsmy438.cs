using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy438
    {
        public Wsmy438()
        {
            Auxiliarcuota = new HashSet<Auxiliarcuota>();
            InverseIdCuotaPadreNavigation = new HashSet<Wsmy438>();
            Wsmy437 = new HashSet<Wsmy437>();
        }

        public int IdProductoCuota { get; set; }
        public string Descripcion { get; set; }
        public byte? IdReporte { get; set; }
        public int IdCuotaPadre { get; set; }

        public virtual Wsmy438 IdCuotaPadreNavigation { get; set; }
        public virtual ICollection<Auxiliarcuota> Auxiliarcuota { get; set; }
        public virtual ICollection<Wsmy438> InverseIdCuotaPadreNavigation { get; set; }
        public virtual ICollection<Wsmy437> Wsmy437 { get; set; }
    }
}
