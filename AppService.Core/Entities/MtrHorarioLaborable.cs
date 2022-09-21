// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrHorarioLaborable
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class MtrHorarioLaborable
  {
    public short IdHorario { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Fin { get; set; }

    public string Laborable { get; set; }

    public string PrimerBloque { get; set; }

    public string Almuerzo { get; set; }
  }
}
