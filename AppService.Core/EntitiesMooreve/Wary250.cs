using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wary250
    {
        public long Id { get; set; }
        public long? Cliente { get; set; }
        public long? Factura { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public string Consultor { get; set; }
        public string Teleoperador { get; set; }
        public string Gestion { get; set; }
    }
}
