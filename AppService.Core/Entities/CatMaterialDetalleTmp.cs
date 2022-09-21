// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatMaterialDetalleTmp
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

namespace AppService.Core.Entities
{
  public class CatMaterialDetalleTmp
  {
    public int CatMaterialDetalleTmpId { get; set; }

    public int Parte { get; set; }

    public string CatPapelId { get; set; }

    public int CatMedidaOpuestaId { get; set; }

    public string CatCarbonId { get; set; }

    public string UserName { get; set; }

    public virtual CatMedidaOpuesta CatMedidaOpuesta { get; set; }

    public virtual CatPapel CatPapel { get; set; }
  }
}
