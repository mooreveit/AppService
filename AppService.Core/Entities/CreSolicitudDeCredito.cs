// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CreSolicitudDeCredito
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CreSolicitudDeCredito
  {
    public Decimal Id { get; set; }

    public Decimal SolicitudDeCredito { get; set; }

    public string Cotizacion { get; set; }

    public Decimal? MontoSolicitado { get; set; }

    public Decimal? UltimoIdSolicitudAnalisis { get; set; }

    public Decimal? IdSolicitudAnalisisAprobacion { get; set; }

    public bool? Aprobada { get; set; }

    public string UsuarioAprobo { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public bool? Rechazado { get; set; }

    public string UsuarioRechazo { get; set; }

    public DateTime? FechaRechazo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public Decimal? NroExcepcion { get; set; }

    public string UsuarioAprobador { get; set; }

    public string ObservacionesCredito { get; set; }

    public byte[] ReporteAnalisiCredito { get; set; }

    public string CodCliente { get; set; }

    public bool? EvaluadaAdministradora { get; set; }

    public Decimal? RmontoSolicitado { get; set; }
  }
}
