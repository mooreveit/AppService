// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatProductoMayorUnidadesConversion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CatProductoMayorUnidadesConversion
  {
    public long CatProductoMayorUnidadesConversionId { get; set; }

    public string CodigoProduct { get; set; }

    public string Msehi { get; set; }

    public string Msehl { get; set; }

    public Decimal Umrez { get; set; }

    public Decimal Umren { get; set; }

    public string UnidadsapVentainterna { get; set; }

    public bool? Calculado { get; set; }

    public virtual MtrProducto CodigoProductNavigation { get; set; }
  }
}
