using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy645
    {
        public decimal Recnum { get; set; }
        public string IdEstatus { get; set; }
        public string NombreEstatus { get; set; }
        public string FlagPendiente { get; set; }
        public string FlagAprobado { get; set; }
        public string FlagRechazado { get; set; }
        public string FlagEnviado { get; set; }
        public bool FlagAuto { get; set; }
        public bool FlagMail { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
