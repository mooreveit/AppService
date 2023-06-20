using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatPapel
    {
        public CatPapel()
        {
            CatMaterialDetalleTmps = new HashSet<CatMaterialDetalleTmp>();
        }

        public string CatPapelId { get; set; }
        public string Descripcion { get; set; }
        public bool EsCarbon { get; set; }

        public virtual ICollection<CatMaterialDetalleTmp> CatMaterialDetalleTmps { get; set; }
    }
}
