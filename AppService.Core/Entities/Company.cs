// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.Company
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class Company
  {
    public Company() => this.User = (ICollection<AppService.Core.Entities.User>) new HashSet<AppService.Core.Entities.User>();

    public int CompanyId { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }

    public string Logo { get; set; }

    public virtual ICollection<AppService.Core.Entities.User> User { get; set; }
  }
}
