// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdMaestroEstacion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdMaestroEstacion
  {
    public OfdMaestroEstacion() => this.OfdSeguimiento = (ICollection<AppService.Core.Entities.OfdSeguimiento>) new HashSet<AppService.Core.Entities.OfdSeguimiento>();

    public short IdEstacion { get; set; }

    public short IdFlujo { get; set; }

    public string NombreEstacion { get; set; }

    public string AbreviadoEstacion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public virtual OfdMaestroFlujo IdFlujoNavigation { get; set; }

    public virtual OfdFlujoEstacion OfdFlujoEstacion { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSeguimiento> OfdSeguimiento { get; set; }
  }
}
