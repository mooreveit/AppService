// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.ReqTipoTarea
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class ReqTipoTarea
  {
    public ReqTipoTarea() => this.ReqTarea = (ICollection<AppService.Core.Entities.ReqTarea>) new HashSet<AppService.Core.Entities.ReqTarea>();

    public int IdTipoTarea { get; set; }

    public string DescripcionTipoTarea { get; set; }

    public int IdAreaRequerimiento { get; set; }

    public DateTime? FechaCambio { get; set; }

    public string UsuarioCambio { get; set; }

    public virtual ReqAreaRequerimiento IdAreaRequerimientoNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.ReqTarea> ReqTarea { get; set; }
  }
}
