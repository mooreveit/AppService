// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MigrationHistory
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class MigrationHistory
  {
    public string MigrationId { get; set; }

    public string ContextKey { get; set; }

    public byte[] Model { get; set; }

    public string ProductVersion { get; set; }
  }
}
