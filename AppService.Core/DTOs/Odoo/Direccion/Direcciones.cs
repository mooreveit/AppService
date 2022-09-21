using Newtonsoft.Json;
using System.Text.Json.Serialization;
namespace AppService.Core.DTOs.Odoo.Direccion
{
    public class Direcciones
    {
        [JsonProperty("OdooId")]
        [JsonPropertyName("OdooId")]
        public int OdooId { get; set; }


        [JsonProperty("MooreId")]
        [JsonPropertyName("MooreId")]
        public string MooreId { get; set; }

        [JsonProperty("Calle1")]
        [JsonPropertyName("Calle1")]
        public string Calle1 { get; set; }


        [JsonProperty("Calle2")]
        [JsonPropertyName("Calle2")]
        public string Calle2 { get; set; }

        [JsonProperty("Ciudad")]
        [JsonPropertyName("Ciudad")]
        public string Ciudad { get; set; }

        [JsonProperty("IdPais")]
        [JsonPropertyName("IdPais")]
        public string IdPais { get; set; }


        [JsonProperty("IdEstado")]
        [JsonPropertyName("IdEstado")]
        public string IdEstado { get; set; }

        [JsonProperty("IdMunicipio")]
        [JsonPropertyName("IdMunicipio")]
        public string IdMunicipio { get; set; }


        [JsonProperty("CodigoPostal")]
        [JsonPropertyName("CodigoPostal")]
        public string CodigoPostal { get; set; }

        [JsonProperty("Facturacion")]
        [JsonPropertyName("Facturacion")]
        public bool Facturacion { get; set; }

        [JsonProperty("Envio")]
        [JsonPropertyName("Envio")]
        public bool Envio { get; set; }


        [JsonProperty("PorDefecto")]
        [JsonPropertyName("PorDefecto")]
        public bool PorDefecto { get; set; }



    }
}
