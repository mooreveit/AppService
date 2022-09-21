// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssAreaServicio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class GssAreaServicio
  {
    public GssAreaServicio() => this.GssTipoServicio = (ICollection<AppService.Core.Entities.GssTipoServicio>) new HashSet<AppService.Core.Entities.GssTipoServicio>();

    public int IdAreaServicio { get; set; }

    public string NombreAreaServicio { get; set; }

    public short IdUnidadServicio { get; set; }

    public bool Activo { get; set; }

    public short IdCoordinador { get; set; }

    public short IdAprobador { get; set; }

    public short IdAprobadorGerencia { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.GssTipoServicio> GssTipoServicio { get; set; }
  }
}
