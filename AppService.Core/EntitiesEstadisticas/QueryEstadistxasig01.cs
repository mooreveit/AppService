using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class QueryEstadistxasig01
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NoRegTribut { get; set; }
        public DateTime? FUltmCompra { get; set; }
        public string FlagInactivo { get; set; }
        public string Vendedor1 { get; set; }
        public string Asignacion { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Lista { get; set; }
    }
}
