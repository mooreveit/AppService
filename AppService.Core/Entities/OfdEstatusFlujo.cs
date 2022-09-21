// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdEstatusFlujo
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdEstatusFlujo
  {
    public OfdEstatusFlujo() => this.OfdSolicitudDocFiscal = (ICollection<AppService.Core.Entities.OfdSolicitudDocFiscal>) new HashSet<AppService.Core.Entities.OfdSolicitudDocFiscal>();

    public string IdEstatus { get; set; }

    public string NombreEstatus { get; set; }

    public string FlagPendiente { get; set; }

    public string FlagAprobado { get; set; }

    public string FlagRechazado { get; set; }

    public string FlagEnviado { get; set; }

    public bool FlagMail { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string UsuarioRegistro { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDocFiscal> OfdSolicitudDocFiscal { get; set; }
  }
}
