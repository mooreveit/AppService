using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssPai
    {
        public GssPai()
        {
            GssCompañia = new HashSet<GssCompañium>();
        }

        public short IdPais { get; set; }
        public string NombrePais { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual ICollection<GssCompañium> GssCompañia { get; set; }
    }
}
