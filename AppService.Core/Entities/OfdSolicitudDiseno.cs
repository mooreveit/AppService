// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdSolicitudDiseno
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdSolicitudDiseno
  {
    public OfdSolicitudDiseno()
    {
      this.OfdAdjuntosDiseno = (ICollection<AppService.Core.Entities.OfdAdjuntosDiseno>) new HashSet<AppService.Core.Entities.OfdAdjuntosDiseno>();
      this.OfdDetalleSolicitudDiseno = (ICollection<AppService.Core.Entities.OfdDetalleSolicitudDiseno>) new HashSet<AppService.Core.Entities.OfdDetalleSolicitudDiseno>();
      this.OfdSeguimiento = (ICollection<AppService.Core.Entities.OfdSeguimiento>) new HashSet<AppService.Core.Entities.OfdSeguimiento>();
      this.OfdSolicitudDisenoCambios = (ICollection<AppService.Core.Entities.OfdSolicitudDisenoCambios>) new HashSet<AppService.Core.Entities.OfdSolicitudDisenoCambios>();
      this.OfdVoBoDiseno = (ICollection<AppService.Core.Entities.OfdVoBoDiseno>) new HashSet<AppService.Core.Entities.OfdVoBoDiseno>();
    }

    public long IdSolicitud { get; set; }

    public long IdPropuesta { get; set; }

    public string IdPieImprenta { get; set; }

    public short IdTipoRespaldo { get; set; }

    public short UbicacionMarginal { get; set; }

    public bool FlagCambioParte { get; set; }

    public string ObsvSolicitud { get; set; }

    public string IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioActivo { get; set; }

    public string IdTipoCambio { get; set; }

    public virtual OfdMaestroPieImprenta IdPieImprentaNavigation { get; set; }

    public virtual OfdPropuesta IdPropuestaNavigation { get; set; }

    public virtual OfdTipoCambioDiseno IdTipoCambioNavigation { get; set; }

    public virtual OfdMaestroTipoRespaldo IdTipoRespaldoNavigation { get; set; }

    public virtual OfdMaestroUbicacionMarginal UbicacionMarginalNavigation { get; set; }

    public virtual OfdAprobacionDiseno OfdAprobacionDiseno { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdAdjuntosDiseno> OfdAdjuntosDiseno { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdDetalleSolicitudDiseno> OfdDetalleSolicitudDiseno { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSeguimiento> OfdSeguimiento { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDisenoCambios> OfdSolicitudDisenoCambios { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdVoBoDiseno> OfdVoBoDiseno { get; set; }
  }
}
