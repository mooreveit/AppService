using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Proveedores
    {
        public string Origen { get; set; }
        public string Status { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Rif { get; set; }
        public string Tlf { get; set; }
        public string Fax { get; set; }
        public string PersonaContacto { get; set; }
        public string FechaIngreso { get; set; }
        public string Conceptoretencion { get; set; }
        public string Conceptoiva { get; set; }
        public string Codigoislr { get; set; }
        public decimal Id { get; set; }
    }
}
