using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class DefinicionTablasSap
    {
        public decimal Id { get; set; }
        public decimal? Orden { get; set; }
        public string Tabla { get; set; }
        public string Campo { get; set; }
        public string Tipo { get; set; }
        public string Longitud { get; set; }
        public string Decimales { get; set; }
        public string Descripcion { get; set; }
        public int? Prueba { get; set; }
    }
}
