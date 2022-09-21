using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy624
    {
        public int RecNum { get; set; }
        public int IdCausa { get; set; }
        public string NombreCausa { get; set; }
        public string FlagInactivo { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime? FechaAgrega { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
