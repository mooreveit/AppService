using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class DataInicial
    {
        public decimal Id { get; set; }
        public string Data { get; set; }
        public string Archivo { get; set; }
        public decimal? Lote { get; set; }
        public decimal? OrdenArchivo { get; set; }
    }
}
