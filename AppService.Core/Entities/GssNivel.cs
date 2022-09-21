// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssNivel
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssNivel
  {
    public GssNivel()
    {
      this.GssAprobacionServicio = (ICollection<AppService.Core.Entities.GssAprobacionServicio>) new HashSet<AppService.Core.Entities.GssAprobacionServicio>();
      this.GssServicioNivel = (ICollection<AppService.Core.Entities.GssServicioNivel>) new HashSet<AppService.Core.Entities.GssServicioNivel>();
      this.GssUsuarioNivel = (ICollection<AppService.Core.Entities.GssUsuarioNivel>) new HashSet<AppService.Core.Entities.GssUsuarioNivel>();
    }

    public int IdNivel { get; set; }

    public string NombreNivel { get; set; }

    public bool FlagSolicitante { get; set; }

    public bool FlagAprobador { get; set; }

    public bool FlagAprobadorServicio { get; set; }

    public bool FlagAprobadorGerencia { get; set; }

    public bool FlagCoordinador { get; set; }

    public bool FlagEjecutor { get; set; }

    public short Secuencia { get; set; }

    public short IdUnidadServicio { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssAprobacionServicio> GssAprobacionServicio { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssServicioNivel> GssServicioNivel { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssUsuarioNivel> GssUsuarioNivel { get; set; }
  }
}
