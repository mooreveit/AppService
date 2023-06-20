using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Registro de Compañias
    /// </summary>
    public partial class GssCompañium
    {
        public GssCompañium()
        {
            GssUnidadServicioCompañia = new HashSet<GssUnidadServicioCompañium>();
            GssUsuarioCompañia = new HashSet<GssUsuarioCompañium>();
        }

        public short IdCompañia { get; set; }
        public string NombreCompañia { get; set; }
        public string IdJde { get; set; }
        public bool Activo { get; set; }
        public short IdPais { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssPai IdPaisNavigation { get; set; }
        public virtual ICollection<GssUnidadServicioCompañium> GssUnidadServicioCompañia { get; set; }
        public virtual ICollection<GssUsuarioCompañium> GssUsuarioCompañia { get; set; }
    }
}
