// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatMedidaBasica1
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CatMedidaBasica1
  {
    public CatMedidaBasica1() => this.CatMaterial = (ICollection<AppService.Core.Entities.CatMaterial>) new HashSet<AppService.Core.Entities.CatMaterial>();

    public int CatMedidaBasicaId { get; set; }

    public string MedidaString { get; set; }

    public string MedidaBusqueda { get; set; }

    public Decimal MedidaDecimal { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatMaterial> CatMaterial { get; set; }
  }
}
