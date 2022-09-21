using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy653
    {
        public decimal Recnum { get; set; }
        public string Cotizacion { get; set; }
        public byte[] Archivo { get; set; }
        public string NombreArchivo { get; set; }
        public string Query { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Usuario { get; set; }
    }
}
