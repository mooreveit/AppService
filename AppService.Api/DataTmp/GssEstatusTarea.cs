using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssEstatusTarea
    {
        public GssEstatusTarea()
        {
            GssAprobacionServicios = new HashSet<GssAprobacionServicio>();
        }

        public short IdEstatusTarea { get; set; }
        public string NombreEstatusTarea { get; set; }
        public string Abreviado { get; set; }
        public bool FlagPorAprobar { get; set; }
        public bool FlagAprobada { get; set; }
        public bool FlagPorCoordinar { get; set; }
        public bool FlagAsignado { get; set; }
        public bool FlagEnProceso { get; set; }
        public bool FlagProcesado { get; set; }
        public bool FlagCerrado { get; set; }
        public bool FlagCancelado { get; set; }
        public int IdAreaServicio { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual ICollection<GssAprobacionServicio> GssAprobacionServicios { get; set; }
    }
}
