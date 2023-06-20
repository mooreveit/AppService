using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobGrabacionCobranza
    {
        public CobGrabacionCobranza()
        {
            CobPagosRetenciones = new HashSet<CobPagosRetencione>();
        }

        public long Id { get; set; }
        public long? Documento { get; set; }
        public string Transaccion { get; set; }
        public decimal DocAfecta { get; set; }
        public decimal? Monto { get; set; }
        public string Cotizacion { get; set; }
        public double Rpdoc { get; set; }
        public string Rpdct { get; set; }
        public string Rpkco { get; set; }
        public string Rpsfx { get; set; }
        public string DocAfectaSap { get; set; }
        public decimal? Rmonto { get; set; }
        public string DocumentoSap { get; set; }
        public string EjercicioDocumentoSap { get; set; }
        public bool? PagoCorrespondeIva { get; set; }
        public bool PasoIntegridadInterfase { get; set; }
        public string ErrorMessage { get; set; }
        public string ObjectSend { get; set; }
        public bool? PagoDeMas { get; set; }
        public decimal? TasaBancoCentral { get; set; }
        public decimal? MontoBs { get; set; }
        public DateTime? FechaTasa { get; set; }
        public decimal? RmontoBs { get; set; }
        public decimal? RtasaBancoCentral { get; set; }
        public decimal? MontoReconvertido { get; set; }

        public virtual CobGeneralCobranza DocumentoNavigation { get; set; }
        public virtual CobTransaccione TransaccionNavigation { get; set; }
        public virtual ICollection<CobPagosRetencione> CobPagosRetenciones { get; set; }
    }
}
