// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CreSolicitudExcepcion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CreSolicitudExcepcion
  {
    public Decimal SolicitudDeCredito { get; set; }

    public string ObservacionesCredito { get; set; }

    public string ObservacionesAprobador { get; set; }

    public byte[] Imagen { get; set; }

    public string NombreImagen { get; set; }

    public bool? Aprobado { get; set; }

    public bool? Rechazado { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioAprobador { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public string UsuarioRechazo { get; set; }

    public DateTime? FechaRechazo { get; set; }

    public bool? SolicitudExcepcionPorPago { get; set; }

    public Decimal? MontoPagado { get; set; }

    public bool? SolicitudCerrada { get; set; }

    public DateTime? FechaCompromiso { get; set; }
  }
}
