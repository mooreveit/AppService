﻿// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.T006a
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class T006a
  {
    public T006a() => this.MtrProducto = (ICollection<AppService.Core.Entities.MtrProducto>) new HashSet<AppService.Core.Entities.MtrProducto>();

    public string Mandt { get; set; }

    public string Spras { get; set; }

    public string Msehi { get; set; }

    public string Mseh3 { get; set; }

    public string Mseh6 { get; set; }

    public string Mseht { get; set; }

    public string Msehl { get; set; }

    public virtual ICollection<AppService.Core.Entities.MtrProducto> MtrProducto { get; set; }
  }
}
