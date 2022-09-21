// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrProducto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class MtrProducto
  {
    public MtrProducto()
    {
      this.CatLista = (ICollection<AppService.Core.Entities.CatLista>) new HashSet<AppService.Core.Entities.CatLista>();
      this.CatMaterial = (ICollection<AppService.Core.Entities.CatMaterial>) new HashSet<AppService.Core.Entities.CatMaterial>();
      this.CatProductoMayorUnidadesConversion = (ICollection<AppService.Core.Entities.CatProductoMayorUnidadesConversion>) new HashSet<AppService.Core.Entities.CatProductoMayorUnidadesConversion>();
      this.OfdRenglon = (ICollection<AppService.Core.Entities.OfdRenglon>) new HashSet<AppService.Core.Entities.OfdRenglon>();
    }

    public Decimal Recnum { get; set; }

    public string CodigoProduct { get; set; }

    public string Nombre { get; set; }

    public string LineaProducto { get; set; }

    public string FamiliaProduct { get; set; }

    public short? LineaIncoming { get; set; }

    public string ImpPorConsumo { get; set; }

    public short? TipoProducto { get; set; }

    public string FlagPrdIntern { get; set; }

    public string Codcorp { get; set; }

    public string FlagCorp { get; set; }

    public string CodprodRpg { get; set; }

    public int? PorcCosto { get; set; }

    public short? UnidadCosteo { get; set; }

    public string FlagDesact { get; set; }

    public string DescripVta { get; set; }

    public string Prefijo { get; set; }

    public short? Numero { get; set; }

    public short? CantidadXAnch { get; set; }

    public string Sufijo { get; set; }

    public string Titulo { get; set; }

    public string TituloVentas { get; set; }

    public string TituloPe { get; set; }

    public string Web { get; set; }

    public string Titulo1 { get; set; }

    public string Titulo2 { get; set; }

    public string Titulo3 { get; set; }

    public short? CodResponsable { get; set; }

    public string Titulo4 { get; set; }

    public short? Titulo5 { get; set; }

    public string PrintNoPrint { get; set; }

    public short? Titulo6 { get; set; }

    public string CodJde { get; set; }

    public Decimal Idsubcategoria { get; set; }

    public Decimal? PorcMcAprob { get; set; }

    public string FlagRollo { get; set; }

    public Decimal? CostoReposicion { get; set; }

    public string Miscelaneo { get; set; }

    public string CategoriaDashBoard { get; set; }

    public int? MetodoCalculoMc { get; set; }

    public long? OrdenInterna { get; set; }

    public string FlagCortoTiraje { get; set; }

    public string FlagPrecioMinimo { get; set; }

    public Decimal PesoKilos { get; set; }

    public string CodigoCaja { get; set; }

    public string Almacensap { get; set; }

    public string Unidadsap { get; set; }

    public string SujetoALote { get; set; }

    public bool? FlagImpComercial { get; set; }

    public string UnidadsapVenta { get; set; }

    public string UnidadsapVentainterna { get; set; }

    public Decimal? Consecutivo { get; set; }

    public string DescripcionVentas { get; set; }

    public string IdUnidadCosteoSap { get; set; }

    public Decimal? PiesCuadradoUnidad { get; set; }

    public bool? RequiereAnticipo { get; set; }

    public string ManejaInv { get; set; }

    public virtual T006a IdUnidadCosteoSapNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatLista> CatLista { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatMaterial> CatMaterial { get; set; }

    public virtual ICollection<AppService.Core.Entities.CatProductoMayorUnidadesConversion> CatProductoMayorUnidadesConversion { get; set; }

    public virtual ICollection<AppService.Core.Entities.OfdRenglon> OfdRenglon { get; set; }
  }
}
