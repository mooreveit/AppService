// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobRangosVencimiento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobRangosVencimiento
  {
    public Decimal Id { get; set; }

    public Decimal Codigo { get; set; }

    public string Descripcion { get; set; }

    public Decimal? DiasDesde { get; set; }

    public Decimal? DiasHasta { get; set; }

    public string Coletilla { get; set; }

    public string PieUno { get; set; }

    public string PieDos { get; set; }
  }
}
