using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy270
    {
        public decimal CodAsignacion { get; set; }
        public decimal? CodOficina { get; set; }
        public string Descripcion { get; set; }
        public string Inactiva { get; set; }
        public DateTime? FechaCreado { get; set; }
        public string UserCreado { get; set; }
        public DateTime? FechaModificado { get; set; }
        public string UserModificado { get; set; }
        public string TipoAsig { get; set; }
    }
}
