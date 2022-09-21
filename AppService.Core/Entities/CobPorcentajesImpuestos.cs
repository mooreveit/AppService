// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CobPorcentajesImpuestos
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CobPorcentajesImpuestos
  {
    public int IdPorcImpuestos { get; set; }

    public int? IdTransacccionCobranzas { get; set; }

    public Decimal? Desde { get; set; }

    public Decimal? Hasta { get; set; }

    public Decimal? Incremento { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }
  }
}
