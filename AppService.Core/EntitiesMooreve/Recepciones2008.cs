using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Recepciones2008
    {
        public string Cia { get; set; }
        public string TipoRequisicion { get; set; }
        public string Requisicion { get; set; }
        public double? LineaRequisicion { get; set; }
        public string TipoOc { get; set; }
        public double OrdenDeCompra { get; set; }
        public double LineaOrdenDeCompra { get; set; }
        public DateTime? FechaOrdenDeCompra { get; set; }
        public string Articulo { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public double? Comprador { get; set; }
        public string NombreComprador { get; set; }
        public double? Proveedor { get; set; }
        public string NombreProveedor { get; set; }
        public double? CantidadSolicitada { get; set; }
        public string UnidaDeMedida { get; set; }
        public double? CantidaRecibida { get; set; }
        public DateTime? FechaDeColocacionOc { get; set; }
        public DateTime? FechaEntregaSolicitada { get; set; }
        public DateTime? FechaDeRecepcionPlanta { get; set; }
        public double? Unitario { get; set; }
        public double? MontoRecibido { get; set; }
        public string Lote { get; set; }
    }
}
