using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Waiy003
    {
        public decimal Id { get; set; }
        public short? Almacen { get; set; }
        public short? CodTransaccion { get; set; }
        public int? Documento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public long? Cliente { get; set; }
        public int? CondPago { get; set; }
        public int? TipoIva { get; set; }
        public decimal? Orden { get; set; }
        public string Cotizacion { get; set; }
        public decimal? OrdenCompra { get; set; }
        public string Observaciones { get; set; }
        public short? AlmacenReceptor { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
        public string Usuario { get; set; }
        public string FormaImp { get; set; }
    }
}
