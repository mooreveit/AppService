using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AppOrdenesGrabadasProducto
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime? Dia { get; set; }
        public string DiaChar { get; set; }
        public int? CantFormas { get; set; }
        public decimal? BsFormas { get; set; }
        public int? CantEtiquetas { get; set; }
        public decimal? BsEtiquetas { get; set; }
        public int? CantIcpp { get; set; }
        public decimal? BsIcpp { get; set; }
        public int? CantCustomPrint { get; set; }
        public decimal? BsCustomPrint { get; set; }
        public int? CantOfficeProduct { get; set; }
        public decimal? BsOfficeProduct { get; set; }
        public int? CantTotal { get; set; }
        public decimal? BsTotal { get; set; }
        public string BsFormasChar { get; set; }
        public string BsEtiquetasChar { get; set; }
        public string BsIcppchar { get; set; }
        public string BsCustomPrintChar { get; set; }
        public string BsOfficeProductChar { get; set; }
        public string BsTotalChar { get; set; }
        public decimal? VentaDolar { get; set; }
        public string VentaDolarChar { get; set; }
        public decimal? BsEiqSr { get; set; }
        public int? CantEtiqSr { get; set; }
        public string BsEiqSrchar { get; set; }
    }
}
