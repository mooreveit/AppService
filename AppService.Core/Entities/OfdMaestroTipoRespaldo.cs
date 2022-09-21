// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdMaestroTipoRespaldo
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdMaestroTipoRespaldo
  {
    public OfdMaestroTipoRespaldo() => this.OfdSolicitudDiseno = (ICollection<AppService.Core.Entities.OfdSolicitudDiseno>) new HashSet<AppService.Core.Entities.OfdSolicitudDiseno>();

    public short IdTipoRespaldo { get; set; }

    public string TipoRespaldo { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
  }
}
