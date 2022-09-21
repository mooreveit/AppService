// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssVariable
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssVariable
  {
    public GssVariable()
    {
      this.GssPlantillaServicio = (ICollection<AppService.Core.Entities.GssPlantillaServicio>) new HashSet<AppService.Core.Entities.GssPlantillaServicio>();
      this.GssUsuarioPlantillaServicio = (ICollection<AppService.Core.Entities.GssUsuarioPlantillaServicio>) new HashSet<AppService.Core.Entities.GssUsuarioPlantillaServicio>();
    }

    public int IdVariable { get; set; }

    public string NombreVariable { get; set; }

    public string TituloVariable { get; set; }

    public short IdUnidadServicio { get; set; }

    public string TipoDato { get; set; }

    public string FuncionBusqueda { get; set; }

    public bool Activo { get; set; }

    public bool? FlagGenerica { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssPlantillaServicio> GssPlantillaServicio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicio { get; set; }
  }
}
