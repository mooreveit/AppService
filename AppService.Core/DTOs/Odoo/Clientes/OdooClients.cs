using AppService.Core.DTOs.Odoo.Direccion;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AppService.Core.DTOs.Odoo.Clientes.OdooClients
{


    public partial class OdooClients
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
        [JsonProperty("company_type")]
        [JsonPropertyName("company_type")]
        public string company_type { get; set; }

        [JsonProperty("IdContacto")]
        [JsonPropertyName("IdContacto")]
        public int IdContacto { get; set; }

        [JsonProperty("IdCliente")]
        [JsonPropertyName("IdCliente")]
        public string IdCliente { get; set; }

        [JsonProperty("Rif")]
        [JsonPropertyName("Rif")]
        public string Rif { get; set; }

        [JsonProperty("Nombre")]
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("Telefono")]
        [JsonPropertyName("Telefono")]
        public string Telefono { get; set; }

        [JsonProperty("Celular")]
        [JsonPropertyName("Celular")]
        public string Celular { get; set; }


        [JsonProperty("Email")]
        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonProperty("Poder")]
        [JsonPropertyName("Poder")]
        public string Poder { get; set; }

        [JsonProperty("Cargo")]
        [JsonPropertyName("Cargo")]
        public string Cargo { get; set; }


        [JsonProperty("Departamento")]
        [JsonPropertyName("Departamento")]
        public string Departamento { get; set; }

        [JsonProperty("TipoNegocio")]
        [JsonPropertyName("TipoNegocio")]
        public string TipoNegocio { get; set; }

        [JsonProperty("Sector")]
        [JsonPropertyName("Sector")]
        public string Sector { get; set; }

        [JsonProperty("Ramo")]
        [JsonPropertyName("Ramo")]
        public string Ramo { get; set; }

        [JsonProperty("Direccion")]
        [JsonPropertyName("Direccion")]
        public string Direccion { get; set; }

        [JsonProperty("Direccion2")]
        [JsonPropertyName("Direccion2")]
        public string Direccion2 { get; set; }

        [JsonProperty("Ciudad")]
        [JsonPropertyName("Ciudad")]
        public string Ciudad { get; set; }


        [JsonProperty("CodigoPostal")]
        [JsonPropertyName("CodigoPostal")]
        public string CodigoPostal { get; set; }


        [JsonProperty("Pais")]
        [JsonPropertyName("Pais")]
        public string Pais { get; set; }

        [JsonProperty("Estado")]
        [JsonPropertyName("Estado")]
        public string Estado { get; set; }


        [JsonProperty("Municipio")]
        [JsonPropertyName("Municipio")]
        public string Municipio { get; set; }

        [JsonProperty("company_ref")]
        [JsonPropertyName("company_ref")]
        public string company_ref { get; set; } = "1";


        [JsonProperty("IdComerciante")]
        [JsonPropertyName("IdComerciante")]
        public int IdComerciante { get; set; }

        [JsonProperty("ClienteInactivo")]
        [JsonPropertyName("ClienteInactivo")]
        public bool ClienteInactivo { get; set; }

        [JsonProperty("IdClienteOdoo")]
        [JsonPropertyName("IdClienteOdoo")]
        public int IdClienteOdoo { get; set; }

        [JsonProperty("IdContactoOdoo")]
        [JsonPropertyName("IdContactoOdoo")]
        public int IdContactoOdoo { get; set; }


        [JsonProperty("Direcciones")]
        [JsonPropertyName("Direcciones")]
        public List<Direcciones> Direcciones { get; set; }


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

    public partial struct ArgUnion
    {
        public ArgClass[] ArgClassArray;
        public long? Integer;
        public string String;

        public static implicit operator ArgUnion(ArgClass[] ArgClassArray) => new ArgUnion { ArgClassArray = ArgClassArray };
        public static implicit operator ArgUnion(long Integer) => new ArgUnion { Integer = Integer };
        public static implicit operator ArgUnion(string String) => new ArgUnion { String = String };
    }
}




