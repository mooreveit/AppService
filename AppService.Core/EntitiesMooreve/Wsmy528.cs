using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy528
    {
        public Wsmy528()
        {
            Wsmy524 = new HashSet<Wsmy524>();
            Wsmy525 = new HashSet<Wsmy525>();
            Wsmy531 = new HashSet<Wsmy531>();
            Wsmy532 = new HashSet<Wsmy532>();
        }

        public decimal Id { get; set; }
        public string TipoLibro { get; set; }
        public string Descripcion { get; set; }
        public string Forecast { get; set; }

        public virtual ICollection<Wsmy524> Wsmy524 { get; set; }
        public virtual ICollection<Wsmy525> Wsmy525 { get; set; }
        public virtual ICollection<Wsmy531> Wsmy531 { get; set; }
        public virtual ICollection<Wsmy532> Wsmy532 { get; set; }
    }
}
