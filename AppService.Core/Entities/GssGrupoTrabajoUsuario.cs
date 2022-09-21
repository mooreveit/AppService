// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssGrupoTrabajoUsuario
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class GssGrupoTrabajoUsuario
  {
    public int IdGrupoTrabajoUsuario { get; set; }

    public int IdGrupoTrabajo { get; set; }

    public int IdUsuario { get; set; }

    public int Secuencia { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }
  }
}
