using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class InventarioJobDirecto
    {
        public long Orden { get; set; }
        public long? Job { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public bool Procesado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaProcesado { get; set; }
    }
}
