using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppTemplateConversionUnitGetDto
    {
        public int AppDetailQuotesId { get; set; }
        public int AppVariableId { get; set; }
        public string Description { get; set; }
        public decimal? Value { get; set; }
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }




    }
}
