using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wivy196
    {
        public decimal Id { get; set; }
        public string Cia { get; set; }
        public string Tiporequisicion { get; set; }
        public string Requisicion { get; set; }
        public string Linearequisicion { get; set; }
        public string Tipooc { get; set; }
        public string Ordendecompra { get; set; }
        public string Lineaordendecompra { get; set; }
        public DateTime? Fechaordendecompra { get; set; }
        public string Articulo { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public decimal? Comprador { get; set; }
        public string Nombrecomprador { get; set; }
        public decimal? Proveedor { get; set; }
        public string Nombreproveedor { get; set; }
        public decimal? Cantidadsolicitada { get; set; }
        public string Unidademedida { get; set; }
        public decimal? Cantidadrecibida { get; set; }
        public DateTime? Fechadecolocacionoc { get; set; }
        public DateTime? Fechaentregasolicitada { get; set; }
        public DateTime? Fecharecepcionplanta { get; set; }
        public decimal? Diasentrega { get; set; }
        public decimal? Diasatraso { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fechadesde { get; set; }
        public DateTime? Fechahasta { get; set; }
        public DateTime? Fechaactualizacion { get; set; }
        public decimal? Unitario { get; set; }
        public decimal? Montorecibido { get; set; }
        public string Lote { get; set; }
    }
}
