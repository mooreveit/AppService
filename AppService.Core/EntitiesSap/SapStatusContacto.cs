using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapStatusContacto
    {
        public int Id { get; set; }
        public string IdEstatusContactoSap { get; set; }
        public string IdEstatusContacto265 { get; set; }
        public bool IdEstatusContactoOd { get; set; }
        public string NombreEstatus { get; set; }
    }
}
