using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs.SapEstadoCuentaResult
{
    public class EstadoCuentaSap
    {

        public string DocumentoSAP { get; set; }
        public string DocumentoExterno { get; set; }

        public string Correlativo { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaDoc { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string ClaseDoc { get; set; }
      
        public decimal Monto { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Saldo { get; set; }
        public string Moneda { get; set; }
        public string DebeHaber { get; set; }
        public string Signo { get; set; }
        public string Texto { get; set; }
    }
}
