using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy630
    {
        public long Recnum { get; set; }
        public long Id { get; set; }
        public string IdProducto { get; set; }
        public short IdCalendario { get; set; }
        public int MedidaBasica { get; set; }
        public short Partes { get; set; }
        public short CantTintasFrente { get; set; }
        public short CantTintasRespaldo { get; set; }
        public short TotalTintas { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
