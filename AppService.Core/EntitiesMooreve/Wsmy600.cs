using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy600
    {
        public long IdRegistro { get; set; }
        public long IdPrelista { get; set; }
        public int NroLista { get; set; }
        public decimal PorcentajePeso { get; set; }
        public decimal PorcentajeVolumen { get; set; }
        public string PlacasTransporte { get; set; }
        public string CedulaTransportista { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime FechaUpdate { get; set; }
    }
}
