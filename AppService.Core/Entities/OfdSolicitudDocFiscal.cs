// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdSolicitudDocFiscal
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdSolicitudDocFiscal
  {
    public long IdSdf { get; set; }

    public long IdNumeracion { get; set; }

    public string IdEstatus { get; set; }

    public string EmailCliente { get; set; }

    public string Cargo { get; set; }

    public long Cedula { get; set; }

    public bool FlagSaltoNumeracion { get; set; }

    public string ObsvConsultor { get; set; }

    public string ObsvCliente { get; set; }

    public string UsuarioAgrega { get; set; }

    public DateTime FechaAgrega { get; set; }

    public Decimal? IdTicket { get; set; }

    public virtual OfdEstatusFlujo IdEstatusNavigation { get; set; }

    public virtual PrcNumeracionFiscal IdNumeracionNavigation { get; set; }
  }
}
