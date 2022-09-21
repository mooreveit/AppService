using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VzlaAccounts
    {
        public decimal Id { get; set; }
        public string AdnameFullName { get; set; }
        public string UserLogonName { get; set; }
        public string Email { get; set; }
        public string Historial { get; set; }
        public string NetworkId { get; set; }
        public string Pass { get; set; }
    }
}
