// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.PrcOrdenIdPropuesta
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class PrcOrdenIdPropuesta
  {
    public Decimal Id { get; set; }

    public long IdPropuesta { get; set; }

    public long? Orden { get; set; }
  }
}
