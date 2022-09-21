// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.ChildMenu
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class ChildMenu
  {
    public int Id { get; set; }

    public string Title { get; set; }

    public string Url { get; set; }

    public string Icon { get; set; }

    public int? PageMenuId { get; set; }
  }
}
