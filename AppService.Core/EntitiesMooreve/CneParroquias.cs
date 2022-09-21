using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CneParroquias
    {
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }
        public int IdParroquia { get; set; }
        public string Parroquia { get; set; }
    }
}
