// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatLista
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class CatLista
  {
    public int CatListaId { get; set; }

    public long CatMaterialId { get; set; }

    public string CodigoProduct { get; set; }

    public Decimal Cantidad { get; set; }

    public Decimal IncrementoCantidad { get; set; }

    public Decimal PrecioMinimo { get; set; }

    public Decimal PrecioMaximo { get; set; }

    public Decimal IdCalculo { get; set; }

    public Decimal Duracion { get; set; }

    public string Descripcion { get; set; }

    public virtual CatMaterial CatMaterial { get; set; }

    public virtual MtrProducto CodigoProductNavigation { get; set; }
  }
}
