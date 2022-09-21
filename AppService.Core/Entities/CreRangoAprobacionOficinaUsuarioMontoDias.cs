// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CreRangoAprobacionOficinaUsuarioMontoDias
  {
    public Decimal Id { get; set; }

    public short Oficina { get; set; }

    public string Usuario { get; set; }

    public Decimal MontoDesde { get; set; }

    public Decimal MontoHasta { get; set; }

    public int DiasDesde { get; set; }

    public int DiasHasta { get; set; }

    public bool Administradora { get; set; }

    public Decimal? RmontoDesde { get; set; }

    public Decimal? RmontoHasta { get; set; }
  }
}
