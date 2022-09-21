using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class DatosAdjuntos
    {
        public int? NumCot { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Blob { get; set; }
        public int? Estado { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
