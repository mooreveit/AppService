using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class MtrDireccionesDto
    {
        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public string Rif { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

    }
}
