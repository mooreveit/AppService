// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AutoAudit
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class AutoAudit
  {
    public long AuditId { get; set; }

    public DateTime? AuditDate { get; set; }

    public string AuditUserName { get; set; }

    public string TableName { get; set; }

    public string OldContent { get; set; }

    public string NewContent { get; set; }
  }
}
