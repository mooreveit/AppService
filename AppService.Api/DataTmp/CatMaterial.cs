using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatMaterial
    {
        public CatMaterial()
        {
            CatLista = new HashSet<CatListum>();
            CatMaterialDetalles = new HashSet<CatMaterialDetalle>();
        }

        public long CatMaterialId { get; set; }
        public string Codigo { get; set; }
        public string CodigoProduct { get; set; }
        public string Descripcion { get; set; }
        public int Partes { get; set; }
        public int Tintas { get; set; }
        public int CatMedidaBasicaId { get; set; }
        public string Combinacion { get; set; }
        public string PapelesBusqueda { get; set; }
        public string OpuestaBusqueda { get; set; }
        public string BasicaBusqueda { get; set; }
        public string CarbonBusqueda { get; set; }
        public long? CatProductoMayorId { get; set; }
        public long? CatProductoMayorPartesId { get; set; }
        public long? CatProductoMayorPartesTintasId { get; set; }
        public long? CatProductoMayorPartesTintasBasicaId { get; set; }
        public long? CatProductoMayorPartesTintasBasicaOpuestaId { get; set; }
        public long? CatProductoMayorPartesTintasBasicaOpuestaPapelesId { get; set; }
        public long? CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbonId { get; set; }
        public decimal? CalibrePapelRollos { get; set; }
        public decimal? BasicaDecimal { get; set; }
        public string ManejaInv { get; set; }

        public virtual CatMedidaBasica1 CatMedidaBasica { get; set; }
        public virtual MtrProducto CodigoProductNavigation { get; set; }
        public virtual ICollection<CatListum> CatLista { get; set; }
        public virtual ICollection<CatMaterialDetalle> CatMaterialDetalles { get; set; }
    }
}
