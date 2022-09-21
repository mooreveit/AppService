// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdTipoCambioDiseno
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdTipoCambioDiseno
  {
    public OfdTipoCambioDiseno()
    {
      this.OfdCambioDiseno = (ICollection<AppService.Core.Entities.OfdCambioDiseno>) new HashSet<AppService.Core.Entities.OfdCambioDiseno>();
      this.OfdSolicitudDiseno = (ICollection<AppService.Core.Entities.OfdSolicitudDiseno>) new HashSet<AppService.Core.Entities.OfdSolicitudDiseno>();
    }

    public string IdTipoCambio { get; set; }

    public string NombreTipoCambio { get; set; }

    public short IdPonderacion { get; set; }

    public string UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdCambioDiseno> OfdCambioDiseno { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
  }
}
