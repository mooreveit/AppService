// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.ReqCompañia
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class ReqCompañia
  {
    public ReqCompañia() => this.ReqOrigenRequerimiento = (ICollection<AppService.Core.Entities.ReqOrigenRequerimiento>) new HashSet<AppService.Core.Entities.ReqOrigenRequerimiento>();

    public string IdCompañia { get; set; }

    public string NombreCompañia { get; set; }

    public DateTime? FechaCambio { get; set; }

    public string UsuarioCambio { get; set; }

    public virtual ICollection<AppService.Core.Entities.ReqOrigenRequerimiento> ReqOrigenRequerimiento { get; set; }
  }
}
