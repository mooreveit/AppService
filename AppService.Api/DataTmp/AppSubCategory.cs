using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppSubCategory
    {
        public AppSubCategory()
        {
            AppProducts = new HashSet<AppProduct>();
            AppVariableSearches = new HashSet<AppVariableSearch>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int AppCategoryId { get; set; }
        public bool? Active { get; set; }

        public virtual AppCategory AppCategory { get; set; }
        public virtual ICollection<AppProduct> AppProducts { get; set; }
        public virtual ICollection<AppVariableSearch> AppVariableSearches { get; set; }
    }
}
