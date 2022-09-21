using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class AppVariableSearchQueryFilter
    {
        public int Id { get; set; }
        public int? AppSubCategoryId { get; set; }
        public int? AppVariableId { get; set; }
        public string SearchText { get; set; }


    }
}
