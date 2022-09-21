using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AppNotificacionEmail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool? Enable { get; set; }
    }
}
