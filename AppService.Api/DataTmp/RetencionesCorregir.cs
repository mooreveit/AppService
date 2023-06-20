using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class RetencionesCorregir
    {
        public string Sociedad { get; set; }
        public string Documento { get; set; }
        public string Ejercicio { get; set; }
        public string Posicion { get; set; }
        public string TipoRetenciones { get; set; }
        public string IndicadorRetenciN { get; set; }
        public string CertificadoRetencion { get; set; }
        public string FechaCertificadoRetencion { get; set; }
    }
}
