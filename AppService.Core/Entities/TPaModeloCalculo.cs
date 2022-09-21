// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.TPaModeloCalculo
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class TPaModeloCalculo
  {
    public TPaModeloCalculo() => this.TPaPlantillaEntradas = (ICollection<AppService.Core.Entities.TPaPlantillaEntradas>) new HashSet<AppService.Core.Entities.TPaPlantillaEntradas>();

    public Decimal Id { get; set; }

    public int CodigoModelo { get; set; }

    public string DescripcionModelo { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioModifico { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<AppService.Core.Entities.TPaPlantillaEntradas> TPaPlantillaEntradas { get; set; }
  }
}
