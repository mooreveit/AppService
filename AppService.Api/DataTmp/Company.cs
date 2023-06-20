using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class Company
    {
        public Company()
        {
            Users = new HashSet<User>();
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
