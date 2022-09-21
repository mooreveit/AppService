// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AspNetRoles
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AspNetRoles
  {
    public AspNetRoles() => this.AspNetUserRoles = (ICollection<AppService.Core.Entities.AspNetUserRoles>) new HashSet<AppService.Core.Entities.AspNetUserRoles>();

    public string Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<AppService.Core.Entities.AspNetUserRoles> AspNetUserRoles { get; set; }
  }
}
