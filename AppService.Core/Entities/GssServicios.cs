// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssServicios
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssServicios
  {
    public GssServicios()
    {
      this.GssPlantillaServicio = (ICollection<AppService.Core.Entities.GssPlantillaServicio>) new HashSet<AppService.Core.Entities.GssPlantillaServicio>();
      this.GssServicioNivel = (ICollection<AppService.Core.Entities.GssServicioNivel>) new HashSet<AppService.Core.Entities.GssServicioNivel>();
      this.GssTarea = (ICollection<AppService.Core.Entities.GssTarea>) new HashSet<AppService.Core.Entities.GssTarea>();
      this.GssUsuarioPlantillaServicio = (ICollection<AppService.Core.Entities.GssUsuarioPlantillaServicio>) new HashSet<AppService.Core.Entities.GssUsuarioPlantillaServicio>();
    }

    public int IdServicio { get; set; }

    public string NombreServicio { get; set; }

    public int IdTipoServicio { get; set; }

    public bool Activo { get; set; }

    public bool FlagCoordinado { get; set; }

    public bool FlagAdjunto { get; set; }

    public bool? FlagControlNomina { get; set; }

    public string FormatoReporte { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssTipoServicio IdTipoServicioNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssPlantillaServicio> GssPlantillaServicio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssServicioNivel> GssServicioNivel { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssTarea> GssTarea { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicio { get; set; }
  }
}
