using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry070
    {
        public decimal Recnum { get; set; }
        public int NroProg { get; set; }
        public DateTime? Fecha { get; set; }
        public short Maquina { get; set; }
        public string DescMaquina { get; set; }
        public string Actualizada { get; set; }
        public string Asignada { get; set; }
        public short UltItem { get; set; }
        public DateTime? Fechainicioprog { get; set; }
        public string Horaminutoprog { get; set; }
        public DateTime? FechaHoraInicioProg { get; set; }
    }
}
