using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AprobadoresPorRutaDto
    {

        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public short IdEstacion { get; set; }
        public short SecuenciaEstacion { get; set; }
        public string NombreEstacion { get; set; }
        public decimal? PuntosPorcMin { get; set; }

        public decimal? PuntosPorcMax { get; set; }
        public short SecuenciaUsuario { get; set; }
        

    }
}
