using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VProductos
    {
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public int CantidadXCaja { get; set; }
        public int UnidadCosteo { get; set; }
    }
}
