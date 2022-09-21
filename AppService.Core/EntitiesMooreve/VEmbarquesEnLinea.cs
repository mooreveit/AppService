using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VEmbarquesEnLinea
    {
        public string TituloMayor { get; set; }
        public string TituloMenor { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? Conc { get; set; }
        public int? Dia { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public decimal? BsMc { get; set; }
        public decimal? BsMcSc { get; set; }
        public long? Orden { get; set; }
        public string Articulo { get; set; }
        public DateTime FechaDocumento { get; set; }
        public decimal? Cantidad { get; set; }
        public string Cliente { get; set; }
        public int Documento { get; set; }
        public decimal? DiaHabil { get; set; }
        public int Categoria { get; set; }
        public int Subcategoria { get; set; }
        public string Vendedor { get; set; }
        public string Oficina { get; set; }
        public string NombreOficina { get; set; }
    }
}
