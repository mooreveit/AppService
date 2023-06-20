using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VVentasAñoMesVendedorCategoriaSubcategorium
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
        public string NombOfic { get; set; }
        public int? CodOficina { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? PiesCuadrado { get; set; }
    }
}
