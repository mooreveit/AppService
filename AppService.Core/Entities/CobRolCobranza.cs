// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobRolCobranza
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobRolCobranza
  {
    public int IdRolCobranza { get; set; }

    public string IdUsuario { get; set; }

    public short IdOficina { get; set; }

    public DateTime FechaRegistro { get; set; }
  }
}
