using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class ReporteCotizacionDto
    {

        
        public string ParametroCotizacion { get; set; }
        public string Cotizacion { get; set; }

        public string ParametroFlagTotal { get; set; }
        public bool FlagTotal { get; set; }

        public string ParametroFlagFormasCaja { get; set; }
        public bool FlagFormasCaja { get; set; }

        public string ParametroFlagIva { get; set; }
        public bool FlagIva { get; set; }

        public string ParametroObservaciones { get; set; }
        public bool Observaciones { get; set; }

        public string ParametroImprimirUsd { get; set; }
        public bool ImprimirUsd { get; set; }
        


    }
}
