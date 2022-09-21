// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppSubCategory
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AppSubCategory
  {
    public AppSubCategory()
    {
      this.AppProducts = (ICollection<AppService.Core.Entities.AppProducts>) new HashSet<AppService.Core.Entities.AppProducts>();
      this.AppVariableSearch = (ICollection<AppService.Core.Entities.AppVariableSearch>) new HashSet<AppService.Core.Entities.AppVariableSearch>();
    }

    public int Id { get; set; }

    public string Description { get; set; }

    public int AppCategoryId { get; set; }

    public bool Active { get; set; }

    public virtual AppCategory AppCategory { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppProducts> AppProducts { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppVariableSearch> AppVariableSearch { get; set; }
  }
}
