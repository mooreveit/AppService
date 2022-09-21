// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.ValevenDataResumen
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class ValevenDataResumen
  {
    public long Tickets { get; set; }

    public long Anulados { get; set; }

    public long Escaneados { get; set; }

    public long Impresos { get; set; }

    public DateTime FechaActualizacion { get; set; }
  }
}
