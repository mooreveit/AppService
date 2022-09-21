using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class ConsultaContactos
    {
        public string Codigo { get; set; }
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
        public string OficinaVenta { get; set; }
        public string Vendedor1 { get; set; }
    }
}
