// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdCriterioBusqueda
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdCriterioBusqueda
  {
    public OfdCriterioBusqueda()
    {
      this.OfdAdjuntoCriterio = (ICollection<AppService.Core.Entities.OfdAdjuntoCriterio>) new HashSet<AppService.Core.Entities.OfdAdjuntoCriterio>();
      this.OfdGrupoCriterio = (ICollection<AppService.Core.Entities.OfdGrupoCriterio>) new HashSet<AppService.Core.Entities.OfdGrupoCriterio>();
    }

    public short IdCriterioBusqueda { get; set; }

    public string CampoBusqueda { get; set; }

    public string IdUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdAdjuntoCriterio> OfdAdjuntoCriterio { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdGrupoCriterio> OfdGrupoCriterio { get; set; }
  }
}
