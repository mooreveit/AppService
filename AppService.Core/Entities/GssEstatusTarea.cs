// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssEstatusTarea
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssEstatusTarea
  {
    public GssEstatusTarea() => this.GssAprobacionServicio = (ICollection<AppService.Core.Entities.GssAprobacionServicio>) new HashSet<AppService.Core.Entities.GssAprobacionServicio>();

    public short IdEstatusTarea { get; set; }

    public string NombreEstatusTarea { get; set; }

    public string Abreviado { get; set; }

    public bool FlagPorAprobar { get; set; }

    public bool FlagAprobada { get; set; }

    public bool FlagPorCoordinar { get; set; }

    public bool FlagAsignado { get; set; }

    public bool FlagEnProceso { get; set; }

    public bool FlagProcesado { get; set; }

    public bool FlagCerrado { get; set; }

    public bool FlagCancelado { get; set; }

    public int IdAreaServicio { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssAprobacionServicio> GssAprobacionServicio { get; set; }
  }
}
