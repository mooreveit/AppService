using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class ConsultaWmsy270
    {
        public string CodAsignacion { get; set; }
        public string CodOficina { get; set; }
        public string Descripcion { get; set; }
        public string Inactiva { get; set; }
        public DateTime? FechaCreado { get; set; }
        public string UserCreado { get; set; }
        public DateTime? FechaModificado { get; set; }
    }
}
