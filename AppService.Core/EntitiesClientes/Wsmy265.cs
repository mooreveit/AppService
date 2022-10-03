using System;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy265
    {
        public decimal Cliente { get; set; }
        public string Rif { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public string TelefonoOficina1 { get; set; }
        public string TelefonoOficina2 { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public decimal? IdContactos { get; set; }
        public string Inactivo { get; set; }
        public string Prospecto { get; set; }
        public string FechaCumpleanos { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Usuario { get; set; }
        public decimal? TomaDecision { get; set; }
        public string AceptaEmail { get; set; }
        public string AceptaSms { get; set; }
        public decimal Id { get; set; }
        public int? IdContactoOdoo { get; set; }

        public int? IdClienteOdoo { get; set; }
    }
}
