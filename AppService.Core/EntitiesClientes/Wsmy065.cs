using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy065
    {
        public int? RecordNumber { get; set; }
        public decimal? Tipo { get; set; }
        public decimal Sector { get; set; }
        public decimal Ramo { get; set; }
        public string NombreRamo { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string Clave1 { get; set; }
        public bool FlagInactiva { get; set; }
        public string RamoSap { get; set; }

        public virtual Wsmy064 SectorNavigation { get; set; }
    }
}
