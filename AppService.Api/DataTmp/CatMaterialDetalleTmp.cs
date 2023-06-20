using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatMaterialDetalleTmp
    {
        public int CatMaterialDetalleTmpId { get; set; }
        public int Parte { get; set; }
        public string CatPapelId { get; set; }
        public int CatMedidaOpuestaId { get; set; }
        public string CatCarbonId { get; set; }
        public string UserName { get; set; }

        public virtual CatMedidaOpuestum CatMedidaOpuesta { get; set; }
        public virtual CatPapel CatPapel { get; set; }
    }
}
