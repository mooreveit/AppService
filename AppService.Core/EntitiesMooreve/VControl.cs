using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VControl
    {
        public decimal? Control { get; set; }
        public string Tipo { get; set; }
        public int Documento { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
