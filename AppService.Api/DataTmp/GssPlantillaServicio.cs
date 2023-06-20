using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Plantilla de Servicio
    /// </summary>
    public partial class GssPlantillaServicio
    {
        public GssPlantillaServicio()
        {
            GssTareaPlantillaServicios = new HashSet<GssTareaPlantillaServicio>();
        }

        public int IdPlantillaServicio { get; set; }
        public int IdServicio { get; set; }
        public int IdVariable { get; set; }
        public string FuncionBusqueda { get; set; }
        public short Secuencia { get; set; }
        public bool Requerido { get; set; }
        public bool Activo { get; set; }
        public bool? OcultaDuplicado { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssServicio IdServicioNavigation { get; set; }
        public virtual GssVariable IdVariableNavigation { get; set; }
        public virtual ICollection<GssTareaPlantillaServicio> GssTareaPlantillaServicios { get; set; }
    }
}
