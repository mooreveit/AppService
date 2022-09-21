using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wity018
    {
        public Wity018()
        {
            Wity019 = new HashSet<Wity019>();
        }

        public string IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string IdPais { get; set; }
        public string FlagEliminado { get; set; }

        public virtual Wity017 IdPaisNavigation { get; set; }
        public virtual ICollection<Wity019> Wity019 { get; set; }
    }
}
