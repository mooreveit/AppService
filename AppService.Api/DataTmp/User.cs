using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public int CompanyId { get; set; }
        public bool? IsSuccess { get; set; }
        public string Message { get; set; }

        public virtual Company Company { get; set; }
    }
}
