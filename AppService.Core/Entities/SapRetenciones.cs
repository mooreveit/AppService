// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.SapRetenciones
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class SapRetenciones
  {
    public Decimal Id { get; set; }

    public string TipodeRetencion { get; set; }

    public string Denominacion { get; set; }

    public string IndicadordeRetencion { get; set; }

    public double? Porcentaje { get; set; }

    public double? AsigancionCuentadebe { get; set; }

    public double? AsigancionCuentahaber { get; set; }

    public double? TransaccionLegacy { get; set; }
  }
}
