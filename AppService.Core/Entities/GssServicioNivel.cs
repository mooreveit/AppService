// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.GssServicioNivel
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class GssServicioNivel
  {
    public int IdServicioNivel { get; set; }

    public int IdServicio { get; set; }

    public int IdNivel { get; set; }

    public short Secuencia { get; set; }

    public DateTime FechaCambio { get; set; }

    public int UsuarioCambio { get; set; }

    public virtual GssNivel IdNivelNavigation { get; set; }

    public virtual GssServicios IdServicioNavigation { get; set; }
  }
}
