using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Winy242
    {
        public Winy242()
        {
            Winy243 = new HashSet<Winy243>();
        }

        public decimal Recnum { get; set; }
        public string CodigoEstado { get; set; }
        public string NombreEstado { get; set; }
        public string CapitalEstado { get; set; }
        public string CodigoJde { get; set; }
        public string CodigoSap { get; set; }

        public virtual ICollection<Winy243> Winy243 { get; set; }
    }
}
