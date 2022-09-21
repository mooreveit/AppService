using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Civy004web2
    {
        public string Producto { get; set; }
        public decimal PreListActual { get; set; }
        public decimal PrecLista { get; set; }
        public string Descripcion { get; set; }
        public int CantidadXCaja { get; set; }
        public string LineaProducto { get; set; }
        public string TipoProducto { get; set; }
        public string Medida { get; set; }
        public short? UnidadCosteo { get; set; }
        public DateTime FechaVigencia { get; set; }
        public string Eliminado { get; set; }
        public short? CodResponsable { get; set; }
    }
}
