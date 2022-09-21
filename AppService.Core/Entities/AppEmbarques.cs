// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppEmbarques
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class AppEmbarques
  {
    public Decimal Id { get; set; }

    public int? IdCategoria { get; set; }

    public string NombreCategoria { get; set; }

    public int? IdSubCategoria { get; set; }

    public string NombreSubCategoria { get; set; }

    public Decimal? TotalVenta { get; set; }
  }
}
