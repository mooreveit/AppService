// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CreCotizacionDocumento
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CreCotizacionDocumento
  {
    public Decimal Id { get; set; }

    public string Cotizacion { get; set; }

    public Decimal? Documento { get; set; }

    public string UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string UsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }
  }
}
