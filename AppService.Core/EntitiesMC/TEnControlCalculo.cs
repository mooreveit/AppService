using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TEnControlCalculo
    {
        public decimal Id { get; set; }
        public decimal IdSolicitud { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Documento { get; set; }
    }
}
