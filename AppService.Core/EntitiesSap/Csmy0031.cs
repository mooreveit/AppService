using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class Csmy0031
    {
        public string Codigo { get; set; }
        public string RazonSocial { get; set; }
        public string DomicilioFiscal { get; set; }
        public string DomicilioFiscal1 { get; set; }
        public string DomicilioFiscal2 { get; set; }
        public string ClienteMatriz { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime? FechaExpide { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string DocumentosPendientes { get; set; }
        public DateTime? FechaModificado { get; set; }
        public string FlagModificado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string RifNuevo { get; set; }
        public string FlagDesactivar { get; set; }
        public string DocumentPend { get; set; }
        public int? TImpuesto { get; set; }
        public string FlagOutsoc { get; set; }
        public string CodMcpo { get; set; }
        public string CodSubsegmento { get; set; }
        public string ContEspecial { get; set; }
        public string CodEstado { get; set; }
        public string FlagCerrado { get; set; }
        public DateTime? FechaCerrado { get; set; }
        public double? CodJde { get; set; }
        public string Cambio { get; set; }
        public string SiDolares { get; set; }
        public byte[] ImagenRif { get; set; }
        public DateTime? FechaVigenciaRif { get; set; }
        public decimal? IdDireccion { get; set; }
    }
}
