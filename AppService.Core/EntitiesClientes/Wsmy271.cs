using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy271
    {
        public int CodSolicitud { get; set; }
        public int CodOficina { get; set; }
        public string UserSolicitud { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int CodCliente { get; set; }
        public string ObservSolicitud { get; set; }
        public int? AsigActual { get; set; }
        public string VendActual { get; set; }
        public int? AsigNueva { get; set; }
        public string VendNuevo { get; set; }
        public string Status { get; set; }
        public string ObservAprob { get; set; }
        public string UserAprob { get; set; }
        public DateTime? FechaAprob { get; set; }
        public string ObservAnulacion { get; set; }
        public int? CodMotivo { get; set; }
        public int? CodGrupo { get; set; }
        public string UserAnulacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string Cerrado { get; set; }
        public decimal Id { get; set; }
    }
}
