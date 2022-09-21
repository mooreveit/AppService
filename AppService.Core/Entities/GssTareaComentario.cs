// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssTareaComentario
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class GssTareaComentario
  {
    public long IdComentarioTarea { get; set; }

    public long IdTarea { get; set; }

    public DateTime FechaComentario { get; set; }

    public string ComentarioTarea { get; set; }

    public short IdUsuario { get; set; }

    public virtual GssTarea IdTareaNavigation { get; set; }
  }
}
