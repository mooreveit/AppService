using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry219
    {
        public int IdConsulta { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public string CodigoVendedor { get; set; }
        public int CodigoOficina { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int IdMotivo { get; set; }
        public string Comentario { get; set; }
        public int? Estatus { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public short? DiasVendedor { get; set; }
        public string FlagMineria { get; set; }
    }
}
