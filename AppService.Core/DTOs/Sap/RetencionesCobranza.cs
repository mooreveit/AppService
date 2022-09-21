using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AppService.Core.DTOs.Sap
{
    public class RetencionesCobranza
    {
        [JsonIgnore]
        public long? Id { get; set; }
        public string TxOrigen { get; set; }
        public string Referencia { get; set; }
        public string TextoCab { get; set; }
        public string TextoPos { get; set; }
        public string Monto { get; set; }
        public string Moneda { get; set; }
        public string IndRetencion { get; set; }
        public string BaseRetencion { get; set; }

     	/*"RetencionesCobranza": [
			{
				"TxOrigen":"06",
				"Referencia":"REF",
				"TextoCab":"Retencion 06",
				"TextoPos":"Retencion 06",
				"Monto":"3.10",
				"Moneda":"USD",
				"IndRetencion":"01",
				"BaseRetencion":"4.14"

            }*/

}
}
