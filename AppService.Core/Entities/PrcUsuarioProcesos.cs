// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.PrcUsuarioProcesos
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class PrcUsuarioProcesos
  {
    public Decimal Id { get; set; }

    public Decimal IdProceso { get; set; }

    public string Usuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual PrcObjetosProcesos IdProcesoNavigation { get; set; }
  }
}
