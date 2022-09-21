// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CrmMtrSeguimiento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CrmMtrSeguimiento
  {
    public CrmMtrSeguimiento() => this.CrmSeguimiento = (ICollection<AppService.Core.Entities.CrmSeguimiento>) new HashSet<AppService.Core.Entities.CrmSeguimiento>();

    public short IdTipoSegumiento { get; set; }

    public string NombreSeguimiento { get; set; }

    public bool FlagUpdateData { get; set; }

    public virtual ICollection<AppService.Core.Entities.CrmSeguimiento> CrmSeguimiento { get; set; }
  }
}
