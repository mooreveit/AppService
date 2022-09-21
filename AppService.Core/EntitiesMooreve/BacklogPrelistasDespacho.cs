using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class BacklogPrelistasDespacho
    {
        public long Orden { get; set; }
        public decimal? JobId { get; set; }
        public string CodProducto { get; set; }
        public string DescProducto { get; set; }
        public int? Cliente { get; set; }
        public string RifFacturar { get; set; }
        public string NombreCliente { get; set; }
        public decimal? NumerCopya { get; set; }
        public long? CantProgramada { get; set; }
        public decimal? CantFactura { get; set; }
        public decimal? CtdEntregada { get; set; }
        public decimal? CantFactAdelan { get; set; }
        public decimal? CantFacturar { get; set; }
        public decimal? CantEntregar { get; set; }
        public decimal? CantMillFactv19 { get; set; }
        public long? CtdFacturadav19 { get; set; }
        public decimal? CantFacturarv19 { get; set; }
        public decimal? CantEntregarv19 { get; set; }
        public string Tipo { get; set; }
        public DateTime? FechaProg { get; set; }
        public short? CodigoZonaDespacho { get; set; }
        public string ZonaDespacho { get; set; }
    }
}
