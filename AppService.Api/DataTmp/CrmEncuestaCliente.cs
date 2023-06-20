using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CrmEncuestaCliente
    {
        public decimal IdSatisfaccion { get; set; }
        public string IdCliente { get; set; }
        public string IdConsultor { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public short NetPromoterScore { get; set; }
        public short CustomerSatisfaction { get; set; }
        public short CustomerEffortScore { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
