using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class PageMenuDto
    {


        public int Id { get; set; }
        public int Role { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public List<Children> Children { get; set; }
        

    }
}
