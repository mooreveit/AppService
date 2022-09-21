using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Printers
    {
        public decimal Recnum { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Conexion { get; set; }
        public string Servidor { get; set; }
        public string Puerto { get; set; }
        public string Ubicacion { get; set; }
    }
}
