using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class ContactoCreateDto
    {
        public string Rif { get; set; }

        public short Tratamiento { get; set; }

        public string Poder { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cargo { get; set; }

        public string Departamento { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public decimal IdContacto { get; set; }

        public string IdCliente { get; set; }

        public string IdContactoSap { get; set; }
        
        public string UsuarioConectado { get; set; }
    }
}
