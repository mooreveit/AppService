using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssSolicitudServicio
    {
        public long IdSolicitudServicio { get; set; }
        public long IdSolicitud { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }
    }
}
