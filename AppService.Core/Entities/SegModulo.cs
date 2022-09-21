// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.SegModulo
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class SegModulo
  {
    public int IdModulo { get; set; }

    public string NombreModulo { get; set; }

    public string LinkModulo { get; set; }

    public string Descripcion { get; set; }

    public int? IndiceModulo { get; set; }

    public int? IdPrograma { get; set; }

    public int? IdModuloPadre { get; set; }

    public short? TipoLlamada { get; set; }

    public string Icono { get; set; }

    public short? ServidorReporte { get; set; }

    public string RutaReporte { get; set; }

    public string NombreReporte { get; set; }

    public short? IdTipoReporte { get; set; }

    public string FlagPortafolioReportes { get; set; }

    public string IconoMenu { get; set; }
  }
}
