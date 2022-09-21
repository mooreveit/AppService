using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class UsuariosVentas
    {
        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
    }
}
