// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdFlujoEstacion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdFlujoEstacion
  {
    public short IdFlujoEstacion { get; set; }

    public short IdEstacionActual { get; set; }

    public short IdEstacionAprueba { get; set; }

    public short IdEstacionRechaza { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual OfdMaestroEstacion IdEstacionActualNavigation { get; set; }
  }
}
