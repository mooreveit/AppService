using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwcategoriaCuenta
    {
        public string TipoLibro { get; set; }
        public short? CategoriaId { get; set; }
        public string CategoriaDesc { get; set; }
        public short? SubCatId { get; set; }
        public string SubCatDesc { get; set; }
    }
}
