// Decompiled with JetBrains decompiler
// Type: AppService.Core.DTOs.AppPriceUpdateDto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.DTOs
{
  public class AppPriceUpdateDto
  {
    public int Id { get; set; }

    public int AppproductsId { get; set; }

    public Decimal Desde { get; set; }

    public Decimal Hasta { get; set; }

    public Decimal Precio { get; set; }
  }
}
