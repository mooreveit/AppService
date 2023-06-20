using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CreCobradoCotizacion
    {
        public decimal Id { get; set; }
        public string Transaccion { get; set; }
        public decimal? Documento { get; set; }
        public decimal? DocAfecta { get; set; }
        public decimal? IdCobro { get; set; }
        public decimal? Monto { get; set; }
        public int? IdMtrTipoMoneda { get; set; }
        public DateTime? FechaTasa { get; set; }
        public decimal? UsdCobradoBancoCentral { get; set; }
        public decimal? UsdCobradoReferencial { get; set; }
        public decimal? TasaBancoCentral { get; set; }
        public decimal? TasaReferencial { get; set; }
        public string Cotizacion { get; set; }
    }
}
