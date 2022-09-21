// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdPartesCotizacion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdPartesCotizacion
  {
    public int Recnum { get; set; }

    public string Cotizacion { get; set; }

    public int Renglon { get; set; }

    public int Propuesta { get; set; }

    public int IdParte { get; set; }

    public string IdPapel { get; set; }

    public int IdConstruccion { get; set; }

    public Decimal LargoCm { get; set; }

    public Decimal AnchoCm { get; set; }

    public Decimal Cantidad { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? MedidaBase { get; set; }

    public int? MedidaOpuesta { get; set; }

    public string FrasesMarginales { get; set; }
  }
}
