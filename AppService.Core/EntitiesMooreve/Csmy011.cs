using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Csmy011
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Combinación { get; set; }
        public string TipoTinta { get; set; }
        public string EventoMatrizLista { get; set; }
        public string ShortRun { get; set; }
        public string FlagNoContar { get; set; }
        public string Icpp { get; set; }
        public decimal? Frecuencia { get; set; }
        public string FlagEliminada { get; set; }
    }
}
