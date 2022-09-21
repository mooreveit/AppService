// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssPasoSolicitud
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class GssPasoSolicitud
  {
    public short IdPasoSolicitud { get; set; }

    public long IdSolicitud { get; set; }

    public bool DatosGenerales { get; set; }

    public bool TareasServicios { get; set; }

    public bool CamposAdicionales { get; set; }

    public bool AdjuntosObservaciones { get; set; }

    public virtual GssSolicitud IdSolicitudNavigation { get; set; }
  }
}
