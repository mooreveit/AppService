using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy681
    {
        public decimal Recnum { get; set; }
        public string IdVariable { get; set; }
        public short Prioridad { get; set; }
        public bool FlagVendedor { get; set; }
        public bool FlagGerente { get; set; }
        public bool FlagGerenteProdcuto { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UsuarioActualiza { get; set; }
    }
}
