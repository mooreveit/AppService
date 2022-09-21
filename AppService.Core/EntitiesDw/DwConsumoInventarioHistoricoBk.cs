using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwConsumoInventarioHistoricoBk
    {
        public short Año { get; set; }
        public short Mes { get; set; }
        public string CodigoLargo { get; set; }
        public double? CodigoCorto { get; set; }
        public string ArticuloDesc { get; set; }
        public string UndInventario { get; set; }
        public string UndCompra { get; set; }
        public double? Consumo { get; set; }
        public double? Disponible { get; set; }
        public string Categoria { get; set; }
        public string CategoriaDesc { get; set; }
        public string SubCategoria { get; set; }
        public string SubCategoriaDesc { get; set; }
        public string Glclass { get; set; }
        public string GlclassDesc { get; set; }
        public DateTime? FechaActualizado { get; set; }
        public string Ancho { get; set; }
    }
}
