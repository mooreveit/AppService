using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy545
    {
        public decimal Id { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string IdVendedor { get; set; }
        public int IdEstacion { get; set; }
        public string IdEstatus { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Observacion { get; set; }

        public virtual Wity021 UsuarioNavigation { get; set; }
    }
}
