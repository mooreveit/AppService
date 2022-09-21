// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrTipoCuentaDestino
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class MtrTipoCuentaDestino
  {
    public MtrTipoCuentaDestino() => this.MtrBancos = (ICollection<AppService.Core.Entities.MtrBancos>) new HashSet<AppService.Core.Entities.MtrBancos>();

    public int IdTipoCuentaDestino { get; set; }

    public string NombreCuentaDestino { get; set; }

    public virtual ICollection<AppService.Core.Entities.MtrBancos> MtrBancos { get; set; }
  }
}
