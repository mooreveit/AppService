// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssAprobacionServicio
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class GssAprobacionServicio
  {
    public long IdAprobacionServicio { get; set; }

    public long IdTarea { get; set; }

    public int IdNivel { get; set; }

    public int IdUsuario { get; set; }

    public short IdEstatusTarea { get; set; }

    public short IdGrupoTrabajo { get; set; }

    public short Secuencia { get; set; }

    public short SecuenciaServicio { get; set; }

    public DateTime FechaEntrada { get; set; }

    public DateTime? FechaSalida { get; set; }

    public string Observacion { get; set; }

    public virtual GssEstatusTarea IdEstatusTareaNavigation { get; set; }

    public virtual GssNivel IdNivelNavigation { get; set; }

    public virtual GssTarea IdTareaNavigation { get; set; }

    public virtual SegUsuario IdUsuarioNavigation { get; set; }
  }
}
