using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class VDireccionesComerciales
    {
        public decimal Codigo { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string NombreParroquia { get; set; }
    }
}
