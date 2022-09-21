// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatProductoMayorPartesTintas
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class CatProductoMayorPartesTintas
  {
    public long CatProductoMayorPartesTintasId { get; set; }

    public long? CatProductoMayorId { get; set; }

    public long? CatProductoMayorPartesId { get; set; }

    public string CodigoProduct { get; set; }

    public int Partes { get; set; }

    public int Tintas { get; set; }

    public int Frecuencia { get; set; }
  }
}
