using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy277
    {
        public int CodMotivo { get; set; }
        public int CodGrupo { get; set; }
        public int? CodDefinicion { get; set; }
        public string DescripcionMotivo { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UserModificacion { get; set; }
    }
}
