using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppDetailQuotesConversionUnit
    {
        public int Id { get; set; }
        public int? AppDetailQuotesId { get; set; }
        public int? AppVariableId { get; set; }
        public string Description { get; set; }
        public decimal? Value { get; set; }
        public string Formula { get; set; }
        public string FormulaValue { get; set; }
        public bool? SumValue { get; set; }
        public int? OrderCalculate { get; set; }
        public string Code { get; set; }
        public decimal? Min { get; set; }
        public decimal? Max { get; set; }

        public virtual AppDetailQuote AppDetailQuotes { get; set; }
        public virtual AppVariable AppVariable { get; set; }
    }
}
