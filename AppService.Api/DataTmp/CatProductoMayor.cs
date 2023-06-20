using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatProductoMayor
    {
        public long CatProductoMayorId { get; set; }
        public string CodigoProduct { get; set; }
        public string Descripcion { get; set; }
        public int Frecuencia { get; set; }
        public bool? EsRollo { get; set; }
        public string Inactivo { get; set; }
    }
}
