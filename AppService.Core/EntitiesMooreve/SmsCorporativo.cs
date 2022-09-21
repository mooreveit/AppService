using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class SmsCorporativo
    {
        public long Id { get; set; }
        public string Ruta { get; set; }
        public string Bat { get; set; }
        public string Parametros { get; set; }
        public DateTime Fecha { get; set; }
        public string Depurar { get; set; }
    }
}
