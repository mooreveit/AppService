// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AspNetUserLogins
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class AspNetUserLogins
  {
    public string LoginProvider { get; set; }

    public string ProviderKey { get; set; }

    public string UserId { get; set; }

    public virtual AspNetUsers User { get; set; }
  }
}
