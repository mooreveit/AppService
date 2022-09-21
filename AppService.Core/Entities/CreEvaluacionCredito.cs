// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CreEvaluacionCredito
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CreEvaluacionCredito
  {
    public Decimal Id { get; set; }

    public Decimal IdEvaluacion { get; set; }

    public string CodCliente { get; set; }

    public Decimal? Monto { get; set; }

    public Decimal? IdSolicitudAnalisis { get; set; }

    public string Usuario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Aprobado { get; set; }

    public Decimal? Rmonto { get; set; }
  }
}
