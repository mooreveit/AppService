using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppVariableSearchGetDto
    {

        public int Id { get; set; }
        public int? AppSubCategoryId { get; set; }
        public int? AppVariableId { get; set; }
        public string VariableDescription { get; set; }
        public string SearchText { get; set; }


    }
}
