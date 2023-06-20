using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatCodigoMayorPartesBasica
    {
        public decimal Id { get; set; }
        public string CodigoMayor { get; set; }
        public int? Partes { get; set; }
        public string BasicaBusqueda { get; set; }
        public decimal? Frecuencia { get; set; }
    }
}
