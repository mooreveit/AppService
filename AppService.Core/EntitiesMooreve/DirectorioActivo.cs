using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class DirectorioActivo
    {
        public decimal Id { get; set; }
        public string ParentContainer { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string UserPassword { get; set; }
        public string SamAccountName { get; set; }
        public string UserPrincipalName { get; set; }
        public string DisplayName { get; set; }
        public string MemberOf { get; set; }
        public string Department { get; set; }
        public string Sid { get; set; }
    }
}
