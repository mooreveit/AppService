using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class EmpleadosVe
    {
        public double Codigo { get; set; }
        public string Rif { get; set; }
        public string Nombre { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Estado1 { get; set; }
        public string Status { get; set; }
        public DateTime? Modificacion { get; set; }
    }
}
