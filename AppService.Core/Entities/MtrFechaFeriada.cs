// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrFechaFeriada
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class MtrFechaFeriada
  {
    public Decimal Recnum { get; set; }

    public DateTime FechaFeriada { get; set; }

    public string Motivo { get; set; }

    public string MostrarBs { get; set; }
  }
}
