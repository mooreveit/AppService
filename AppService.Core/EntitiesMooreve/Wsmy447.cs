using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy447
    {
        public decimal IdReg { get; set; }
        public string Cotizacion { get; set; }
        public string Producto { get; set; }
        public string Estado { get; set; }
        public string TipoEstado { get; set; }
        public DateTime? Fecha { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
    }
}
