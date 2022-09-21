using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy373
    {
        public Wsmy373()
        {
            Wsmy260 = new HashSet<Wsmy260>();
        }

        public decimal Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Wsmy260> Wsmy260 { get; set; }
    }
}
