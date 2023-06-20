using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppVariableSearch
    {
        public int Id { get; set; }
        public int? AppSubCategoryId { get; set; }
        public int? AppVariableId { get; set; }
        public string SearchText { get; set; }

        public virtual AppSubCategory AppSubCategory { get; set; }
        public virtual AppVariable AppVariable { get; set; }
    }
}
