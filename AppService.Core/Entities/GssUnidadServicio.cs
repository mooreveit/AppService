// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssUnidadServicio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssUnidadServicio
  {
    public GssUnidadServicio()
    {
      this.GssAreaServicio = (ICollection<AppService.Core.Entities.GssAreaServicio>) new HashSet<AppService.Core.Entities.GssAreaServicio>();
      this.GssNivel = (ICollection<AppService.Core.Entities.GssNivel>) new HashSet<AppService.Core.Entities.GssNivel>();
      this.GssSolicitud = (ICollection<AppService.Core.Entities.GssSolicitud>) new HashSet<AppService.Core.Entities.GssSolicitud>();
      this.GssUnidadServicioCompañia = (ICollection<AppService.Core.Entities.GssUnidadServicioCompañia>) new HashSet<AppService.Core.Entities.GssUnidadServicioCompañia>();
    }

    public short IdUnidadServicio { get; set; }

    public string NombreUnidadServicio { get; set; }

    public string Abreviado { get; set; }

    public bool Activo { get; set; }

    public string CuentaUnidadServicio { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssAreaServicio> GssAreaServicio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssNivel> GssNivel { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssSolicitud> GssSolicitud { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssUnidadServicioCompañia> GssUnidadServicioCompañia { get; set; }
  }
}
