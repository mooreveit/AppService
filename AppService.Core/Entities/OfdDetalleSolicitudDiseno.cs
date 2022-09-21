// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdDetalleSolicitudDiseno
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdDetalleSolicitudDiseno
  {
    public long IdDetalleSolicitud { get; set; }

    public long IdSolicitud { get; set; }

    public short NumeroAnotacion { get; set; }

    public string Anotacion { get; set; }

    public byte[] Imagen { get; set; }

    public string NombreImagen { get; set; }

    public string IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
  }
}
