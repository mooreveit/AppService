using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class VCobrosDiasTranscurrido
    {
        public long Id { get; set; }
        public int? AñoContable { get; set; }
        public int? MesContable { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CodOficina { get; set; }
        public string Oficina { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string Transaccion { get; set; }
        public long? Documento { get; set; }
        public decimal DocAfecta { get; set; }
        public long IdMoneda { get; set; }
        public string Moneda { get; set; }
        public decimal? Monto { get; set; }
        public decimal? MontoBs { get; set; }
        public decimal? MontoUsd { get; set; }
        public string Cotizacion { get; set; }
        public double Rpdoc { get; set; }
        public string Rpdct { get; set; }
        public string Rpkco { get; set; }
        public string Rpsfx { get; set; }
        public string DocAfectaSap { get; set; }
        public string DocumentoSap { get; set; }
        public string EjercicioDocumentoSap { get; set; }
        public decimal? TasaBancoCentral { get; set; }
        public DateTime? FechaTasa { get; set; }
        public string IdTipoTransaccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaLm { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public bool? PagoCorrespondeIva { get; set; }
        public string Banco { get; set; }
        public int? Dias { get; set; }
        public string Titulo { get; set; }
        public decimal? SoloBs { get; set; }
        public decimal? SoloUsd { get; set; }
        public string NombreRegion { get; set; }
        public string FacturaNd { get; set; }
    }
}
