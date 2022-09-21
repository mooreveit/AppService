// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatProductoMayor
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class CatProductoMayor
  {
    public long CatProductoMayorId { get; set; }

    public string CodigoProduct { get; set; }

    public string Descripcion { get; set; }

    public int Frecuencia { get; set; }

    public bool? EsRollo { get; set; }

    public string Inactivo { get; set; }
  }
}
