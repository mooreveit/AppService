// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdEspecificacionCotizacion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdEspecificacionCotizacion
  {
    public int IdSolicitud { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public string DescripcionSolicitud { get; set; }

    public string Cotizacion { get; set; }

    public int Renglon { get; set; }

    public int Propuesta { get; set; }

    public long? Orden { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public short IdTipoProducto { get; set; }

    public Decimal CantidadProducto { get; set; }

    public byte IdTipoCantidad { get; set; }

    public Decimal ValorVenta { get; set; }

    public Decimal ValorLista { get; set; }

    public string Observaciones { get; set; }

    public short IdMaquina { get; set; }

    public short? TipoOrden { get; set; }

    public string FlagFiscal { get; set; }

    public long? OrdenAnterior { get; set; }

    public string NumDesde { get; set; }

    public string NumHasta { get; set; }

    public string Instrucciones { get; set; }

    public string NumeroSerieControlDesde { get; set; }

    public string NumeroControlDesde { get; set; }

    public string NumeroSerieControlHasta { get; set; }

    public string NumeroControlHasta { get; set; }

    public string NumeroSerieFormatoDesde { get; set; }

    public string NumeroFormatoDesde { get; set; }

    public string NumeroSerieFormatoHasta { get; set; }

    public string NumeroFormatoHasta { get; set; }

    public string TipoDocumento { get; set; }

    public Decimal? LongitudMascara { get; set; }

    public long? NumeroSdf { get; set; }

    public int TalonExtra { get; set; }

    public Decimal? RvalorVenta { get; set; }

    public Decimal? RvalorLista { get; set; }
  }
}
