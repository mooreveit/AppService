using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VVenta
    {
        public string Cotizacion { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Renglon { get; set; }
        public decimal? Correlativo { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Tipo { get; set; }
        public decimal? Clase { get; set; }
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string CodTeleop { get; set; }
        public string LineaYFamilia { get; set; }
        public short? TipoProducto { get; set; }
        public string Sm { get; set; }
        public string CodigoProduct { get; set; }
        public string NomProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal? Partes { get; set; }
        public decimal MillaresP { get; set; }
        public decimal? Formas { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? PorcCons { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? Conteo { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? ListaDol { get; set; }
        public decimal? VentaDol { get; set; }
        public string Supervisor { get; set; }
        public string NombreRegion { get; set; }
        public string Oficina { get; set; }
        public int? OficinaReferencia { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string Fiscal { get; set; }
        public decimal? MesReorden { get; set; }
        public decimal? AnoReorden { get; set; }
        public string ProductoMayor { get; set; }
        public string ProductoMc { get; set; }
        public string ProductoMcNew { get; set; }
        public string ProductoCuota { get; set; }
        public string AuditoriaOrden { get; set; }
        public string Incoming { get; set; }
        public string Canal { get; set; }
        public string CodCliente { get; set; }
        public decimal? PiesTotal { get; set; }
        public string RangoPiesTotal { get; set; }
        public string Quater { get; set; }
        public string GerenteOficina { get; set; }
        public string Aplicacion { get; set; }
        public decimal? Idsubcategoria { get; set; }
        public decimal? PorcMcFinansc { get; set; }
        public string Nocalculamc { get; set; }
        public decimal? L03calComision { get; set; }
        public decimal? X10calPvjusto { get; set; }
        public decimal? BsMcFinansc { get; set; }
        public decimal? BsMcPapelsc { get; set; }
        public decimal KilosOrden { get; set; }
        public decimal PiesVenta { get; set; }
        public decimal PiesCuadrado { get; set; }
        public decimal PiesTotales { get; set; }
        public decimal PiesLineales { get; set; }
        public decimal? VentaDolRef { get; set; }
        public decimal? TasaDolRef { get; set; }
        public decimal? PrecioVentareconvertido { get; set; }
        public decimal? ValorVentareconvertido { get; set; }
        public string CotizacionLarga { get; set; }
        public string CotizacionCorta { get; set; }
    }
}
