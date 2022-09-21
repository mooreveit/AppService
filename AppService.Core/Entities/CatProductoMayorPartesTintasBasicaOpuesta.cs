// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuesta
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class CatProductoMayorPartesTintasBasicaOpuesta
  {
    public long CatProductoMayorPartesTintasBasicaOpuestaId { get; set; }

    public long? CatProductoMayorId { get; set; }

    public long? CatProductoMayorPartesId { get; set; }

    public long? CatProductoMayorPartesTintasId { get; set; }

    public long? CatProductoMayorPartesTintasBasicaId { get; set; }

    public string CodigoProduct { get; set; }

    public int Partes { get; set; }

    public int Tintas { get; set; }

    public string BasicaBusqueda { get; set; }

    public string OpuestaBusqueda { get; set; }

    public int Frecuencia { get; set; }
  }
}
