using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdDetalleSolicitudDiseno
    {
        public long IdDetalleSolicitud { get; set; }
        public long IdSolicitud { get; set; }
        public short NumeroAnotacion { get; set; }
        public string Anotacion { get; set; }
        public byte[] Imagen { get; set; }
        public string NombreImagen { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
    }
}
