// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.ReqOrigenRequerimiento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class ReqOrigenRequerimiento
  {
    public ReqOrigenRequerimiento() => this.ReqAreaRequerimiento = (ICollection<AppService.Core.Entities.ReqAreaRequerimiento>) new HashSet<AppService.Core.Entities.ReqAreaRequerimiento>();

    public int IdOrigenRequerimiento { get; set; }

    public string DescripcionOrigenRequerimiento { get; set; }

    public string IdCompañia { get; set; }

    public DateTime? FechaCambio { get; set; }

    public string UsuarioCambio { get; set; }

    public virtual ReqCompañia IdCompañiaNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.ReqAreaRequerimiento> ReqAreaRequerimiento { get; set; }
  }
}
