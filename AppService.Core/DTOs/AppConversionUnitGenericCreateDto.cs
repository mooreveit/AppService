using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppConversionUnitGenericCreateDto
    {
        public int AppProductId { get; set; }
        public int AppUnitIdSince { get; set; }
        public int AppUnitIdUntil { get; set; }
        public List<AppTemplateConversionGenericUnitGetDto> AppTemplateConversionGenericUnitGetDto { get; set; }

    }
}
