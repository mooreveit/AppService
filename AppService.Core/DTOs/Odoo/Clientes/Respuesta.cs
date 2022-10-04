using System.Collections.Generic;

namespace AppService.Core.DTOs.Odoo.Clientes
{
    public class Respuesta
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


        public class Result
        {
            public bool success { get; set; }
            public List<Data> Data { get; set; }
        }


        public class Data
        {
            public int OdooId { get; set; }
            public string IdCliente { get; set; }
            public int IdContacto { get; set; }
            public bool success { get; set; }
            public string action { get; set; }
            public int IdClienteOdoo { get; set; }
            public int IdContactoOdoo { get; set; }


        }


        public string jsonrpc { get; set; }
        public object id { get; set; }
        public Result result { get; set; }


    }
}
