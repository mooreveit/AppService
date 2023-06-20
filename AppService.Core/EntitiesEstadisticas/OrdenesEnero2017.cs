using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class OrdenesEnero2017
    {
        public double? Orden { get; set; }
        public string NomProducto { get; set; }
        public double? Partes { get; set; }
        public double? MillaresP { get; set; }
        public double? Formas { get; set; }
        public string Producto { get; set; }
        public double? Basica { get; set; }
        public double? Opuesta { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public double? IdCuota { get; set; }
        public double? IdSolicitud { get; set; }
        public double? PiesCuadrado { get; set; }
    }
}
