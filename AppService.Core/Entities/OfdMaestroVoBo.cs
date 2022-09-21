// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdMaestroVoBo
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdMaestroVoBo
  {
    public OfdMaestroVoBo() => this.OfdVoBoDiseno = (ICollection<AppService.Core.Entities.OfdVoBoDiseno>) new HashSet<AppService.Core.Entities.OfdVoBoDiseno>();

    public short IdVoBo { get; set; }

    public short IdEstacion { get; set; }

    public short Orden { get; set; }

    public string Instruccion { get; set; }

    public string IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdVoBoDiseno> OfdVoBoDiseno { get; set; }
  }
}
