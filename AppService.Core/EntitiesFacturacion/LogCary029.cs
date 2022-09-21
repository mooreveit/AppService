using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class LogCary029
    {
        public int IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public string Terminal { get; set; }
        public string Aplicacion { get; set; }
        public decimal IvaAnterior { get; set; }
        public decimal IvaNuevo { get; set; }
    }
}
