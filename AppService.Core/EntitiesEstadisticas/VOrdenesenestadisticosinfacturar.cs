using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VOrdenesenestadisticosinfacturar
    {
        public decimal? Documento { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? Orden { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? Correlativo { get; set; }
        public decimal? Renglon { get; set; }
        public string Producto { get; set; }
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
        public string FlagRetenido { get; set; }
        public long? JobId { get; set; }
        public decimal? Clase { get; set; }
        public string Anulada { get; set; }
        public string Estado { get; set; }
    }
}
