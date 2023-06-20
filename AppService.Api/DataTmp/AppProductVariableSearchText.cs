using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppProductVariableSearchText
    {
        public int Id { get; set; }
        public int? AppProductId { get; set; }
        public int? AppVariableId { get; set; }
        public string CodeVariable { get; set; }
        public string SearchText { get; set; }

        public virtual AppProduct AppProduct { get; set; }
        public virtual AppVariable AppVariable { get; set; }
    }
}
