// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.SegPrograma
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class SegPrograma
  {
    public int IdPrograma { get; set; }

    public string NombrePrograma { get; set; }

    public string Descripcion { get; set; }

    public string TipoPrograma { get; set; }

    public bool? ParaMenu { get; set; }

    public string Link { get; set; }

    public string FlagRequerimiento { get; set; }

    public byte IdAreaNegocio { get; set; }

    public short ServidorReporte { get; set; }

    public short ServidorPublico { get; set; }
  }
}
