using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class Consultaajdunto
    {
        public string Codigo { get; set; }
        public int? Estado { get; set; }
        public byte[] Blob { get; set; }
        public string Descripcion { get; set; }
    }
}
