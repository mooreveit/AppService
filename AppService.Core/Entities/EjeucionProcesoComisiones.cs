// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.EjeucionProcesoComisiones
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class EjeucionProcesoComisiones
  {
    public Decimal Id { get; set; }

    public Decimal IdEvaluacion { get; set; }

    public string Query { get; set; }

    public string Mensaje { get; set; }

    public DateTime? Inicio { get; set; }

    public DateTime? Fin { get; set; }

    public string Usuario { get; set; }

    public DateTime FechaEjecucion { get; set; }
  }
}
