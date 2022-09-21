// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.User
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class User
  {
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }

    public string Photo { get; set; }

    public int CompanyId { get; set; }

    public bool? IsSuccess { get; set; }

    public string Message { get; set; }

    public virtual Company Company { get; set; }
  }
}
