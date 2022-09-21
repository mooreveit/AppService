// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AspNetUserClaims
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class AspNetUserClaims
  {
    public int Id { get; set; }

    public string UserId { get; set; }

    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }

    public virtual AspNetUsers User { get; set; }
  }
}
