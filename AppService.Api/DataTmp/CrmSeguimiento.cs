using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CrmSeguimiento
    {
        public long IdSeguimiento { get; set; }
        public string IdCliente { get; set; }
        public long IdContacto { get; set; }
        public short IdTipoSeguimiento { get; set; }
        public short IdEstado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public string Comentarios { get; set; }
        public bool NotificaUsuario { get; set; }
        public bool NotificaConsultor { get; set; }
        public string ListaInformados { get; set; }
        public DateTime FechaUpdate { get; set; }
        public string UsuarioUpdate { get; set; }

        public virtual MtrCliente IdClienteNavigation { get; set; }
        public virtual MtrContacto IdContactoNavigation { get; set; }
        public virtual CrmMtrEstado IdEstadoNavigation { get; set; }
        public virtual CrmMtrSeguimiento IdTipoSeguimientoNavigation { get; set; }
    }
}
