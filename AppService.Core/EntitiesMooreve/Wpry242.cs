using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry242
    {
        public Wpry242()
        {
            Wpry240 = new HashSet<Wpry240>();
        }

        public int IdConstruccion { get; set; }
        public string NombreConstruccion { get; set; }
        public string Abreviado { get; set; }

        public virtual ICollection<Wpry240> Wpry240 { get; set; }
    }
}
