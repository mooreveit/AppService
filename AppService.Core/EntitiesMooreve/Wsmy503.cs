using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy503
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string FlagGanada { get; set; }
        public string FlagModificar { get; set; }
        public string FlagActiva { get; set; }
        public string FlagPostergada { get; set; }
        public string FlagPerdida { get; set; }
        public string FlagCaducada { get; set; }
        public string FlagEnEspera { get; set; }
        public string FlagCaducaInactiva { get; set; }
        public string Abreviado { get; set; }
        public string PrimeraEstacion { get; set; }
        public decimal? CondicionRazonId { get; set; }
        public decimal Id { get; set; }
    }
}
