// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.PrcNumeracionFiscal
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class PrcNumeracionFiscal
  {
    public PrcNumeracionFiscal() => this.OfdSolicitudDocFiscal = (ICollection<AppService.Core.Entities.OfdSolicitudDocFiscal>) new HashSet<AppService.Core.Entities.OfdSolicitudDocFiscal>();

    public long IdNumeracion { get; set; }

    public long IdPropuesta { get; set; }

    public string Rif { get; set; }

    public long? Orden { get; set; }

    public int? Copy { get; set; }

    public string NumeroSerieControlDesde { get; set; }

    public string NumeroControlDesde { get; set; }

    public string NumeroSerieControlHasta { get; set; }

    public string NumeroControlHasta { get; set; }

    public string NumeroSerieFormatoDesde { get; set; }

    public string NumeroFormatoDesde { get; set; }

    public string NumeroSerieFormatoHasta { get; set; }

    public string NumeroFormatoHasta { get; set; }

    public string TipoDocumento { get; set; }

    public int LongitudMascara { get; set; }

    public int? LongitudMascaraFormato { get; set; }

    public bool FlagSaltoNumeracion { get; set; }

    public string UsuarioAgrega { get; set; }

    public DateTime? FechaAgrega { get; set; }

    public virtual OfdPropuesta IdPropuestaNavigation { get; set; }

    public virtual MtrTipoDocumentoFiscal TipoDocumentoNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDocFiscal> OfdSolicitudDocFiscal { get; set; }
  }
}
