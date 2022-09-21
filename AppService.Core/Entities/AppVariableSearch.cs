// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppVariableSearch
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class AppVariableSearch
  {
    public int Id { get; set; }

    public int? AppSubCategoryId { get; set; }

    public int? AppVariableId { get; set; }

    public string SearchText { get; set; }

    public virtual AppSubCategory AppSubCategory { get; set; }

    public virtual AppVariables AppVariable { get; set; }
  }
}
