using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobExcepcion
    {
        public int IdExcepcion { get; set; }
        public long Documento { get; set; }
        public DateTime FechaLm { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        public virtual CobGeneralCobranza DocumentoNavigation { get; set; }
    }
}
