using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VBonomcdetalle
    {
        public decimal? Bsmc { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? PorcComision { get; set; }
        public decimal? Comision { get; set; }
        public decimal? Porcbonomc { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Bono { get; set; }
        public decimal? Conteo { get; set; }
        public string Vendedor { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? Bonoreal { get; set; }
        public string Producto { get; set; }
        public string TipoProdu { get; set; }
    }
}
