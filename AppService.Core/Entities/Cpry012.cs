// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.Cpry012
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class Cpry012
  {
    public Decimal Recnum { get; set; }

    public long Orden { get; set; }

    public short? Pais { get; set; }

    public int? Cliente { get; set; }

    public int NoTransmision { get; set; }

    public DateTime FecRegVentas { get; set; }

    public DateTime? FecCreditos { get; set; }

    public DateTime? FecTransmision { get; set; }

    public DateTime? FecRecibPlant { get; set; }

    public DateTime? FecProgramada { get; set; }

    public string Estado { get; set; }

    public DateTime? FecComproClte { get; set; }

    public string TipoOrden { get; set; }

    public long? CantOrdenada { get; set; }

    public long? CantProducida { get; set; }

    public long? CantFacturada { get; set; }

    public string NombreCliente { get; set; }

    public string DescProducto { get; set; }

    public string CodProducto { get; set; }

    public Decimal? PrecioLista { get; set; }

    public Decimal? PrecioVenta { get; set; }

    public Decimal? TotalLista { get; set; }

    public Decimal? TotalVenta { get; set; }

    public string LineaProducto { get; set; }

    public string FamiliaProduct { get; set; }

    public string NombreProducto { get; set; }

    public int? MedidaBase { get; set; }

    public int? MedidaVariable { get; set; }

    public short? PartesFormula { get; set; }

    public string CondicionProdu { get; set; }

    public string FlagProdInter { get; set; }

    public short? NuTintasFrent { get; set; }

    public string PrimTintaFte { get; set; }

    public string SegTintaFte { get; set; }

    public string TercTintaFte { get; set; }

    public string CuarTintaFte { get; set; }

    public string QuintTintaFte { get; set; }

    public string SexTintaFte { get; set; }

    public short? NuTintasResp { get; set; }

    public string PrimTintaResp { get; set; }

    public string SegTintaResp { get; set; }

    public string TercTintaResp { get; set; }

    public long? CantProgramada { get; set; }

    public string Vendedor { get; set; }

    public string TipoEmpaque { get; set; }

    public DateTime? FecCierreOrd { get; set; }

    public short? CodBacklogRet { get; set; }

    public string FacturaDolar { get; set; }

    public string FlagFactura { get; set; }

    public short? LineaIncoming { get; set; }

    public string TipoProducto { get; set; }

    public string Supervisor { get; set; }

    public string FlagActivo { get; set; }

    public string LugarProducir { get; set; }

    public Decimal? TotalListaExt { get; set; }

    public Decimal? TotalVentaExt { get; set; }

    public string LugarEnviar { get; set; }

    public long? CantAProducir { get; set; }

    public long? OrdenAnterior { get; set; }

    public DateTime? FechaCalculo { get; set; }

    public string OrdenComb { get; set; }

    public DateTime FechaArchivo { get; set; }

    public int? ConsArchivo { get; set; }

    public string PrefPrenStd { get; set; }

    public string PrefPrenEsp { get; set; }

    public string PrefColeStd { get; set; }

    public string PrefColeEsp { get; set; }

    public string PoncheEsp { get; set; }

    public string EmpacarEn { get; set; }

    public int? CantXPaq { get; set; }

    public string Doblez { get; set; }

    public string TipoCaja { get; set; }

    public int? CantCajas { get; set; }

    public int? CantXCajas { get; set; }

    public Decimal? Refinado { get; set; }

    public string RefinadoEn { get; set; }

    public string GomaRegPtes { get; set; }

    public string EngomaCarbPre { get; set; }

    public string EngomaCarbCol { get; set; }

    public string Cortado { get; set; }

    public string Solido { get; set; }

    public string EmbReverso { get; set; }

    public string Regular { get; set; }

    public string TranfTapeRem { get; set; }

    public string TranfTapePerm { get; set; }

    public string TranfTapeEf { get; set; }

    public int? NumeroTiras { get; set; }

    public string PartesTiras { get; set; }

    public string PosTirasF { get; set; }

    public string PosTirasR { get; set; }

    public string SalidaPreCab { get; set; }

    public string SalidaPrePie { get; set; }

    public string Impresion { get; set; }

    public string AnchosRod1 { get; set; }

    public string AnchosPts1 { get; set; }

    public string AnchosRod2 { get; set; }

    public string AnchosPts2 { get; set; }

    public short? RollosRod1 { get; set; }

    public Decimal? RollosCtd1 { get; set; }

    public string RollosPts1 { get; set; }

    public short? RollosRod2 { get; set; }

    public Decimal? RollosCtd2 { get; set; }

    public string RollosPts2 { get; set; }

    public short? RollosRod3 { get; set; }

    public Decimal? RollosCtd3 { get; set; }

    public string RollosPts3 { get; set; }

    public string Fiscal { get; set; }

    public string InstFacturar { get; set; }

    public string PoncMargIzq { get; set; }

    public string PoncMargDer { get; set; }

    public string TalonExtra { get; set; }

    public string CteEntregar { get; set; }

    public string DirecEntregar { get; set; }

    public string RifEntregar { get; set; }

    public string CteFacturar { get; set; }

    public string DirecFacturar { get; set; }

    public string RifFacturar { get; set; }

    public string FlagV19 { get; set; }

    public string Cotizacion { get; set; }

    public string StatusOrden { get; set; }

    public string DirecEntregar2 { get; set; }

    public string DirecEntregar3 { get; set; }

    public string DirecFacturar2 { get; set; }

    public string DirecFacturar3 { get; set; }

    public Decimal PorcMc { get; set; }

    public long? CtdEntregada { get; set; }

    public Decimal? VentaUnitDol { get; set; }

    public Decimal? ListaUnitDol { get; set; }

    public int? FormasUndFact { get; set; }

    public string VinetaImpresa { get; set; }

    public string Anulada { get; set; }

    public short? CondPago { get; set; }

    public Decimal? Tasa { get; set; }

    public Decimal? VentaTotDolar { get; set; }

    public Decimal? ListaTotDolar { get; set; }

    public DateTime? FechaDolar { get; set; }

    public string SiColetilla { get; set; }

    public string SiIndexado { get; set; }

    public string SiDolares { get; set; }

    public long? CtdNc { get; set; }

    public int Anticipo { get; set; }

    public short LineaAnt { get; set; }

    public string ClaseOrden { get; set; }

    public string RifImprimir { get; set; }

    public string CodTeleop { get; set; }

    public string Excepcion { get; set; }

    public Decimal? PorcCom { get; set; }

    public Decimal? POverrideG { get; set; }

    public Decimal? POverrideCg { get; set; }

    public Decimal? Comision { get; set; }

    public Decimal? POverride { get; set; }

    public Decimal? PCobranza { get; set; }

    public Decimal? POverger { get; set; }

    public Decimal? POverrideGo { get; set; }

    public short? Tabla { get; set; }

    public string FlagSoportev { get; set; }

    public string Web { get; set; }

    public string Adelantada { get; set; }

    public string AutorizaAde { get; set; }

    public string ImprimeDol { get; set; }

    public short? CodAplicacion { get; set; }

    public Decimal? Impout { get; set; }

    public Decimal? Impvar { get; set; }

    public Decimal? PorcMcPapel { get; set; }

    public Decimal? PorcMcFinan { get; set; }

    public Decimal? BsMcPapel { get; set; }

    public Decimal? BsMcFinan { get; set; }

    public Decimal? CambioCompo { get; set; }

    public Decimal? PorcMcPapelsc { get; set; }

    public Decimal? PorcMcFinansc { get; set; }

    public Decimal? BsMcPapelsc { get; set; }

    public Decimal? BsMcFinansc { get; set; }

    public int? Idcalendar { get; set; }

    public Decimal? AnticipoJde { get; set; }

    public Decimal? LineaAntJde { get; set; }

    public string Nocalculamc { get; set; }

    public Decimal? RprecioLista { get; set; }

    public Decimal? RprecioVenta { get; set; }

    public Decimal? RtotalLista { get; set; }

    public Decimal? RtotalVenta { get; set; }

    public Decimal? RtotalListaEx { get; set; }

    public Decimal? RtotalVentaEx { get; set; }

    public Decimal? Rcomision { get; set; }

    public Decimal? RbsMcPapel { get; set; }

    public Decimal? RbsMcFinan { get; set; }

    public Decimal? RbsMcPapelsc { get; set; }

    public Decimal? RbsMcFinansc { get; set; }

    public Decimal? Rtasa { get; set; }

    public string Idcalendar2 { get; set; }

    public Decimal? An8facturar { get; set; }

    public Decimal? An8entregar { get; set; }

    public Decimal? PorcMcPapelE { get; set; }

    public Decimal? PorcMcFinanE { get; set; }

    public Decimal? BsMcPapelE { get; set; }

    public Decimal? BsMcFinanE { get; set; }

    public Decimal? PorcMcpapelsce { get; set; }

    public Decimal? PorcMcfinansce { get; set; }

    public Decimal? BsMcPapelsce { get; set; }

    public Decimal? BsMcFinansce { get; set; }

    public Decimal? CantidadRodada { get; set; }

    public string Ws { get; set; }

    public Decimal? IdSolicitud { get; set; }

    public Decimal? IdSolicitud2 { get; set; }

    public string RecalcularMargen { get; set; }

    public Decimal? IdDirFacturar { get; set; }

    public Decimal? IdDirEntregar { get; set; }

    public string EstadoFacturar { get; set; }

    public string MunicipioFacturar { get; set; }

    public string EstadoEntregar { get; set; }

    public string MunicipioEntregar { get; set; }

    public Decimal? PorcRespSocial { get; set; }

    public Decimal? PorcComRegulada { get; set; }

    public Decimal? PorcMcMinimo { get; set; }

    public int? IdCombinada { get; set; }

    public Decimal? IdSolicitudCosto { get; set; }

    public bool? Plantilla { get; set; }
  }
}
