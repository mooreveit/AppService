// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdMaestroUbicacionMarginal
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdMaestroUbicacionMarginal
  {
    public OfdMaestroUbicacionMarginal() => this.OfdSolicitudDiseno = (ICollection<AppService.Core.Entities.OfdSolicitudDiseno>) new HashSet<AppService.Core.Entities.OfdSolicitudDiseno>();

    public short IdUbicacionMarginal { get; set; }

    public string UbicacionMarginal { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
  }
}
