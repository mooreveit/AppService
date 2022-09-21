using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wary088
    {
        public decimal Recnum { get; set; }
        public string TipoRif { get; set; }
        public long NumeroRif { get; set; }
        public string ZonaRif { get; set; }
        public string RazonSocial { get; set; }
        public long Nit { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public short CodCiudad { get; set; }
        public short CodigoPostal { get; set; }
        public string DocPendiente { get; set; }
        public DateTime? FechaExp { get; set; }
        public short Status { get; set; }
        public DateTime? FechaStatus { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModif { get; set; }
        public int ClienteMatriz { get; set; }
        public short UltimoItem { get; set; }
    }
}
