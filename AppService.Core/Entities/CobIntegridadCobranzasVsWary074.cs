// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobIntegridadCobranzasVsWary074
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobIntegridadCobranzasVsWary074
  {
    public Decimal Id { get; set; }

    public string Cliente { get; set; }

    public long Documento { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public Decimal? MontoCobrado { get; set; }

    public Decimal? MontoRetenido { get; set; }

    public Decimal? TotalCobroRetencion { get; set; }

    public Decimal? TotalCobradoWary074 { get; set; }

    public Decimal? Diferencia { get; set; }

    public Decimal? TotalSapCobranzas { get; set; }

    public DateTime? FechaEvaluacion { get; set; }
  }
}
