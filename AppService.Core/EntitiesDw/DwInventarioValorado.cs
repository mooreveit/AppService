using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwInventarioValorado
    {
        public short Año { get; set; }
        public short Mes { get; set; }
        public string CodigoLargo { get; set; }
        public string ArticuloDesc { get; set; }
        public string Categoria { get; set; }
        public string CategoriaDesc { get; set; }
        public string SubCategoria { get; set; }
        public string SubCategoriaDesc { get; set; }
        public string Glclass { get; set; }
        public string GlclassDesc { get; set; }
        public DateTime? FechaActualizado { get; set; }
        public decimal? SaldoInicioMes { get; set; }
        public decimal? CostoPromedioInicioMes { get; set; }
        public decimal? TotalCostoInicioMes { get; set; }
        public string Almacen { get; set; }
        public decimal? CantidadComprasMes { get; set; }
        public decimal? CostoPromedioComprasMes { get; set; }
        public decimal? TotalCostoComprasMes { get; set; }
        public decimal? CantidadConsumoMes { get; set; }
        public decimal? CostoPromedioConsumoMes { get; set; }
        public decimal? TotalCostoConsumoMes { get; set; }
        public decimal? CostoPromedioConsumoMesCalculado { get; set; }
        public decimal? TotalCostoConsumoMesCalculado { get; set; }
        public decimal? CantidadAjustesMes { get; set; }
        public decimal? CostoPromedioAjustesMes { get; set; }
        public decimal? TotalCostoAjustesMes { get; set; }
        public decimal? SaldoFinal { get; set; }
        public decimal? CostoFinal { get; set; }
    }
}
