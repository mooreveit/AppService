using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppTemplateConversionUnit
    {
        public int Id { get; set; }
        public int AppUnitIdSince { get; set; }
        public int AppUnitIdUntil { get; set; }
        public int AppVariableId { get; set; }
        public string Description { get; set; }
        public decimal? Value { get; set; }
        public string Formula { get; set; }
        public string FormulaValue { get; set; }
        public bool? SumValue { get; set; }
        public int? OrderCalculate { get; set; }
        public string Code { get; set; }
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }

        public virtual AppUnit AppUnitIdSinceNavigation { get; set; }
        public virtual AppUnit AppUnitIdUntilNavigation { get; set; }
        public virtual AppVariable AppVariable { get; set; }
    }
}
