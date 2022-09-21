using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppDetailQuotesConversionUnitCreateDto
    {
        public int AppGeneralQuotesId { get; set; }
        public int AppProductId { get; set; }
        public int AppDetailQuotesId { get; set; }
        public int AppUnitIdSince { get; set; }
        public int AppUnitIdUntil { get; set; }

        public List<AppTemplateConversionUnitGetDto> AppTemplateConversionUnitGetDto { get; set; }

    }
}
