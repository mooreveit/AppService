// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdRenglon
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdRenglon
  {
    public OfdRenglon() => this.OfdPropuesta = (ICollection<AppService.Core.Entities.OfdPropuesta>) new HashSet<AppService.Core.Entities.OfdPropuesta>();

    public long IdRenglon { get; set; }

    public string Cotizacion { get; set; }

    public int Renglon { get; set; }

    public long IdCotizacion { get; set; }

    public string IdProducto { get; set; }

    public string NombreComercialProducto { get; set; }

    public int IdEstatus { get; set; }

    public int RazonGanadaPerdida { get; set; }

    public int Competidor { get; set; }

    public string Unidad { get; set; }

    public string ObsvRenglon { get; set; }

    public int Probabilidad { get; set; }

    public int DiasEntrega { get; set; }

    public string ObsrGanarPerder { get; set; }

    public DateTime FechaRegistro { get; set; }

    public Decimal TotalRenglon { get; set; }

    public Decimal TotalGanado { get; set; }

    public DateTime? FechaReorden { get; set; }

    public short IdTituloCalendario { get; set; }

    public string EstatusPlanta { get; set; }

    public long Orden { get; set; }

    public long OrdenAnterior { get; set; }

    public bool FlagEstimada { get; set; }

    public bool FlagPortadiseno { get; set; }

    public bool FlagCombinada { get; set; }

    public bool FlagFiscal { get; set; }

    public long IdCombinada { get; set; }

    public Decimal? RtotalRenglon { get; set; }

    public Decimal? RtotalGanado { get; set; }

    public virtual OfdCotizacion IdCotizacionNavigation { get; set; }

    public virtual MtrProducto IdProductoNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdPropuesta> OfdPropuesta { get; set; }
  }
}
