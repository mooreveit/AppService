using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class CobPagosRetencionesDto
    {
        public long Id { get; set; }
        public long IdCobranza { get; set; }
        public int IdTransaccion { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool FlagComprobanteNo { get; set; }
        public string NroComprobante { get; set; }
        public DateTime FechaComprobante { get; set; }
        public decimal? Rmonto { get; set; }

        public string NombreTransaccion { get; set; }
        public string MontoString { get; set; }

        public string FechaComprobanteString { get; set; }

        public string TxOrigen { get; set; }

        

    }
}
