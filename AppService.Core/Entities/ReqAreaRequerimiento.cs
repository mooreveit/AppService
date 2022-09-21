// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.ReqAreaRequerimiento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class ReqAreaRequerimiento
  {
    public ReqAreaRequerimiento() => this.ReqTipoTarea = (ICollection<AppService.Core.Entities.ReqTipoTarea>) new HashSet<AppService.Core.Entities.ReqTipoTarea>();

    public int IdAreaRequerimiento { get; set; }

    public string DescripcionAreaRequerimiento { get; set; }

    public int IdOrigenRequerimiento { get; set; }

    public DateTime? FechaCambio { get; set; }

    public string UsuarioCambio { get; set; }

    public virtual ReqOrigenRequerimiento IdOrigenRequerimientoNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.ReqTipoTarea> ReqTipoTarea { get; set; }
  }
}
