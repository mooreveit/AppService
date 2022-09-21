using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class ContactoProspecto
    {
        public decimal Cliente { get; set; }
        public decimal Contacto { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string TelefonoOficina { get; set; }
        public string TelefonoPersonal { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
        public string FechaNac { get; set; }
        public string Estatus { get; set; }
    }
}
