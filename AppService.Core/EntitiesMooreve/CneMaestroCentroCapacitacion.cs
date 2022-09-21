using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CneMaestroCentroCapacitacion
    {
        public int IdCentroCapa { get; set; }
        public string NombreCentroCapa { get; set; }
        public string DireccionCentroCapa { get; set; }
        public short? IdEstadoCentroCapa { get; set; }
        public short? IdMunicipioCapa { get; set; }
        public short? IdParroquiaCapa { get; set; }
        public string FlagImpreso { get; set; }
    }
}
