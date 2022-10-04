using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cliente
    {
        public Cliente()
        {
            Cpry012s = new HashSet<Cpry012>();
            Csmy019s = new HashSet<Csmy019>();
        }

        public int Cliente1 { get; set; }

        public virtual ICollection<Cpry012> Cpry012s { get; set; }
        public virtual ICollection<Csmy019> Csmy019s { get; set; }
    }
}
