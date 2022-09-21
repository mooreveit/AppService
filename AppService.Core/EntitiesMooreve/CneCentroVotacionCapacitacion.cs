using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CneCentroVotacionCapacitacion
    {
        public int? EstadoCv { get; set; }
        public int? MunicipioCv { get; set; }
        public int? ParroquiaCv { get; set; }
        public int? Centro { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public short? EdoCapa { get; set; }
        public short? MunCapa { get; set; }
        public short? PaqCapa { get; set; }
        public int? CtroCapacitacion { get; set; }
        public string NombreNucleo { get; set; }
        public string DireccionNucleo { get; set; }
    }
}
