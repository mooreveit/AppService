using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapCobranzas
    {
        public decimal Id { get; set; }
        public string Mandt { get; set; }
        public decimal NroRc { get; set; }
        public decimal IdCobranzas { get; set; }
        public decimal IdRetenciones { get; set; }
        public string Sociedad { get; set; }
        public string CodigoCliente { get; set; }
        public string Moneda { get; set; }
        public string DocumentoCobrar { get; set; }
        public string FechaDocumento { get; set; }
        public string FechaContabilizacion { get; set; }
        public string Referencia { get; set; }
        public string TextoCabecera { get; set; }
        public string CuentaContableSap { get; set; }
        public string TextoPosicion { get; set; }
        public decimal? Monto { get; set; }
        public string DocumentoSap { get; set; }
        public string TipoTransaccion { get; set; }
        public string Anulacion { get; set; }
        public string FechaAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string Procesado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool PasoIntegridadInterfase { get; set; }
        public string Bukrs { get; set; }
        public string Gjahr { get; set; }
        public string Belnr { get; set; }
        public string Buzei { get; set; }
        public string IndicadorRetencion { get; set; }
        public decimal? BaseRetencion { get; set; }
        public decimal? Rmonto { get; set; }
        public decimal? RbaseRetencion { get; set; }
    }
}
