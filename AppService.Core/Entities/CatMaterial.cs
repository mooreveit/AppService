// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.CatMaterial
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class CatMaterial
  {
    public CatMaterial()
    {
      this.CatLista = (ICollection<AppService.Core.Entities.CatLista>) new HashSet<AppService.Core.Entities.CatLista>();
      this.CatMaterialDetalle = (ICollection<AppService.Core.Entities.CatMaterialDetalle>) new HashSet<AppService.Core.Entities.CatMaterialDetalle>();
    }

    public long CatMaterialId { get; set; }

    public string Codigo { get; set; }

    public string CodigoProduct { get; set; }

    public string Descripcion { get; set; }

    public int Partes { get; set; }

    public int Tintas { get; set; }

    public int CatMedidaBasicaId { get; set; }

    public string Combinacion { get; set; }

    public string PapelesBusqueda { get; set; }

    public string OpuestaBusqueda { get; set; }

    public string BasicaBusqueda { get; set; }

    public string CarbonBusqueda { get; set; }

    public long? CatProductoMayorId { get; set; }

    public long? CatProductoMayorPartesId { get; set; }

    public long? CatProductoMayorPartesTintasId { get; set; }

    public long? CatProductoMayorPartesTintasBasicaId { get; set; }

    public long? CatProductoMayorPartesTintasBasicaOpuestaId { get; set; }

    public long? CatProductoMayorPartesTintasBasicaOpuestaPapelesId { get; set; }

    public long? CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbonId { get; set; }

    public Decimal? CalibrePapelRollos { get; set; }

    public Decimal? BasicaDecimal { get; set; }

    public string ManejaInv { get; set; }

    public virtual CatMedidaBasica1 CatMedidaBasica { get; set; }

    public virtual MtrProducto CodigoProductNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatLista> CatLista { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatMaterialDetalle> CatMaterialDetalle { get; set; }
  }
}
