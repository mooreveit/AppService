// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobDescuentoIvaTipoTransaccion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobDescuentoIvaTipoTransaccion
  {
    public short Id { get; set; }

    public string IdTipoTransaccion { get; set; }

    public Decimal BsDesde { get; set; }

    public Decimal BsHasta { get; set; }

    public Decimal PorcDescuento { get; set; }

    public DateTime FechaRegistro { get; set; }

    public Decimal? RbsDesde { get; set; }

    public Decimal? RbsHasta { get; set; }
  }
}
