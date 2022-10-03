namespace AppService.Core.DTOs.Odoo.Contactos
{
    public class OdooContactoUpdateDto
    {

        public decimal IdContacto { get; set; }

        public string IdCliente { get; set; }

        public string Rif { get; set; }

        public short Tratamiento { get; set; } = 1;

        public string Poder { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cargo { get; set; }

        public string Departamento { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }
        public bool Inactivo { get; set; }
        public int? IdContactoOdoo { get; set; }

        public int? IdClienteOdoo { get; set; }

        public string UsuarioConectado { get; set; }
    }
}
