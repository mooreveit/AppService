// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssUsuarioCompañia
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class GssUsuarioCompañia
  {
    public int IdUsuarioCompañia { get; set; }

    public int IdUsuario { get; set; }

    public short IdCompañia { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssCompañia IdCompañiaNavigation { get; set; }

    public virtual SegUsuario IdUsuarioNavigation { get; set; }
  }
}
