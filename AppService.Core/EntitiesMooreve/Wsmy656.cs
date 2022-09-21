using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy656
    {
        public decimal Recnum { get; set; }
        public short IdFlujo { get; set; }
        public string NombreFlujo { get; set; }
        public bool FlagMc { get; set; }
        public bool FlagVolumen { get; set; }
        public bool FlagCombinada { get; set; }
        public bool FlagAuto { get; set; }
        public bool? FlagListaPrecio { get; set; }
    }
}
