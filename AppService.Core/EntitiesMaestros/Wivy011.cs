using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy011
    {
        public decimal Recnum { get; set; }
        public int NroReq { get; set; }
        public short Item { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public string Descripcion3 { get; set; }
        public string Unidad { get; set; }
        public int Proveedor { get; set; }
        public short AOUltCompra { get; set; }
        public short MesUltCompra { get; set; }
        public decimal UltPunitBs { get; set; }
        public decimal UltPunitDo { get; set; }
        public int UltProv { get; set; }
        public decimal PrecioUnitBs { get; set; }
        public decimal PrecioUnitDo { get; set; }
        public decimal CantidadPedida { get; set; }
        public decimal CantidadRecibi { get; set; }
        public DateTime? FechaRecibida { get; set; }
        public DateTime? FechaEstimada { get; set; }
        public string ItemCompleto { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public short GrupAprobacion { get; set; }
        public string FlagRecorrido { get; set; }
        public short TipoComercio { get; set; }
        public string Solicitante { get; set; }
        public string Comprador { get; set; }
        public DateTime? FechaColocada { get; set; }
        public DateTime? FechaRecCompr { get; set; }
        public DateTime? FechaAnulada { get; set; }
        public DateTime? FechaCotiza { get; set; }
        public decimal CtdRecibidaIr { get; set; }
        public decimal Ancho { get; set; }
    }
}
