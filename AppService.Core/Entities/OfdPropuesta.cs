// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdPropuesta
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdPropuesta
  {
    public OfdPropuesta()
    {
      this.OfdSolicitudDiseno = (ICollection<AppService.Core.Entities.OfdSolicitudDiseno>) new HashSet<AppService.Core.Entities.OfdSolicitudDiseno>();
      this.PrcNumeracionFiscal = (ICollection<AppService.Core.Entities.PrcNumeracionFiscal>) new HashSet<AppService.Core.Entities.PrcNumeracionFiscal>();
    }

    public long IdPropuesta { get; set; }

    public string Cotizacion { get; set; }

    public int Renglon { get; set; }

    public int Propuesta { get; set; }

    public long IdRenglon { get; set; }

    public Decimal Cantidad { get; set; }

    public Decimal Precio { get; set; }

    public Decimal Total { get; set; }

    public int IdEstatus { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string ObsrPropuesta { get; set; }

    public Decimal CantXCaja { get; set; }

    public float CantMill { get; set; }

    public Decimal Cajas { get; set; }

    public Decimal CantFormas { get; set; }

    public string IdSolicitud { get; set; }

    public string RecalcularMargen { get; set; }

    public string CotizacionRenglonPropuesta { get; set; }

    public short UnidadCosteo { get; set; }

    public string IdPresentacion { get; set; }

    public string EstatusPlanta { get; set; }

    public Decimal PorcRespSocial { get; set; }

    public Decimal PorcComRegulada { get; set; }

    public Decimal PorcMcMinimo { get; set; }

    public Decimal PorcTolerancia { get; set; }

    public bool FlagAprobado { get; set; }

    public short CambComposicion { get; set; }

    public Decimal PorMcFinan { get; set; }

    public bool FlagVolumen { get; set; }

    public Decimal PorMcBruto { get; set; }

    public Decimal PorcComision { get; set; }

    public Decimal FactorSdf { get; set; }

    public Decimal? PorcIva { get; set; }

    public Decimal? Rprecio { get; set; }

    public Decimal? Rtotal { get; set; }

    public virtual OfdRenglon IdRenglonNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }

    public virtual ICollection<AppService.Core.Entities.PrcNumeracionFiscal> PrcNumeracionFiscal { get; set; }
  }
}
