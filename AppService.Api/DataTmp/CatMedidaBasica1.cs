using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatMedidaBasica1
    {
        public CatMedidaBasica1()
        {
            CatMaterials = new HashSet<CatMaterial>();
        }

        public int CatMedidaBasicaId { get; set; }
        public string MedidaString { get; set; }
        public string MedidaBusqueda { get; set; }
        public decimal MedidaDecimal { get; set; }

        public virtual ICollection<CatMaterial> CatMaterials { get; set; }
    }
}
