using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Status
    {
        public decimal Id { get; set; }
        public decimal IdEstacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaEstimada { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public decimal? Diferencia { get; set; }
        public string An8Proveedor { get; set; }
        public string NomProveedor { get; set; }
        public decimal? Orden { get; set; }
        public string Producto { get; set; }
        public DateTime? FechaProgramada { get; set; }
        public decimal? Prioridad { get; set; }
        public string Observacion { get; set; }
        public decimal IdRuta { get; set; }
        public int? Documento { get; set; }
        public int? Cantidad { get; set; }
    }
}
