using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy633
    {
        public long Recnum { get; set; }
        public int IdCatVoBo { get; set; }
        public int IdSubCatVoBo { get; set; }
        public string NombreSubCategoria { get; set; }
        public int Secuencia { get; set; }
        public string FlagInactivo { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioMoficia { get; set; }
        public DateTime FechaModifica { get; set; }
    }
}
