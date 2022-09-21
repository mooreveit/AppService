using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy683
    {
        public decimal Recnum { get; set; }
        public string Transaccion { get; set; }
        public decimal Documento { get; set; }
        public short Linea { get; set; }
        public int IdCliente { get; set; }
        public long NroRc { get; set; }
        public bool FlagReversado { get; set; }
        public DateTime? FechaReversado { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UsuarioActualiza { get; set; }
    }
}
