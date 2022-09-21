// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdVoBoDiseno
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdVoBoDiseno
  {
    public long IdVoBoSolicitud { get; set; }

    public short IdVoBo { get; set; }

    public long IdSolicitud { get; set; }

    public bool Estatus { get; set; }

    public string IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }

    public virtual OfdMaestroVoBo IdVoBoNavigation { get; set; }
  }
}
