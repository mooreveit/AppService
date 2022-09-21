// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdConstruccionCotizacion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdConstruccionCotizacion
  {
    public string Cotizacion { get; set; }

    public int Renglon { get; set; }

    public int Propuesta { get; set; }

    public string IdVariable { get; set; }

    public int IdParte { get; set; }

    public string Valor { get; set; }

    public DateTime FechaRegistro { get; set; }

    public Decimal Id { get; set; }
  }
}
