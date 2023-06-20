using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class PrcNumeracionFiscal
    {
        public PrcNumeracionFiscal()
        {
            OfdSolicitudDocFiscals = new HashSet<OfdSolicitudDocFiscal>();
        }

        public long IdNumeracion { get; set; }
        public long IdPropuesta { get; set; }
        public string Rif { get; set; }
        public long? Orden { get; set; }
        public int? Copy { get; set; }
        public string NumeroSerieControlDesde { get; set; }
        public string NumeroControlDesde { get; set; }
        public string NumeroSerieControlHasta { get; set; }
        public string NumeroControlHasta { get; set; }
        public string NumeroSerieFormatoDesde { get; set; }
        public string NumeroFormatoDesde { get; set; }
        public string NumeroSerieFormatoHasta { get; set; }
        public string NumeroFormatoHasta { get; set; }
        public string TipoDocumento { get; set; }
        public int LongitudMascara { get; set; }
        public int? LongitudMascaraFormato { get; set; }
        public bool FlagSaltoNumeracion { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime? FechaAgrega { get; set; }

        public virtual OfdPropuestum IdPropuestaNavigation { get; set; }
        public virtual MtrTipoDocumentoFiscal TipoDocumentoNavigation { get; set; }
        public virtual ICollection<OfdSolicitudDocFiscal> OfdSolicitudDocFiscals { get; set; }
    }
}
