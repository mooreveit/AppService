// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobSysfile
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobSysfile
  {
    public short Id { get; set; }

    public DateTime FechaLm { get; set; }

    public bool? FlagAprobarRc { get; set; }

    public DateTime? FechaLmcxC { get; set; }
  }
}
