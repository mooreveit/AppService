using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppCategory
    {
        public AppCategory()
        {
            AppSubCategories = new HashSet<AppSubCategory>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppSubCategory> AppSubCategories { get; set; }
    }
}
