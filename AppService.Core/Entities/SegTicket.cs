// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.SegTicket
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class SegTicket
  {
    public Decimal Id { get; set; }

    public string TicketSha1 { get; set; }

    public bool FlagUsado { get; set; }

    public string IdUsuario { get; set; }

    public string IpUsuario { get; set; }

    public DateTime FechaHoraCreacion { get; set; }

    public DateTime? FechaHoraUso { get; set; }

    public DateTime? FechaHoraGetIp { get; set; }
  }
}
