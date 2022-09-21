using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Winy245
    {
        public string IdEstado { get; set; }
        public string IdMunicipio { get; set; }
        public int IdParroquia { get; set; }
        public string NombreParroquia { get; set; }

        public virtual Winy243 Id { get; set; }
    }
}
