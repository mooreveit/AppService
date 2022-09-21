// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobEstadoDeCuenta
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobEstadoDeCuenta
  {
    public Decimal Id { get; set; }

    public double Rpdoc { get; set; }

    public string Rpdct { get; set; }

    public string Rpkco { get; set; }

    public string Rpsfx { get; set; }

    public double? Rpan8 { get; set; }

    public double? Rpag { get; set; }

    public double? Rpaap { get; set; }

    public string IdCliente { get; set; }

    public string Vendedor { get; set; }

    public string OficinaVenta { get; set; }

    public Decimal? BaseImponible { get; set; }

    public Decimal? Iva { get; set; }

    public Decimal? MontoOriginal { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string DocumentoSap { get; set; }

    public string Pltyp { get; set; }

    public string Moneda { get; set; }

    public double? Rrpag { get; set; }

    public double? Rrpaap { get; set; }

    public Decimal? RbaseImponible { get; set; }

    public Decimal? Riva { get; set; }

    public Decimal? RmontoOriginal { get; set; }
  }
}
