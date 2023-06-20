using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppProductConversion
    {
        public int Id { get; set; }
        public int? AppProductsId { get; set; }
        public int? AppUnitsIdAlternativa { get; set; }
        public decimal? XNumerador { get; set; }
        public int? AppUnitsIdBase { get; set; }
        public decimal? YDenominador { get; set; }

        public virtual AppProduct AppProducts { get; set; }
        public virtual AppUnit AppUnitsIdAlternativaNavigation { get; set; }
        public virtual AppUnit AppUnitsIdBaseNavigation { get; set; }
    }
}
