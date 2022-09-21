using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Waiy002
    {
        public decimal Id { get; set; }
        public short? Almacen { get; set; }
        public string NombreAlmacen { get; set; }
        public string Ubicacion { get; set; }
        public decimal? Oficina { get; set; }
        public string AlmacenPrincipal { get; set; }
        public string Alias { get; set; }
    }
}
