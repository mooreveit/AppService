using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wivy191
    {
        public int Id { get; set; }
        public int? RequisicionCompra { get; set; }
        public long? OrdenCompra { get; set; }
        public string CodigoDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaColocada { get; set; }
        public DateTime? FechaAnulada { get; set; }
        public DateTime? FechaPlanta { get; set; }
        public int? Dias { get; set; }
        public short? Status { get; set; }
        public string CodigoComprador { get; set; }
        public string NombreComprador { get; set; }
        public string Usuario { get; set; }
        public string TipoOc { get; set; }
        public int? Urgente { get; set; }
    }
}
