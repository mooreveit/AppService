// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatMedidaOpuesta
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CatMedidaOpuesta
  {
    public CatMedidaOpuesta()
    {
      this.CatMaterialDetalle = (ICollection<AppService.Core.Entities.CatMaterialDetalle>) new HashSet<AppService.Core.Entities.CatMaterialDetalle>();
      this.CatMaterialDetalleTmp = (ICollection<AppService.Core.Entities.CatMaterialDetalleTmp>) new HashSet<AppService.Core.Entities.CatMaterialDetalleTmp>();
    }

    public int CatMedidaOpuestaId { get; set; }

    public string MedidaString { get; set; }

    public string MedidaBusqueda { get; set; }

    public Decimal MedidaDecimal { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatMaterialDetalle> CatMaterialDetalle { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatMaterialDetalleTmp> CatMaterialDetalleTmp { get; set; }
  }
}
