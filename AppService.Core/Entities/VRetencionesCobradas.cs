// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.VRetencionesCobradas
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class VRetencionesCobradas
  {
    public int? AñoCobro { get; set; }

    public int? MesCobro { get; set; }

    public string Region { get; set; }

    public string Oficina { get; set; }

    public string Vendedor { get; set; }

    public string NombreCliente { get; set; }

    public long? Documento { get; set; }

    public string DocumentoSap { get; set; }

    public string NroComprobante { get; set; }

    public Decimal? Porcentaje { get; set; }

    public Decimal? BsEmision { get; set; }

    public DateTime? FechaContabilizacion { get; set; }

    public Decimal? TasaContabilizacion { get; set; }

    public DateTime? FechaComprobante { get; set; }

    public Decimal? TasaComprobante { get; set; }

    public Decimal? DolaresContabilizacion { get; set; }

    public Decimal? DolaresComprobante { get; set; }

    public Decimal? DolaresFechaFactura { get; set; }

    public Decimal? Diferencia { get; set; }

    public DateTime? FechaFactura { get; set; }

    public int? AñoFactura { get; set; }

    public int? MesFactura { get; set; }

    public int? DiaFactura { get; set; }

    public int? AñoContabilizacion { get; set; }

    public int? MesContabilizacion { get; set; }

    public int? DiaContabilizacion { get; set; }

    public int? CorteFactura { get; set; }

    public int? CorteCobro { get; set; }

    public int? FactorDiferencia { get; set; }
  }
}
