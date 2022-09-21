// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.PrcPlantillaNumeraciones
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class PrcPlantillaNumeraciones
  {
    public long Id { get; set; }

    public int? Mascara { get; set; }

    public int? Prefijo { get; set; }

    public string PrefijoChar { get; set; }

    public Decimal? MaximoNumero { get; set; }

    public Decimal? Hasta { get; set; }
  }
}
