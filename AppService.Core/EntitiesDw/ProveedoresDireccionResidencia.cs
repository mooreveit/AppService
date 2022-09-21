using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class ProveedoresDireccionResidencia
    {
        public long? IdProveedor { get; set; }
        public string RifProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaUlt { get; set; }
        public byte? Tipo { get; set; }
    }
}
