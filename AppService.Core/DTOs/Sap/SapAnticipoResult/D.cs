using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs.Sap.SapAnticipoResult
{
    public class D
    {
        public __metadata __metadata { get; set; }
        public int NroRecibo { get; set; }
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
        public string DocGenerado { get; set; }
        public string EjercicioDocGenerado { get; set; }

    }

}
