using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ajustar
    {
        public double? Recnum { get; set; }
        public double? Orden { get; set; }
        public string Articulo { get; set; }
        public double? Cantidad { get; set; }
        public double? ValorLista { get; set; }
        public double? ValorVenta { get; set; }
        public double? PrecioLista { get; set; }
        public double? PlistaPrueba { get; set; }
        public double? PrecioVenta { get; set; }
        public double? PventaPrueba { get; set; }
        public double? Cantreal { get; set; }
        public double? Plistareal { get; set; }
        public double? Pventareal { get; set; }
    }
}
