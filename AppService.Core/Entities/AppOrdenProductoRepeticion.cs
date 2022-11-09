using System;

namespace AppService.Core.Entities
{
    public class AppOrdenProductoRepeticion
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public long Orden { get; set; }
        public DateTime Fecha { get; set; }
        public int AppproductsId { get; set; }
        public string AppproductsDecription { get; set; }

        public string COD_PRODUCTO { get; set; }

        public string NombreProducto { get; set; }

        public string NombreForma { get; set; }
        public int? MEDIDA_BASE { get; set; }
        public int? MEDIDA_VARIABLE { get; set; }
        public int PARTES_FORMULA { get; set; }
        public int Cant_Tintas { get; set; }
        public string PAPELPRIMERAPARTE { get; set; }
        public string PAPELSEGUNDAPARTE { get; set; }
        public string PAPELTERCERAPARTE { get; set; }
        public string PAPELCUARTAPARTE { get; set; }
        public string PAPELQUINTAPARTE { get; set; }
        public decimal? MEDIDA_BASE_DECIMAL { get; set; }
        public decimal? MEDIDA_VARIABLE_DECIMAL { get; set; }
        public string? BasicaHumano { get; set; }
        public string? OpuestaHumano { get; set; }
        public long? CANT_ORDENADA { get; set; }
        public decimal? PrecioUnitarioUsd { get; set; }
        public decimal? TotalPropuestaUsd { get; set; }
        public decimal? MedidaBasicaCm { get; set; }
        public decimal? MedidaOpuestaCm { get; set; }




    }
}
