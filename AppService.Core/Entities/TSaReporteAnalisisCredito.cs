// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.TSaReporteAnalisisCredito
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class TSaReporteAnalisisCredito
  {
    public Decimal Id { get; set; }

    public Decimal? IdSolicitud { get; set; }

    public string Idvariables { get; set; }

    public string NombreVariable { get; set; }

    public string Valor { get; set; }

    public Decimal? LineaReporte { get; set; }

    public string Titulo { get; set; }

    public string Cotizacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string IdvariablePadre { get; set; }
  }
}
