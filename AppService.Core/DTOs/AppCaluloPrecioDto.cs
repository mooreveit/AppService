// Decompiled with JetBrains decompiler
// Type: AppService.Core.DTOs.AppCaluloPrecioDto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.DTOs
{
  public class AppCaluloPrecioDto
  {
    public int CalculoId { get; set; }

    public Decimal Precio { get; set; }

    public int AppProductId { get; set; }

    public Decimal Cantidad { get; set; }

    public Decimal unitario => this.Precio / this.Cantidad;
  }
}
