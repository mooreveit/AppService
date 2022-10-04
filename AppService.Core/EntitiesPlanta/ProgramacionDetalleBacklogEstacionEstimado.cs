using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class ProgramacionDetalleBacklogEstacionEstimado
    {
        public decimal Id { get; set; }
        public decimal? FechaEstimacionJuliana { get; set; }
        public decimal? FechaDiaHabil { get; set; }
        public string Prensa { get; set; }
        public int? Turno { get; set; }
        public decimal? HorasXturno { get; set; }
        public decimal? HorasJob { get; set; }
        public decimal? HorasJobProgramadas { get; set; }
        public decimal? IdJob { get; set; }
    }
}
