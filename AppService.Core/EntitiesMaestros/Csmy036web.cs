using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Csmy036web
    {
        public int? RecordNumber { get; set; }
        public string CodigoProduct { get; set; }
        public string Nombre { get; set; }
        public string LineaProducto { get; set; }
        public string FamiliaProduct { get; set; }
        public decimal? LineaIncoming { get; set; }
        public string ImpPorConsumo { get; set; }
        public string TipoProducto { get; set; }
        public string FlagPrdIntern { get; set; }
        public string LineaYFamilia { get; set; }
        public string Codcorp { get; set; }
        public string FlagCorp { get; set; }
        public string CodprodRpg { get; set; }
        public decimal? PorcCosto { get; set; }
        public decimal? UnidadCosteo { get; set; }
        public string FlagDesact { get; set; }
        public string DescripVta { get; set; }
        public string Prefijo { get; set; }
        public decimal? Numero { get; set; }
        public decimal? CantidadXAnch { get; set; }
        public string Sufijo { get; set; }
        public Guid Rowguid { get; set; }
    }
}
