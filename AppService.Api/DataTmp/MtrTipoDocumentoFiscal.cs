using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrTipoDocumentoFiscal
    {
        public MtrTipoDocumentoFiscal()
        {
            PrcNumeracionFiscals = new HashSet<PrcNumeracionFiscal>();
        }

        public string TipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public bool ValidaNumero { get; set; }
        public int IdFormato { get; set; }

        public virtual ICollection<PrcNumeracionFiscal> PrcNumeracionFiscals { get; set; }
    }
}
