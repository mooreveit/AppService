using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Parroquias
    {
        public int IdParroquia { get; set; }
        public int IdMunicipio { get; set; }
        public string NombreParroquia { get; set; }
        public string CodigoMcpo { get; set; }
    }
}
