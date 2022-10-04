using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AppService.Core.DTOs.Odoo.Cotizaciones.Enviar
{
    public class OdooCotizacionEnviar
    {


        public partial class OdooCotizacion
        {
            [JsonProperty("jsonrpc")]
            [JsonPropertyName("jsonrpc")]
            public string jsonrpc { get; set; } = "2.0";

            [JsonProperty("method")]
            [JsonPropertyName("method")]
            public string method { get; set; } = "call";


            [JsonProperty("params")]
            [JsonPropertyName("params")]
            public Params Params { get; set; }
        }

        public partial class Params
        {
            [JsonProperty("service")]
            [JsonPropertyName("service")]
            public string Service { get; set; } = "object";

            [JsonProperty("method")]
            [JsonPropertyName("method")]
            public string Method { get; set; } = "execute";

            [JsonProperty("args")]
            [JsonPropertyName("args")]
            public ArrayList Args { get; set; }
        }
        public class RootArgs
        {


            [JsonProperty("")]
            public string link { get; set; }

            [JsonProperty("")]
            public int const2 { get; set; }

            [JsonProperty("")]
            public string token { get; set; }

            [JsonProperty("")]
            public string integration_model { get; set; }

            [JsonProperty("")]
            public string action { get; set; }

            [JsonProperty("")]
            public string[] arrayOfStrings { get; set; }

            public ArgClass ArgClass { get; set; }
        }



        public partial class ArgClass
        {

            [JsonProperty("idCotizacion")]
            [JsonPropertyName("idCotizacion")]
            public string idCotizacion { get; set; }

            [JsonProperty("state")]
            [JsonPropertyName("state")]
            public string state { get; set; }

            [JsonProperty("idContacto")]
            [JsonPropertyName("idContacto")]
            public int idContacto { get; set; }

            [JsonProperty("idCliente")]
            [JsonPropertyName("idCliente")]
            public string idCliente { get; set; }

            [JsonProperty("idDireccionEntregar")]
            [JsonPropertyName("idDireccionEntregar")]
            public string idDireccionEntregar { get; set; }


            [JsonProperty("idDireccionFacturar")]
            [JsonPropertyName("idDireccionFacturar")]
            public string idDireccionFactrurar { get; set; }

            [JsonProperty("idCondPago")]
            [JsonPropertyName("idCondPago")]
            public string idCondPago { get; set; }

            [JsonProperty("idMtrTipoMoneda")]
            [JsonPropertyName("idMtrTipoMoneda")]
            public string idMtrTipoMoneda { get; set; }

            [JsonProperty("MonedaFacturar")]
            [JsonPropertyName("MonedaFacturar")]
            public string MonedaFacturar { get; set; }

            //"fecha": "2022-07-17 12:30:30"
            [JsonProperty("fecha")]
            [JsonPropertyName("fecha")]
            public string fecha { get; set; }


            [JsonProperty("ordenCompra")]
            [JsonPropertyName("ordenCompra")]
            public string ordenCompra { get; set; }

            [JsonProperty("observaciones")]
            [JsonPropertyName("observaciones")]
            public string observaciones { get; set; }

            [JsonProperty("idComercial")]
            [JsonPropertyName("idComercial")]
            public int idComercial { get; set; }

            [JsonProperty("idEquipoVentas")]
            [JsonPropertyName("idEquipoVentas")]
            public int idEquipoVentas { get; set; }



            [JsonProperty("OrderLines")]
            [JsonPropertyName("OrderLines")]
            public List<OrderLines> OrderLines { get; set; }


            [JsonProperty("rif")]
            [JsonPropertyName("rif")]
            public string rif { get; set; } = string.Empty;

            [JsonProperty("razonSocial")]
            [JsonPropertyName("razonSocial")]
            public string RazonSocial { get; set; } = string.Empty;

            [JsonProperty("direccion")]
            [JsonPropertyName("direccion")]
            public string direccion { get; set; } = string.Empty;

            [JsonProperty("idMunicipio")]
            [JsonPropertyName("idMunicipio")]
            public string idMunicipio { get; set; } = string.Empty;


            [JsonProperty("IdClienteOdoo")]
            [JsonPropertyName("IdClienteOdoo")]
            public int IdClienteOdoo { get; set; }

            [JsonProperty("IdContactoOdoo")]
            [JsonPropertyName("IdContactoOdoo")]
            public int IdContactoOdoo { get; set; }


        }

        public partial class OrderLines
        {

            [JsonProperty("MooreId")]
            [JsonPropertyName("MooreId")]
            public int MooreId { get; set; }


            [JsonProperty("OdooId")]
            [JsonPropertyName("OdooId")]
            public int OdooId { get; set; }

            [JsonProperty("idProducto")]
            [JsonPropertyName("idProducto")]
            public int idProducto { get; set; }

            [JsonProperty("idVariante")]
            [JsonPropertyName("idVariante")]
            public int idVariante { get; set; } = 0;

            [JsonProperty("nombreComercialProducto")]
            [JsonPropertyName("nombreComercialProducto")]
            public string nombreComercialProducto { get; set; }

            [JsonProperty("cantidadSolicitada")]
            [JsonPropertyName("cantidadSolicitada")]
            public decimal cantidadSolicitada { get; set; }

            [JsonProperty("cantidadConvertida")]
            [JsonPropertyName("cantidadConvertida")]
            public decimal cantidadConvertida { get; set; }

            [JsonProperty("precioLista")]
            [JsonPropertyName("precioLista")]
            public decimal precioLista { get; set; }

            [JsonProperty("PrecioUnitVendedor")]
            [JsonPropertyName("PrecioUnitVendedor")]
            public decimal PrecioUnitVendedor { get; set; }

            [JsonProperty("Total")]
            [JsonPropertyName("Total")]
            public decimal Total { get; set; }

            [JsonProperty("medidaBasica")]
            [JsonPropertyName("medidaBasica")]
            public decimal medidaBasica { get; set; }

            [JsonProperty("medidaOpuesta")]
            [JsonPropertyName("medidaOpuesta")]
            public decimal medidaOpuesta { get; set; }

            [JsonProperty("delete")]
            [JsonPropertyName("delete")]
            public bool delete { get; set; } = false;




        }

    }
}
