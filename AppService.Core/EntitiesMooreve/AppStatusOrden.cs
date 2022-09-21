using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AppStatusOrden
    {
        public int Id { get; set; }
        public string Cotizacion { get; set; }
        public string Orden { get; set; }
        public bool? Ventas { get; set; }
        public bool? Administracion { get; set; }
        public bool? Planta { get; set; }
        public bool? Facturacion { get; set; }
        public bool? Despacho { get; set; }
        public bool? Cliente { get; set; }
    }
}
