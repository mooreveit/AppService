using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VConsultaJob
    {
        public long JobId { get; set; }
        public long Orden { get; set; }
        public string Cotizacion { get; set; }
        public int? CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public string Estacion1 { get; set; }
        public string Estacion2 { get; set; }
        public string Estacion3 { get; set; }
        public string Estacion4 { get; set; }
        public string Estacion5 { get; set; }
        public string Estacion6 { get; set; }
        public string Estacion7 { get; set; }
        public string Estacion8 { get; set; }
        public long? FormasJob { get; set; }
        public long? TotalFormas { get; set; }
        public decimal Pmc { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaArchivo { get; set; }
        public DateTime? FechaPrometida { get; set; }
        public string EstatusOrden { get; set; }
        public string NombreProducto { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public short? DiasProduccion { get; set; }
        public string CondicionPago { get; set; }
    }
}
