using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny206
    {
        public decimal Recnum { get; set; }
        public int Factura { get; set; }
        public short CentroFact { get; set; }
        public short TipoDoc { get; set; }
        public short Pais { get; set; }
        public int Cliente { get; set; }
        public long Orden { get; set; }
        public string OrdenCompra { get; set; }
        public string CredConta { get; set; }
        public string Vendedor { get; set; }
        public decimal Flete { get; set; }
        public decimal Seguro { get; set; }
        public decimal OtroGasto1 { get; set; }
        public decimal OtroGasto2 { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal ValorLista { get; set; }
        public decimal ValorListad { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorVentad { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string Dolar { get; set; }
        public string Transmision { get; set; }
        public string RegistroTribut { get; set; }
        public string Nombre { get; set; }
        public string FlagComision { get; set; }
        public string Supervisor { get; set; }
        public string TotalParcial { get; set; }
        public short CodigoRepetici { get; set; }
        public DateTime? FechaRecibCli { get; set; }
        public int FactFinal { get; set; }
        public string Anulada { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string GiroNegocio { get; set; }
        public string VendGestion { get; set; }
        public string MultiplesEmb { get; set; }
        public short CondicionPago { get; set; }
        public string DireccFiscal { get; set; }
        public short UnidadFacturar { get; set; }
        public int Remision { get; set; }
        public short AnoFactura { get; set; }
        public short MesFactura { get; set; }
        public string Direccion1 { get; set; }
        public string Obs { get; set; }
        public short Imp { get; set; }
        public long Nit { get; set; }
        public int Cajas { get; set; }
        public string Direccion2 { get; set; }
        public DateTime? FechaDespacho { get; set; }
        public DateTime? FechaRemision { get; set; }
        public string Fiscal { get; set; }
        public string ImpStock { get; set; }
        public string FlagImpreso { get; set; }
        public string Observacion1 { get; set; }
        public string Observacion2 { get; set; }
        public string Observacion3 { get; set; }
        public decimal TasaImpuesto { get; set; }
        public short CondPago { get; set; }
        public short Copy { get; set; }
    }
}
