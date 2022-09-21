using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Listado
    {
        public string Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public double? Precio1 { get; set; }
        public double? Cant1 { get; set; }
        public double? Precio2 { get; set; }
        public double? Cant2 { get; set; }
        public string Precio3 { get; set; }
        public string Cant3 { get; set; }
        public string Precio4 { get; set; }
        public string Cant4 { get; set; }
        public decimal Id { get; set; }
    }
}
