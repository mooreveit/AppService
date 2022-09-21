// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatPapel
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CatPapel
  {
    public CatPapel() => this.CatMaterialDetalleTmp = (ICollection<AppService.Core.Entities.CatMaterialDetalleTmp>) new HashSet<AppService.Core.Entities.CatMaterialDetalleTmp>();

    public string CatPapelId { get; set; }

    public string Descripcion { get; set; }

    public bool EsCarbon { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatMaterialDetalleTmp> CatMaterialDetalleTmp { get; set; }
  }
}
