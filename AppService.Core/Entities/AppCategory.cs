// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppCategory
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AppCategory
  {
    public AppCategory() => this.AppSubCategory = (ICollection<AppService.Core.Entities.AppSubCategory>) new HashSet<AppService.Core.Entities.AppSubCategory>();

    public int Id { get; set; }

    public string Description { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppSubCategory> AppSubCategory { get; set; }
  }
}
