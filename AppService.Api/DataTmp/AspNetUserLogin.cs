using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AspNetUserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
