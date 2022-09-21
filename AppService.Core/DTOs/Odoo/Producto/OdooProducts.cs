using Newtonsoft.Json;
using System;
using System.Collections;
using System.Text.Json.Serialization;

namespace AppService.Core.DTOs.Odoo.Producto.OdooProducts
{


    public partial class OdooProducts
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
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("standard_price")]
        [JsonPropertyName("standard_price")]
        public decimal StandardPrice { get; set; }

        [JsonProperty("sales_behavior")]
        [JsonPropertyName("sales_behavior")]
        public string SalesBehavior { get; set; }

        [JsonProperty("list_price")]
        [JsonPropertyName("list_price")]
        public decimal ListPrice { get; set; }

        [JsonProperty("default_code")]
        [JsonPropertyName("default_code")]
        public string DefaultCode { get; set; }

        [JsonProperty("sale_ok")]
        [JsonPropertyName("sale_ok")]
        public bool SaleOk { get; set; }

        [JsonProperty("detailed_type")]
        [JsonPropertyName("detailed_type")]
        public string DetailedType { get; set; }

        [JsonProperty("invoice_policy")]
        [JsonPropertyName("invoice_policy")]
        public string InvoicePolicy { get; set; }

        [JsonProperty("uom_id")]
        [JsonPropertyName("uom_id")]
        public Id UomId { get; set; }

        [JsonProperty("uom_po_id")]
        [JsonPropertyName("uom_po_id")]
        public Id UomPoId { get; set; }

        [JsonProperty("taxes_id")]
        [JsonPropertyName("taxes_id")]
        public Id[] TaxesId { get; set; }

        [JsonProperty("categ_id")]
        [JsonPropertyName("categ_id")]
        public Id CategId { get; set; }
    }

    public partial class Id
    {
        [JsonProperty("default_code")]
        [JsonPropertyName("default_code")]
        public string DefaultCode { get; set; }

        public static implicit operator string(Id v)
        {
            throw new NotImplementedException();
        }
    }

    //public partial struct ArgUnion
    //{
    //    public ArgClass[] ArgClassArray;
    //    public long? Integer;
    //    public string String;

    //    public static implicit operator ArgUnion(ArgClass[] ArgClassArray) => new ArgUnion { ArgClassArray = ArgClassArray };
    //    public static implicit operator ArgUnion(long Integer) => new ArgUnion { Integer = Integer };
    //    public static implicit operator ArgUnion(string String) => new ArgUnion { String = String };
    //}
}




