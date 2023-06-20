using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class PageMenu
    {
        public int Id { get; set; }
        public int? Role { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public bool? Mobil { get; set; }
    }
}
