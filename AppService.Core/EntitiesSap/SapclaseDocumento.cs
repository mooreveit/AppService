using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapclaseDocumento
    {
        public decimal Id { get; set; }
        public string ClaseDocumento { get; set; }
        public string Decripcion { get; set; }
        public string TipoLegacy { get; set; }
        public bool? DocumentoMadre { get; set; }
        public bool? InterfaseCobro { get; set; }
        public string Tipo { get; set; }
    }
}
