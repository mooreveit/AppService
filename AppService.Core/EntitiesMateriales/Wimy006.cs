using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy006
    {
        public decimal Recnum { get; set; }
        public string CodigoGenero { get; set; }
        public string DescripcionGen { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
