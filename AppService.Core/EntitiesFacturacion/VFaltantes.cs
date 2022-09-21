using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class VFaltantes
    {
        public int Factura { get; set; }
        public short NroCaja { get; set; }
        public string PrefDesde { get; set; }
        public long NumeroDesde { get; set; }
        public string SufDesde { get; set; }
        public string PrefHasta { get; set; }
        public long NumeroHasta { get; set; }
        public string SufHasta { get; set; }
        public long? Cant { get; set; }
        public DateTime FechaFactura { get; set; }
        public string NombreFact { get; set; }
        public string DireccionFact1 { get; set; }
        public string DireccionFact2 { get; set; }
        public string DireccionFact3 { get; set; }
        public long Orden { get; set; }
        public string Nombre { get; set; }
        public string Firma { get; set; }
    }
}
