using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatListum
    {
        public int CatListaId { get; set; }
        public long CatMaterialId { get; set; }
        public string CodigoProduct { get; set; }
        public decimal Cantidad { get; set; }
        public decimal IncrementoCantidad { get; set; }
        public decimal PrecioMinimo { get; set; }
        public decimal PrecioMaximo { get; set; }
        public decimal IdCalculo { get; set; }
        public decimal Duracion { get; set; }
        public string Descripcion { get; set; }

        public virtual CatMaterial CatMaterial { get; set; }
        public virtual MtrProducto CodigoProductNavigation { get; set; }
    }
}
