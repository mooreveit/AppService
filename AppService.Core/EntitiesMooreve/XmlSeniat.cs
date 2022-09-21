using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class XmlSeniat
    {
        public string RifUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public string Identificador { get; set; }
        public long? InicioNumeroSecuencial { get; set; }
        public long? FinNumeroSecuencial { get; set; }
        public long? NumeroFacturaVenta { get; set; }
        public decimal? BaseImponibleVenta { get; set; }
        public decimal? MontoIvaVenta { get; set; }
        public string XmlData { get; set; }
        public int IdDoc { get; set; }
        public long? InicioNumeroDocumento { get; set; }
        public byte[] FinNumeroDocumento { get; set; }
    }
}
