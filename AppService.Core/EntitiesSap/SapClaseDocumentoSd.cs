using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapClaseDocumentoSd
    {
        public decimal Id { get; set; }
        public string Clase { get; set; }
        public string Descripcion { get; set; }
        public bool? Factura { get; set; }
        public bool? Nc { get; set; }
        public bool? Nd { get; set; }
        public bool? Miscelaneo { get; set; }
        public bool? Anticipado { get; set; }
        public bool? GeneraDespacho { get; set; }
    }
}
