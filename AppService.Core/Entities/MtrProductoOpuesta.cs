// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrProductoOpuesta
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class MtrProductoOpuesta
  {
    public Decimal Id { get; set; }

    public string Producto { get; set; }

    public string MedidaFraccion { get; set; }

    public string MedidaMascara { get; set; }

    public Decimal? Frecuencia { get; set; }
  }
}
