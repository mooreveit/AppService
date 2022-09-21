using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req012
    {
        public int Id { get; set; }
        public short IdCampo { get; set; }
        public string NombreCampo { get; set; }
        public short IdSubCategoria { get; set; }
        public string FlagIdUsuario { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
