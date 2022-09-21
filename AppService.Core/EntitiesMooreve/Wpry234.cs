using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry234
    {
        public Wpry234()
        {
            Wpry232 = new HashSet<Wpry232>();
        }

        public short IdSubcategoria { get; set; }
        public short IdCategoria { get; set; }
        public string NombreSubcategoria { get; set; }
        public string FlagEliminado { get; set; }

        public virtual ICollection<Wpry232> Wpry232 { get; set; }
    }
}
