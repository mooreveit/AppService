using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class VWivy001
    {
        public int? RecordNumber { get; set; }
        public decimal? Compania { get; set; }
        public decimal? Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
        public decimal? CodigoPais { get; set; }
        public decimal? CodigoCiudad { get; set; }
        public decimal? CodigoEstado { get; set; }
        public string Origen { get; set; }
        public decimal? Categoria { get; set; }
        public string Rif { get; set; }
        public string CodPostal { get; set; }
        public string Tlf { get; set; }
        public string Fax { get; set; }
        public string Persona { get; set; }
        public decimal? FormaPago { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaUpdate { get; set; }
        public DateTime? UltimaCompra { get; set; }
        public string UltimoProducto { get; set; }
        public decimal? UltimoBs { get; set; }
        public decimal? UltimoDolares { get; set; }
        public string Observaciones { get; set; }
        public decimal? Status { get; set; }
        public decimal? Clasificacion { get; set; }
        public DateTime? FechaEva { get; set; }
        public string NombreCheque { get; set; }
        public decimal? MontoAcumulado { get; set; }
        public decimal? ImpAcumulado { get; set; }
        public string Especial { get; set; }
        public decimal? PorcRet { get; set; }
        public string Email { get; set; }
        public decimal? TipoImpueto { get; set; }
        public string PasoSql { get; set; }
    }
}
