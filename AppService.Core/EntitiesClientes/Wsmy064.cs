using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy064
    {
        public Wsmy064()
        {
            Wsmy065 = new HashSet<Wsmy065>();
        }

        public int? RecordNumber { get; set; }
        public decimal? Tipo { get; set; }
        public decimal Sector { get; set; }
        public string NombreSector { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaCambio { get; set; }
        public bool FlagInactiva { get; set; }
        public string SectorSap { get; set; }

        public virtual ICollection<Wsmy065> Wsmy065 { get; set; }
    }
}
