using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy010
    {
        public decimal Recnum { get; set; }
        public int UltimoRollo { get; set; }
        public int UltAsignacion { get; set; }
        public short MesCurso { get; set; }
        public short AnoCurso { get; set; }
        public DateTime? FechaInv { get; set; }
    }
}
