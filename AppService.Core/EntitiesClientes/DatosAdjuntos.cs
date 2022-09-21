using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class DatosAdjuntos
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Blob { get; set; }
        public int? Estado { get; set; }
    }
}
