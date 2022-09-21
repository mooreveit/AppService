// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AspNetUsers
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AspNetUsers
  {
    public AspNetUsers()
    {
      this.AspNetUserClaims = (ICollection<AppService.Core.Entities.AspNetUserClaims>) new HashSet<AppService.Core.Entities.AspNetUserClaims>();
      this.AspNetUserLogins = (ICollection<AppService.Core.Entities.AspNetUserLogins>) new HashSet<AppService.Core.Entities.AspNetUserLogins>();
      this.AspNetUserRoles = (ICollection<AppService.Core.Entities.AspNetUserRoles>) new HashSet<AppService.Core.Entities.AspNetUserRoles>();
    }

    public string Id { get; set; }

    public string Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string PasswordHash { get; set; }

    public string SecurityStamp { get; set; }

    public string PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; }

    public virtual ICollection<AppService.Core.Entities.AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual ICollection<AppService.Core.Entities.AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual ICollection<AppService.Core.Entities.AspNetUserRoles> AspNetUserRoles { get; set; }
  }
}
