using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VMcembSincomision
    {
        public decimal? Documento { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Cliente { get; set; }
        public string Vendedor { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? ValorVenta { get; set; }
        public string TipoProdu { get; set; }
        public string Producto { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? Totalmatsincomision { get; set; }
        public decimal? Bsmcsincomision { get; set; }
        public decimal? Porcmcsincomision { get; set; }
    }
}
