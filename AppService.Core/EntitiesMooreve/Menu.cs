using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Menu
    {
        public decimal Id { get; set; }
        public string Titulo { get; set; }
        public string Pagina { get; set; }
        public string Rol { get; set; }
        public decimal? Orden { get; set; }
    }
}
