using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppUnitsofMeasureforMaterial
    {
        public int Id { get; set; }
        public int? AppProductsId { get; set; }
        public int? AppUnitsId { get; set; }
        public decimal? Numerator { get; set; }
        public decimal? Denominator { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual AppProduct AppProducts { get; set; }
        public virtual AppUnit AppUnits { get; set; }
    }
}
