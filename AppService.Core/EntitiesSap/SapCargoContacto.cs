using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapCargoContacto
    {
        public SapCargoContacto()
        {
            SapContactos = new HashSet<SapContactos>();
        }

        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<SapContactos> SapContactos { get; set; }
    }
}
