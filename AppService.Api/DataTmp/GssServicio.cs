using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Servicios Disponibles
    /// </summary>
    public partial class GssServicio
    {
        public GssServicio()
        {
            GssPlantillaServicios = new HashSet<GssPlantillaServicio>();
            GssServicioNivels = new HashSet<GssServicioNivel>();
            GssTareas = new HashSet<GssTarea>();
            GssUsuarioPlantillaServicios = new HashSet<GssUsuarioPlantillaServicio>();
        }

        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public int IdTipoServicio { get; set; }
        public bool Activo { get; set; }
        public bool FlagCoordinado { get; set; }
        public bool FlagAdjunto { get; set; }
        public bool? FlagControlNomina { get; set; }
        public string FormatoReporte { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssTipoServicio IdTipoServicioNavigation { get; set; }
        public virtual ICollection<GssPlantillaServicio> GssPlantillaServicios { get; set; }
        public virtual ICollection<GssServicioNivel> GssServicioNivels { get; set; }
        public virtual ICollection<GssTarea> GssTareas { get; set; }
        public virtual ICollection<GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicios { get; set; }
    }
}
