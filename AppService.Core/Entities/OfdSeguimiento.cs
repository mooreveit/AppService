// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdSeguimiento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdSeguimiento
  {
    public int IdSeguimiento { get; set; }

    public long IdSolicitud { get; set; }

    public short IdEstacion { get; set; }

    public string IdEstatus { get; set; }

    public string Usuario { get; set; }

    public string Comentarios { get; set; }

    public DateTime FechaEntrada { get; set; }

    public DateTime? FechaSalida { get; set; }

    public virtual OfdMaestroEstacion IdEstacionNavigation { get; set; }

    public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
  }
}
