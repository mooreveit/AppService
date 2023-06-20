// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdTipoDocumento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class OfdTipoDocumento
  {
    public OfdTipoDocumento() => this.OfdRolTipoDocumento = (ICollection<AppService.Core.Entities.OfdRolTipoDocumento>) new HashSet<AppService.Core.Entities.OfdRolTipoDocumento>();

    public short IdTipoDocumento { get; set; }

    public short IdGrupoTipoDocumento { get; set; }

    public string NombreDocumento { get; set; }

    public bool? Obligatorio { get; set; }

    public bool? AfectaExpediente { get; set; }

    public string IdUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string IdUsuarioModificacion { get; set; }

    public DateTime FechaModificacion { get; set; }

    //public string TipoDocumentoSap { get; set; }

    public virtual OfdGrupoTipoDocumento IdGrupoTipoDocumentoNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdRolTipoDocumento> OfdRolTipoDocumento { get; set; }
  }
}
