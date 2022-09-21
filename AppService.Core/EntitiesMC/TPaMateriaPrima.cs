using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaMateriaPrima
    {
        public decimal Id { get; set; }
        public decimal AñoMes { get; set; }
        public string Codigo { get; set; }
        public decimal Gramaje { get; set; }
        public string DescMaterial1 { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioCreo { get; set; }
        public string UsuarioModif { get; set; }
        public decimal CostoReposicion { get; set; }
        public decimal CostoPromedio { get; set; }
        public int? Idcategoria { get; set; }
        public string Almacen { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal? CostoPromedioInicial { get; set; }
        public decimal? TotalCostoInicial { get; set; }
        public decimal? RcostoReposicion { get; set; }
        public decimal? RcostoPromedio { get; set; }
    }
}
