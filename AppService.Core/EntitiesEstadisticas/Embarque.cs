using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Embarque
    {
        public int RecordNumber { get; set; }
        public string Transaccion { get; set; }
        public decimal Documento { get; set; }
        public string Tracanc { get; set; }
        public decimal? Docucanc { get; set; }
        public decimal? Cliente { get; set; }
        public string Vendedor { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? MesContable { get; set; }
        public int? AloContable { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Oficina { get; set; }
        public string NombreCliente { get; set; }
        public string NombreOficina { get; set; }
        public decimal? Municipio { get; set; }
        public string NombreMunicipio { get; set; }
        public decimal? TipoNegocio { get; set; }
        public string Usuario { get; set; }
        public decimal? PorcIva { get; set; }
        public decimal? Zona { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
