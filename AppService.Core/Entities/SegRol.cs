// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.SegRol
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class SegRol
  {
    public SegRol()
    {
      this.OfdRolTipoDocumento = (ICollection<AppService.Core.Entities.OfdRolTipoDocumento>) new HashSet<AppService.Core.Entities.OfdRolTipoDocumento>();
      this.SegUsuarioRol = (ICollection<AppService.Core.Entities.SegUsuarioRol>) new HashSet<AppService.Core.Entities.SegUsuarioRol>();
    }

    public int IdRol { get; set; }

    public string NombreRol { get; set; }

    public int IdPrograma { get; set; }

    public string DescripcionRol { get; set; }

    public string AbreviadoRol { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdRolTipoDocumento> OfdRolTipoDocumento { get; set; }

    public virtual ICollection<AppService.Core.Entities.SegUsuarioRol> SegUsuarioRol { get; set; }
  }
}
