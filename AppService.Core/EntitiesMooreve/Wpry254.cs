using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry254
    {
        public long Id { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public byte[] Archivo { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public bool? NoReplicar { get; set; }
    }
}
