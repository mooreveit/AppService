// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdMaestroFlujo
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdMaestroFlujo
  {
    public OfdMaestroFlujo() => this.OfdMaestroEstacion = (ICollection<AppService.Core.Entities.OfdMaestroEstacion>) new HashSet<AppService.Core.Entities.OfdMaestroEstacion>();

    public short IdFlujo { get; set; }

    public string NombreFlujo { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdMaestroEstacion> OfdMaestroEstacion { get; set; }
  }
}
