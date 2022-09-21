// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.TPaVariables
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class TPaVariables
  {
    public TPaVariables()
    {
      this.TEnEntradas = (ICollection<AppService.Core.Entities.TEnEntradas>) new HashSet<AppService.Core.Entities.TEnEntradas>();
      this.TPaPlantillaEntradas = (ICollection<AppService.Core.Entities.TPaPlantillaEntradas>) new HashSet<AppService.Core.Entities.TPaPlantillaEntradas>();
    }

    public Decimal Id { get; set; }

    public string IdVariables { get; set; }

    public string NombreVariable { get; set; }

    public int? IdTipoVariable { get; set; }

    public string General { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioModifico { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string TipoDato { get; set; }

    public string AfectaMc { get; set; }

    public string AfectaCostoPororden { get; set; }

    public string IgualEnCombinacion { get; set; }

    public virtual TPaTiposDeVariables IdTipoVariableNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.TEnEntradas> TEnEntradas { get; set; }

    public virtual ICollection<AppService.Core.Entities.TPaPlantillaEntradas> TPaPlantillaEntradas { get; set; }
  }
}
