using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry216
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public string Cotizacion { get; set; }
        public int CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string FechaOrden { get; set; }
        public string FechaArchivo { get; set; }
        public string FechaPrometida { get; set; }
        public string FechaNueva { get; set; }
        public string FechaFactura { get; set; }
        public string FechaDespacho { get; set; }
        public short DiasHabiles { get; set; }
        public short CodOficina { get; set; }
        public string NombreOficina { get; set; }
        public short CodRegion { get; set; }
        public string NombreRegion { get; set; }
        public string NombreForma { get; set; }
        public long FormasPedida { get; set; }
        public long FormasPdtes { get; set; }
        public decimal ListaUnitario { get; set; }
        public decimal ListaTotal { get; set; }
        public decimal VentaUnitario { get; set; }
        public decimal VentaTotal { get; set; }
        public string StatusOrden { get; set; }
        public string ImpStock { get; set; }
        public string Estacion1 { get; set; }
        public string Estacion2 { get; set; }
        public string Estacion3 { get; set; }
        public string Estacion4 { get; set; }
        public string Estacion5 { get; set; }
        public long Cantidad1 { get; set; }
        public long Cantidad2 { get; set; }
        public long Cantidad3 { get; set; }
        public long Cantidad4 { get; set; }
        public long Cantidad5 { get; set; }
        public string Planificacion { get; set; }
        public string AtencionCte { get; set; }
        public string Despacho { get; set; }
        public string CodigoSuperv { get; set; }
        public string NombreSuperv { get; set; }
        public string CodigoGerente { get; set; }
        public long CantidadEntreg { get; set; }
        public string SugerenciaPlan { get; set; }
        public string SugerenciaAten { get; set; }
        public string SugerenciaDesp { get; set; }
        public long Job { get; set; }
        public string Reoperacion { get; set; }
        public string FecEstEsta1 { get; set; }
        public string FecEstEsta2 { get; set; }
        public string FecEstEsta3 { get; set; }
        public string FecEstEsta4 { get; set; }
        public string FecEstEsta5 { get; set; }
        public string GerenteRegion { get; set; }
        public string NombreGteReg { get; set; }
        public string EnvioCarta8 { get; set; }
        public decimal? RlistaUnitario { get; set; }
        public decimal? RlistaTotal { get; set; }
        public decimal? RventaUnitario { get; set; }
        public decimal? RventaTotal { get; set; }
    }
}
