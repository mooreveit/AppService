using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class DeudorTipoRetencion
    {
        public decimal Id { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public string TipoRetencion { get; set; }
        public string IndicadorRetencion { get; set; }
    }
}
