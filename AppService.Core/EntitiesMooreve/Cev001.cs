using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cev001
    {
        public long IdRegistro { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public string Vendedor { get; set; }
        public short Oficina { get; set; }
        public string Supervisor { get; set; }
        public short CategoriaVendedor { get; set; }
        public short NumeroOrdenesImpresas { get; set; }
        public decimal CumplimientoCuotasVentas { get; set; }
        public decimal VolumenImpresos { get; set; }
        public decimal VolumenEtiquetas { get; set; }
        public decimal VolumenIc { get; set; }
        public decimal VolumenCpo { get; set; }
        public decimal VolumenCutSheets { get; set; }
        public decimal VolumenOfficeProduct { get; set; }
        public decimal PorcentajeMc { get; set; }
        public decimal IndiceRnc { get; set; }
        public short CantidadRetencionesIva { get; set; }
        public short ClientesNuevos { get; set; }
        public short MesesCobertura { get; set; }
        public decimal CrecimientoVentas { get; set; }
        public short DiasCalle { get; set; }
        public decimal PuntosVolumenImpresos { get; set; }
        public decimal PuntosVolumenEtiquetas { get; set; }
        public decimal PuntosVolumenIc { get; set; }
        public decimal PuntosVolumenCpo { get; set; }
        public decimal PuntosVolumenCutSheets { get; set; }
        public decimal PuntosVolumenOfficeProduct { get; set; }
        public decimal PuntosNumeroOrdenesImpresas { get; set; }
        public decimal PuntosDiasCalle { get; set; }
        public decimal PuntosClientesNuevos { get; set; }
        public decimal PuntosMesesCobertura { get; set; }
        public decimal PuntosIndiceRnc { get; set; }
        public decimal PuntosPorcentajeMc { get; set; }
        public decimal PuntosVolumenAdicional { get; set; }
        public decimal PuntosCantidadRetencionesIvaislr { get; set; }
        public decimal TotalPuntos { get; set; }
        public string EquipoInsert { get; set; }
        public string UsuarioInsert { get; set; }
        public DateTime FechaInsert { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime? FechaUpdate { get; set; }
    }
}
