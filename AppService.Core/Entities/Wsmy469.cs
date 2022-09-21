// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.Wsmy469
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class Wsmy469
  {
    public Decimal Id { get; set; }

    public string Rif { get; set; }

    public DateTime? Fecha { get; set; }

    public long? Orden { get; set; }

    public string Cotizacion { get; set; }

    public short? Copy { get; set; }

    public string Producto { get; set; }

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

    public string UsuarioAgrega { get; set; }

    public string UsuarioModifica { get; set; }

    public DateTime? FechaHoraAgrega { get; set; }

    public DateTime? FechaHoraModifica { get; set; }

    public long? NumeroSdf { get; set; }

    public Decimal? IdDireccionFacturar { get; set; }

    public Decimal? IdDireccionEntregar { get; set; }
  }
}
