using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TSaHistoricoCalculoCosto
    {
        public decimal Id { get; set; }
        public decimal? IdSolicitud { get; set; }
        public string Transaccion { get; set; }
        public decimal? Documento { get; set; }
        public decimal? OrdenProduccion { get; set; }
        public string NombreCliente { get; set; }
        public string Variable { get; set; }
        public string Nombre { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Monto { get; set; }
        public string VariablePadre { get; set; }
        public decimal? AñoDocumento { get; set; }
        public decimal? MesDocumento { get; set; }
        public decimal? AñoCosto { get; set; }
        public decimal? MesCosto { get; set; }
        public decimal? RecnumAuxiliar { get; set; }
        public string Producto { get; set; }
        public int? Categoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public int? Subcategoria { get; set; }
        public string DescripcionSubcategoria { get; set; }
        public int? Signo { get; set; }
    }
}
