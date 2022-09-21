// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssEstatusSolicitud
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssEstatusSolicitud
  {
    public GssEstatusSolicitud() => this.GssSolicitud = (ICollection<AppService.Core.Entities.GssSolicitud>) new HashSet<AppService.Core.Entities.GssSolicitud>();

    public short IdEstatusSolicitud { get; set; }

    public string NombreEstatusSolicitud { get; set; }

    public string Abreviado { get; set; }

    public bool FlagCreada { get; set; }

    public bool FlagPorAprobar { get; set; }

    public bool FlagEnProceso { get; set; }

    public bool FlagCerrada { get; set; }

    public bool FlagCancelada { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssSolicitud> GssSolicitud { get; set; }
  }
}
