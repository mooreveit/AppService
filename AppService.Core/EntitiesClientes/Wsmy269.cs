using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy269
    {
        public decimal? CodSolicitud { get; set; }
        public decimal? Codigo { get; set; }
        public string Rif { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public string UserSolicitud { get; set; }
        public string ObservSolicitud { get; set; }
        public DateTime? FechaAprob { get; set; }
        public string UserAprob { get; set; }
        public string ObservAprob { get; set; }
        public string Estatus { get; set; }
        public string SinRif { get; set; }
        public decimal? CodOficina { get; set; }
        public string Procesado { get; set; }
        public DateTime? FechaTeam { get; set; }
        public string UserTeam { get; set; }
        public string ObservSolicitudTeam { get; set; }
        public DateTime? FechaGer { get; set; }
        public string UserGer { get; set; }
        public string ObservSolicitudGer { get; set; }
        public DateTime? FechaReg { get; set; }
        public string UserReg { get; set; }
        public string ObservSolicitudReg { get; set; }
    }
}
