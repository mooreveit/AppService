using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatMedidaOpuestum
    {
        public CatMedidaOpuestum()
        {
            CatMaterialDetalleTmps = new HashSet<CatMaterialDetalleTmp>();
            CatMaterialDetalles = new HashSet<CatMaterialDetalle>();
        }

        public int CatMedidaOpuestaId { get; set; }
        public string MedidaString { get; set; }
        public string MedidaBusqueda { get; set; }
        public decimal MedidaDecimal { get; set; }

        public virtual ICollection<CatMaterialDetalleTmp> CatMaterialDetalleTmps { get; set; }
        public virtual ICollection<CatMaterialDetalle> CatMaterialDetalles { get; set; }
    }
}
