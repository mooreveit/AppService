// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.OfdPlantillaPreset
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class OfdPlantillaPreset
  {
    public Decimal Id { get; set; }

    public string CodProducto { get; set; }

    public string Ordenreferencia { get; set; }

    public string Orden { get; set; }

    public string Basica { get; set; }

    public string Opuesta { get; set; }

    public Decimal? Partes { get; set; }

    public string Papel { get; set; }

    public string Grupopapel { get; set; }

    public Decimal? Cantitintas { get; set; }

    public Decimal? Cambioscomposicion { get; set; }

    public Decimal? Cantfranjastransfertape { get; set; }

    public string Tienecarbonspot { get; set; }

    public string Talonextra { get; set; }

    public string Carbon { get; set; }

    public string Medidaopuestacarbon { get; set; }

    public string Nombreproducto { get; set; }

    public Decimal? Millares { get; set; }

    public Decimal? PrecioMaximoMillar { get; set; }

    public Decimal? IdSolicitud { get; set; }
  }
}
