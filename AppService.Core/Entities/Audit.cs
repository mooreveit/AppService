// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.Audit
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class Audit
  {
    public string Type { get; set; }

    public string TableName { get; set; }

    public string Pk { get; set; }

    public string FieldName { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string UserName { get; set; }
  }
}
