using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VDetalleCompras
    {
        public string Ro { get; set; }
        public string CentroCosto { get; set; }
        public string Requisitor { get; set; }
        public string Cc { get; set; }
        public string CescripcionCentrodeCosto { get; set; }
        public DateTime? FechaSolicitada { get; set; }
        public DateTime? FechaSolicitadaEntrega { get; set; }
        public int? AñoEntrega { get; set; }
        public int? MesEntrega { get; set; }
        public string Pdkcoo { get; set; }
        public double Pddoco { get; set; }
        public string Pddcto { get; set; }
        public double Pdlnid { get; set; }
        public string Pdokco { get; set; }
        public string Pdoorn { get; set; }
        public string Pdocto { get; set; }
        public double? Pdogno { get; set; }
        public double? CantidadPedida { get; set; }
        public double? CantidadRecibida { get; set; }
        public double? CantidadPendiente { get; set; }
        public double? CostoUnitario { get; set; }
        public double? CostoTotal { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public double? CodProveedor { get; set; }
        public string Proveedor { get; set; }
        public double? CodComprador { get; set; }
        public string Comprador { get; set; }
    }
}
