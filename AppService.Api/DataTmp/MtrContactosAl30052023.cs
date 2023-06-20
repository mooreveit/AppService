using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrContactosAl30052023
    {
        public long IdContacto { get; set; }
        public string IdCliente { get; set; }
        public string Rif { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public bool? Inactivo { get; set; }
        public bool? Prospecto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Usuario { get; set; }
        public bool? AceptaEmail { get; set; }
        public bool? AceptaSms { get; set; }
        public int? IdContactoOdoo { get; set; }
        public int? IdClienteOdoo { get; set; }
    }
}
