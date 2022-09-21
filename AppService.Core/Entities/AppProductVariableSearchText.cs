// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppProductVariableSearchText
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class AppProductVariableSearchText
  {
    public int Id { get; set; }

    public int? AppProductId { get; set; }

    public int? AppVariableId { get; set; }

    public string CodeVariable { get; set; }

    public string SearchText { get; set; }

    public virtual AppProducts AppProduct { get; set; }

    public virtual AppVariables AppVariable { get; set; }
  }
}
