// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdCambioDiseno
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdCambioDiseno
  {
    public OfdCambioDiseno() => this.OfdSolicitudDisenoCambios = (ICollection<AppService.Core.Entities.OfdSolicitudDisenoCambios>) new HashSet<AppService.Core.Entities.OfdSolicitudDisenoCambios>();

    public int IdCambio { get; set; }

    public string NombreCambio { get; set; }

    public string IdTipoCambio { get; set; }

    public string UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual OfdTipoCambioDiseno IdTipoCambioNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdSolicitudDisenoCambios> OfdSolicitudDisenoCambios { get; set; }
  }
}
