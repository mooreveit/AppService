// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CrmSeguimiento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CrmSeguimiento
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

    public virtual MtrContactos IdContactoNavigation { get; set; }

    public virtual CrmMtrEstado IdEstadoNavigation { get; set; }

    public virtual CrmMtrSeguimiento IdTipoSeguimientoNavigation { get; set; }
  }
}
