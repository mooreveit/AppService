// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.SapFrecuenciaVisitaCliente
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class SapFrecuenciaVisitaCliente
  {
    public string IdCliente { get; set; }

    public short IdFrecuenciaVisita { get; set; }

    public short IdSemanaVisita { get; set; }

    public short IdDiaVisita { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime FechaActualiza { get; set; }

    public string UsuarioActualiza { get; set; }
  }
}
