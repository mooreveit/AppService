using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Auxiliarcuota
    {
        public int CodigoOficina { get; set; }
        public int Idcategoria { get; set; }
        public int Idsubcategoria { get; set; }
        public decimal? Porcentaje { get; set; }
        public int? Idproductocuota { get; set; }

        public virtual Wsmy436 IdcategoriaNavigation { get; set; }
        public virtual Wsmy438 IdproductocuotaNavigation { get; set; }
        public virtual Wsmy437 IdsubcategoriaNavigation { get; set; }
    }
}
