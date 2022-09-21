using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AppService.Core.DTOs.SapEnviarSoloRetencion
{
    public class D
    {
        [JsonIgnore]
        public long? Id { get; set; }
        public int NroRecibo { get; set; }
        public string Sociedad { get; set; }
        public string Cliente { get; set; }
        public string TxOrigen { get; set; }
        public string DocCobroSAP { get; set; }
        public string FechaCobroReal { get; set; }
        public string FechaContabilizacion { get; set; }
        public string Referencia { get; set; }
        public string TextoCab { get; set; }
        public string TextoPos { get; set; }
        public string Monto { get; set; }
        public string Moneda { get; set; }
        public string IndRetencion { get; set; }
        public string BaseRetencion { get; set; }

    }
}
