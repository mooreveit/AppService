using System;

namespace AppService.Core.DTOs
{
    public class CobGeneralCobranzaDto
    {
        public long Documento { get; set; }
        public string IdCliente { get; set; }
        public string IdBanco { get; set; }
        public string IdTipoTransaccion { get; set; }
        public decimal MontoTransaccion { get; set; }
        public long NumReferencia { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public bool FlagEnviado { get; set; }
        public DateTime? FechaEnviado { get; set; }
        public bool FlagAprobado { get; set; }
        public DateTime? FechaAprobado { get; set; }
        public string UsuarioAprueba { get; set; }
        public bool? FlagConfirmado { get; set; }
        public DateTime? FechaConfirmado { get; set; }
        public string UsuarioConfirma { get; set; }
        public decimal? TotalDetalleCobrado { get; set; }
        public bool? FlagAnulado { get; set; }
        public DateTime? FechaAnulado { get; set; }
        public string UsuarioAnula { get; set; }
        public bool? FlagPagoMas { get; set; }
        public string ObsvAnulacion { get; set; }
        public string EmailCliente { get; set; }
        public double? Batch { get; set; }
        public bool FlagReversado { get; set; }
        public DateTime? FechaReversado { get; set; }
        public string UsuarioReversa { get; set; }
        public DateTime? FechaLm { get; set; }
        public bool TransferidoSap { get; set; }
        public DateTime FechaLmcxC { get; set; }
        public bool PasoIntegridadInterfase { get; set; }
        public decimal? RmontoTransaccion { get; set; }
        public decimal? RtotalDetalleCobrado { get; set; }
        public long? IdMtrTipoMoneda { get; set; }
        public string NombreCliente { get; set; }

        public string FechaTransaccionString { get; set; }

        public string NombreVendedor { get; set; }

        public string MontoTransaccionString { get; set; }

        public string vendedor { get; set; }

        public string TotalDetalleCobradoString { get; set; }

        public string Status { get; set; }

        public string NombreBanco { get; set; }

        public string  NombreTipoTransaccion { get; set; }

        public bool FlagImpuesto { get; set; }

        public string NombreTipoMoneda{ get; set; }

        public string CorreoVendedor { get; set; }

        public string TelefonoVendedor { get; set; }

        public string LinkRecibo { get; set; }

        public string SearchText { get; set; }

        public bool FlagActivaVerificacion { get; set; }

        public string MontoLetras { get; set; }

        public string FechaTransaccionIso{ get; set; }

        public int OrdenListar { get; set; }



    }
}
