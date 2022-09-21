// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssTipoServicio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssTipoServicio
  {
    public GssTipoServicio() => this.GssServicios = (ICollection<AppService.Core.Entities.GssServicios>) new HashSet<AppService.Core.Entities.GssServicios>();

    public int IdTipoServicio { get; set; }

    public string NombreTipoServicio { get; set; }

    public int IdAreaServicio { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssAreaServicio IdAreaServicioNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssServicios> GssServicios { get; set; }
  }
}
