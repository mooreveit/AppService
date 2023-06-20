using System;
namespace AppService.Core.Entities
{
    public partial class AppDesarrolloEtiquetasPrime
    {
        public decimal Id { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? Desarrollo { get; set; }
    }
}

