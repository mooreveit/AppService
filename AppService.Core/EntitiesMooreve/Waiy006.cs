using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Waiy006
    {
        public decimal Id { get; set; }
        public short? Almacen { get; set; }
        public short? CodTransaccion { get; set; }
        public int? Documento { get; set; }
        public string Producto { get; set; }
        public decimal? Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string Descripcion { get; set; }
    }
}
