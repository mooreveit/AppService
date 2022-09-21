// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssTarea
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssTarea
  {
    public GssTarea()
    {
      this.GssAdjuntoTarea = (ICollection<AppService.Core.Entities.GssAdjuntoTarea>) new HashSet<AppService.Core.Entities.GssAdjuntoTarea>();
      this.GssAprobacionServicio = (ICollection<AppService.Core.Entities.GssAprobacionServicio>) new HashSet<AppService.Core.Entities.GssAprobacionServicio>();
      this.GssTareaComentario = (ICollection<AppService.Core.Entities.GssTareaComentario>) new HashSet<AppService.Core.Entities.GssTareaComentario>();
      this.GssTareaPlantillaServicio = (ICollection<AppService.Core.Entities.GssTareaPlantillaServicio>) new HashSet<AppService.Core.Entities.GssTareaPlantillaServicio>();
    }

    public long IdTarea { get; set; }

    public DateTime FechaTarea { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public DateTime? FechaProcesada { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int IdServicio { get; set; }

    public long IdSolicitud { get; set; }

    public string Observaciones { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssServicios IdServicioNavigation { get; set; }

    public virtual GssSolicitud IdSolicitudNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssAdjuntoTarea> GssAdjuntoTarea { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssAprobacionServicio> GssAprobacionServicio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssTareaComentario> GssTareaComentario { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssTareaPlantillaServicio> GssTareaPlantillaServicio { get; set; }
  }
}
