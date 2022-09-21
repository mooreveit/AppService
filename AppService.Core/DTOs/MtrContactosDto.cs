using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class MtrContactosDto
    {
        public long IdContacto { get; set; }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
    }
}
