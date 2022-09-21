// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.ReqTarea
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class ReqTarea
  {
    public int IdTarea { get; set; }

    public string DescripcionTarea { get; set; }

    public int IdTipoTarea { get; set; }

    public DateTime? FechaCambio { get; set; }

    public string UsuarioCambio { get; set; }

    public virtual ReqTipoTarea IdTipoTareaNavigation { get; set; }
  }
}
