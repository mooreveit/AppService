using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AppService.Core.DTOs.SapAnticipo
{
    public class d
    {

        [JsonIgnore]
        public long? Id { get; set; }
        [JsonIgnore]
        public string Transaccion { get; set; }

        public long NroRecibo { get; set; }
        public string Sociedad { get; set; }
        public string Cliente { get; set; }
        public string DocCobroSAP { get; set; }
        public string FechaCobroReal { get; set; }
        public string FechaContabilizacion { get; set; }
        public string Referencia { get; set; }
        public string TextoCab { get; set; }
        public string CuentaBancaria { get; set; }
        public string TextoPos { get; set; }
        public string Monto { get; set; }
        public string Moneda { get; set; }

       



    }
}
