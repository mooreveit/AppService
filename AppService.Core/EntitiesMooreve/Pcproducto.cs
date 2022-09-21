using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Pcproducto
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public int? IdSubcategoria { get; set; }
    }
}
