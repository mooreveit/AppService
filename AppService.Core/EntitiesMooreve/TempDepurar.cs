using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class TempDepurar
    {
        public string Base { get; set; }
        public string NombreTabla { get; set; }
        public string Campo { get; set; }
        public bool? Eliminar { get; set; }
        public decimal? Registros { get; set; }
    }
}
