using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Rutas
    {
        public string CodigoEstado { get; set; }
        public string CodigoMcpo { get; set; }
        public decimal? ZonaDespacho { get; set; }
        public decimal? PosicionRuta { get; set; }
    }
}
