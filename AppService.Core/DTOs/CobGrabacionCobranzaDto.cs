using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class CobGrabacionCobranzaDto
    {
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
        public string DocAfectaMostrar { get; set; }
        public string MontoMostrar { get; set; }
        public string BaseImponibleMostrar { get; set; }
        public string IvaMostrar { get; set; }
        public string MontoOriginalMostrar { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public string FechaDocumentoString { get; set; }
        public string CuentaBancaria { get; set; }
        public string Moneda { get; set; }

        public decimal BaseImponible { get; set; }
        public decimal Iva { get; set; }

        public string DocumentoSap { get; set; }
        public string EjercicioDocumentoSap { get; set; }
        public bool? PagoCorrespondeIva { get; set; }

        public string PagoCorrespondeIvaString
        {
            get { if (this.PagoCorrespondeIva==true) { return "IVA"; } else { return "BASE"; } }
           
        }

        public string ErrorMessage { get; set; }

        public string ObjectSend { get; set; }

        public bool? PagoDeMas { get; set; }

        public CobEstadoCuentaDto CobEstadoCuentaDto { get; set; }
        public List<CobPagosRetencionesDto> CobPagosRetencionesDto { get; set; }

    }
}
