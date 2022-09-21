using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VInformacionConsultas
    {
        public int IdConsulta { get; set; }
        public long Orden { get; set; }
        public string Cotizacion { get; set; }
        public long Job { get; set; }
        public string CodigoVendedor { get; set; }
        public int CodigoOficina { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int IdMotivo { get; set; }
        public string Comentario { get; set; }
        public int? Estatus { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public short? DiasVendedor { get; set; }
        public string NombreEstatus { get; set; }
        public string AbreviadoEstatus { get; set; }
        public string NombreMotivo { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal Pmc { get; set; }
        public long? Formas { get; set; }
        public int? CodigoCliente { get; set; }
        public DateTime? FechaPrometida { get; set; }
        public string NombreVendedor { get; set; }
        public string NombreOficina { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Telefono1 { get; set; }
        public string Contacto1 { get; set; }
        public string TelCont1 { get; set; }
        public string CondPago { get; set; }
        public string Estacion1 { get; set; }
        public string Estacion2 { get; set; }
        public string Estacion3 { get; set; }
        public string Estacion4 { get; set; }
        public string Estacion5 { get; set; }
        public string Estacion6 { get; set; }
        public string Estacion7 { get; set; }
        public string Estacion8 { get; set; }
        public DateTime FechaArchivo { get; set; }
        public DateTime? FechaOrden { get; set; }
        public short? DiasVentas { get; set; }
        public short? DiasCobranza { get; set; }
        public short? DiasProduccion { get; set; }
        public string TipoProducto { get; set; }
    }
}
