using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Query
    {
        public string JeSource { get; set; }
        public string JeCategory { get; set; }
        public string CurrencyCode { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public double? JeBatchId { get; set; }
        public DateTime? PostedDate { get; set; }
        public double JeLineNum { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public int SetOfBooksId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? Importe { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string CodeCombinationId { get; set; }
    }
}
