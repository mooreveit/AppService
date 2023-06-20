using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdSeguimiento
    {
        public int IdSeguimiento { get; set; }
        public long IdSolicitud { get; set; }
        public short IdEstacion { get; set; }
        public string IdEstatus { get; set; }
        public string Usuario { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }

        public virtual OfdMaestroEstacion IdEstacionNavigation { get; set; }
        public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
    }
}
