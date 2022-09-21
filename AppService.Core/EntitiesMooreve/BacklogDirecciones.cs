using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class BacklogDirecciones
    {
        public long Orden { get; set; }
        public long JobId { get; set; }
        public int? Cliente { get; set; }
        public string CteFacturar { get; set; }
        public string RifFacturar { get; set; }
        public string DirecFacturar { get; set; }
        public string DirecFacturar2 { get; set; }
        public string DirecFacturar3 { get; set; }
        public string CteEntregar { get; set; }
        public string RifEntregar { get; set; }
        public string DirecEntregar { get; set; }
        public string DirecEntregar2 { get; set; }
        public string DirecEntregar3 { get; set; }
        public decimal? NumerCopya { get; set; }
        public string RifFacturarv19 { get; set; }
        public string NombFacturarv19 { get; set; }
        public string DireccFacturarv19 { get; set; }
        public string DireccFactura1v19 { get; set; }
        public string DireccFactura2v19 { get; set; }
        public string RifEntregarv19 { get; set; }
        public string NombEntregarv19 { get; set; }
        public string DireccEntregarv19 { get; set; }
        public string DireccEntrega1v19 { get; set; }
        public string DireccEntrega2v19 { get; set; }
        public string Tipo { get; set; }
        public string Producto { get; set; }
        public int? ClientePadre { get; set; }
        public decimal Iddirfacturar { get; set; }
        public decimal Iddirentregar { get; set; }
        public decimal Iddirfacturarv19 { get; set; }
        public decimal Iddirentregarv19 { get; set; }
    }
}
