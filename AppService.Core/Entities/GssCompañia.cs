// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssCompañia
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssCompañia
  {
    public GssCompañia()
    {
      this.GssUnidadServicioCompañia = (ICollection<AppService.Core.Entities.GssUnidadServicioCompañia>) new HashSet<AppService.Core.Entities.GssUnidadServicioCompañia>();
      this.GssUsuarioCompañia = (ICollection<AppService.Core.Entities.GssUsuarioCompañia>) new HashSet<AppService.Core.Entities.GssUsuarioCompañia>();
    }

    public short IdCompañia { get; set; }

    public string NombreCompañia { get; set; }

    public string IdJde { get; set; }

    public bool Activo { get; set; }

    public short IdPais { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssPais IdPaisNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssUnidadServicioCompañia> GssUnidadServicioCompañia { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssUsuarioCompañia> GssUsuarioCompañia { get; set; }
  }
}
