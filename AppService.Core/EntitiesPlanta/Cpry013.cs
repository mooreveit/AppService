using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry013
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public short Pais { get; set; }
        public int Cliente { get; set; }
        public int NoTransmision { get; set; }
        public DateTime FecRegVentas { get; set; }
        public DateTime? FecCreditos { get; set; }
        public DateTime? FecTransmision { get; set; }
        public DateTime? FecRecibPlant { get; set; }
        public DateTime? FecProgramada { get; set; }
        public string Estado { get; set; }
        public DateTime? FecComproClte { get; set; }
        public string TipoOrden { get; set; }
        public int CantOrdenada { get; set; }
        public int CantProducida { get; set; }
        public int CantFacturada { get; set; }
        public string NombreCliente { get; set; }
        public string DescProducto { get; set; }
        public string CodProducto { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal TotalLista { get; set; }
        public decimal TotalVenta { get; set; }
        public string LineaProduccio { get; set; }
        public string FamiliaProduct { get; set; }
        public string NombreProducto { get; set; }
        public int MedidaBase { get; set; }
        public int MedidaVariable { get; set; }
        public short PartesFormula { get; set; }
        public string CondicionProdu { get; set; }
        public string FlagProdInter { get; set; }
        public short NuTintasFrent { get; set; }
        public string PrimTintaFte { get; set; }
        public string SegTintaFte { get; set; }
        public string TercTintaFte { get; set; }
        public string CuarTintaFte { get; set; }
        public string QuintTintaFte { get; set; }
        public string SexTintaFte { get; set; }
        public short NuTintasResp { get; set; }
        public string PrimTintaResp { get; set; }
        public string SegTintaResp { get; set; }
        public string TercTintaResp { get; set; }
        public int CantProgramada { get; set; }
        public string Vendedor { get; set; }
        public string TipoEmpaque { get; set; }
        public DateTime? FecCierreOrd { get; set; }
        public short CodBacklogRet { get; set; }
        public string FacturaDolar { get; set; }
        public string FlagFactura { get; set; }
        public short LineaIncoming { get; set; }
        public string TipoProducto { get; set; }
        public string Supervisor { get; set; }
        public string FlagActivo { get; set; }
        public string LugarProducir { get; set; }
        public decimal TotalListaExt { get; set; }
        public decimal TotalVentaExt { get; set; }
        public string LugarEnviar { get; set; }
        public decimal? RprecioLista { get; set; }
        public decimal? RprecioVenta { get; set; }
        public decimal? RtotalLista { get; set; }
        public decimal? RtotalVenta { get; set; }
        public decimal? RtotalListaEx { get; set; }
        public decimal? RtotalVentaEx { get; set; }
    }
}
