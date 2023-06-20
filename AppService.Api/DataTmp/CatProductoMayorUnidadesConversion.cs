using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatProductoMayorUnidadesConversion
    {
        public long CatProductoMayorUnidadesConversionId { get; set; }
        public string CodigoProduct { get; set; }
        public string Msehi { get; set; }
        public string Msehl { get; set; }
        public decimal Umrez { get; set; }
        public decimal Umren { get; set; }
        public string UnidadsapVentainterna { get; set; }
        public bool? Calculado { get; set; }

        public virtual MtrProducto CodigoProductNavigation { get; set; }
    }
}
