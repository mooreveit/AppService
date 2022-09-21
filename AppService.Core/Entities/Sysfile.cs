// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.Sysfile
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class Sysfile
  {
    public Decimal Id { get; set; }

    public string LinkServer { get; set; }

    public string LinkServerProduccion { get; set; }

    public string WebServer { get; set; }

    public string Servidor { get; set; }

    public string MailserverName { get; set; }

    public string MailserverType { get; set; }

    public Decimal? MailserverPort { get; set; }

    public short? PrimerDiaSemana { get; set; }

    public string DirVirtualOd { get; set; }
  }
}
