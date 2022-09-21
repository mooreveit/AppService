using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs.SapEstadoCuentaResult
{
    public class Results
    {
        public __metadata __metadata { get; set; }
        public string Correlativo { get; set; }
        public string Cliente { get; set; }
        public string FechaDoc { get; set; }
        public string FechaVencimiento { get; set; }
        public string ClaseDoc { get; set; }
        public string DocumentoSAP { get; set; }
        public string DocumentoExterno { get; set; }
        public string Monto { get; set; }
        public string BaseImponible { get; set; }
        public string Impuesto { get; set; }
        public string Saldo { get; set; }
        public string Moneda { get; set; }
        public string DebeHaber { get; set; }
        public string Signo { get; set; }
        public string Texto { get; set; }
      

    }
}
