// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssPais
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssPais
  {
    public GssPais() => this.GssCompañia = (ICollection<AppService.Core.Entities.GssCompañia>) new HashSet<AppService.Core.Entities.GssCompañia>();

    public short IdPais { get; set; }

    public string NombrePais { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssCompañia> GssCompañia { get; set; }
  }
}
