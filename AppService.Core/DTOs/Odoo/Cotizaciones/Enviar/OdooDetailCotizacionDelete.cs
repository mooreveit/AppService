using Newtonsoft.Json;
using System.Collections;
using System.Text.Json.Serialization;

namespace AppService.Core.DTOs.Odoo.Cotizaciones.Enviar
{
    public class OdooDetailCotizacionDelete
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

            public ArgClassDetailDelete ArgClass { get; set; }
        }



        public partial class ArgClassDetailDelete
        {

            [JsonProperty("MooreId")]
            [JsonPropertyName("MooreId")]
            public int MooreId { get; set; }





        }


    }
}
