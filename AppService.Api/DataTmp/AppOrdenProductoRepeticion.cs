using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppOrdenProductoRepeticion
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public long? Orden { get; set; }
        public DateTime? Fecha { get; set; }
        public int? AppproductsId { get; set; }
        public string AppproductsDecription { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public string NombreForma { get; set; }
        public int? MedidaBase { get; set; }
        public int? MedidaVariable { get; set; }
        public int? PartesFormula { get; set; }
        public int? CantTintas { get; set; }
        public string Papelprimeraparte { get; set; }
        public string Papelsegundaparte { get; set; }
        public string Papelterceraparte { get; set; }
        public string Papelcuartaparte { get; set; }
        public string Papelquintaparte { get; set; }
        public decimal? MedidaBaseDecimal { get; set; }
        public decimal? MedidaVariableDecimal { get; set; }
        public string BasicaHumano { get; set; }
        public string OpuestaHumano { get; set; }
        public long? CantOrdenada { get; set; }
        public decimal? PrecioUnitarioUsd { get; set; }
        public decimal? TotalPropuestaUsd { get; set; }
        public decimal? MedidaBasicaCm { get; set; }
        public decimal? MedidaOpuestaCm { get; set; }
    }
}
