// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdGrupoTipoDocumento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdGrupoTipoDocumento
  {
    public OfdGrupoTipoDocumento()
    {
      this.OfdGrupoCriterio = (ICollection<AppService.Core.Entities.OfdGrupoCriterio>) new HashSet<AppService.Core.Entities.OfdGrupoCriterio>();
      this.OfdTipoDocumento = (ICollection<AppService.Core.Entities.OfdTipoDocumento>) new HashSet<AppService.Core.Entities.OfdTipoDocumento>();
    }

    public short IdGrupoTipoDocumento { get; set; }

    public string NombreGrupo { get; set; }

    public string IdUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string IdUsuarioModificacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdGrupoCriterio> OfdGrupoCriterio { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdTipoDocumento> OfdTipoDocumento { get; set; }
  }
}
