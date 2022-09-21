// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssSolicitud
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssSolicitud
  {
    public GssSolicitud()
    {
      this.GssPasoSolicitud = (ICollection<AppService.Core.Entities.GssPasoSolicitud>) new HashSet<AppService.Core.Entities.GssPasoSolicitud>();
      this.GssTarea = (ICollection<AppService.Core.Entities.GssTarea>) new HashSet<AppService.Core.Entities.GssTarea>();
    }

    public long IdSolicitud { get; set; }

    public string TituloSolicitud { get; set; }

    public string DescripcionSolicitud { get; set; }

    public string JustificacionSolicitud { get; set; }

    public short IdUnidadServicio { get; set; }

    public short IdEstatusSolicitud { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssEstatusSolicitud IdEstatusSolicitudNavigation { get; set; }

    public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssPasoSolicitud> GssPasoSolicitud { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssTarea> GssTarea { get; set; }
  }
}
