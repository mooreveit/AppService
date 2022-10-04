using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry024
    {
        public decimal Recnum { get; set; }
        public short Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Idcausa { get; set; }
        public string Flaginactivo { get; set; }
        public string Usuarioagrega { get; set; }
        public DateTime? Fechaagrega { get; set; }
        public string Usuariomodifica { get; set; }
        public DateTime? Fechamodifica { get; set; }
    }
}
