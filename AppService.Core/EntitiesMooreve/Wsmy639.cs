using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy639
    {
        public long RecNum { get; set; }
        public long Id { get; set; }
        public decimal IdSolicitud { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioApp { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Rif { get; set; }
        public string IdProducto { get; set; }
        public string NombreForma { get; set; }
        public decimal Millares { get; set; }
        public long? CantidadRollos { get; set; }
        public long? FormasPorRollo { get; set; }
        public int MedidaBasica { get; set; }
        public int MedidaOpuesta { get; set; }
        public short CantidadTintas { get; set; }
        public short CambComposicion { get; set; }
        public short CantTransferTape { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? PorMcFinan { get; set; }
        public decimal? PorMcBruto { get; set; }
        public decimal? PorcComision { get; set; }
        public decimal? FactorSdf { get; set; }
        public bool? FlagAprobado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public short? Ano { get; set; }
        public short? Mes { get; set; }
        public string RecalcularMargen { get; set; }
        public decimal? Duracion { get; set; }
        public decimal? PorcRespSocial { get; set; }
        public decimal? PorcComRegulada { get; set; }
        public decimal? PorcMcMinimo { get; set; }
        public decimal? PorcTolerancia { get; set; }
        public string Observaciones { get; set; }
        public string Cotizacion { get; set; }
        public int? Renglon { get; set; }
        public int? Propuesta { get; set; }
        public bool? FlagEnviado { get; set; }
        public bool? FlagCerrado { get; set; }
        public string IdEstatus { get; set; }
        public short? IdFlujo { get; set; }
        public bool? FlagVolumen { get; set; }
        public int? IdTablaCpj { get; set; }
        public decimal? PorcCpj { get; set; }
        public decimal? BsListaCpj { get; set; }
        public decimal? TotalBsListaCpj { get; set; }
        public string FlagTipoRechazo { get; set; }
        public decimal? PorcLista { get; set; }
        public decimal? BsListaCpjminimo { get; set; }
        public decimal? TotalBsListaCpjminimo { get; set; }
        public decimal? PorcGananciaCpjmanual { get; set; }
        public string MensajeError { get; set; }
        public decimal? ValorVentaAprobar { get; set; }
        public DateTime? FechaPrecio { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public decimal ValorVentaUsd { get; set; }
        public decimal? TotalVentaUsd { get; set; }
        public decimal? UsdListaCpj { get; set; }
        public decimal? TotalUsdListaCpj { get; set; }
        public decimal? UsdListaCpjminimo { get; set; }
        public decimal? TotalUsdListaCpjminimo { get; set; }
        public decimal? ValorVentaAprobarUsd { get; set; }
        public bool? FijarPrecioBs { get; set; }
        public bool? FijarPrecioBsAprobado { get; set; }
        public decimal? RvalorVenta { get; set; }
        public decimal? RtotalVenta { get; set; }
        public decimal? RbsListaCpj { get; set; }
        public decimal? RtotalBsListaCpj { get; set; }
        public decimal? RvalorVentaAprobar { get; set; }
    }
}
