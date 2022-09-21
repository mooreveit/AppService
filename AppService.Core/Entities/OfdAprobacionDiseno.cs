// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdAprobacionDiseno
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdAprobacionDiseno
  {
    public long IdSolicitud { get; set; }

    public string EmailCliente { get; set; }

    public string Cargo { get; set; }

    public long? Cedula { get; set; }

    public string ObsConsultor { get; set; }

    public string ObsCliente { get; set; }

    public string UsuarioAgrega { get; set; }

    public DateTime FechaAgrega { get; set; }

    public Decimal IdTicket { get; set; }

    public bool FlagDescargoDiseno { get; set; }

    public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
  }
}
