using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy667
    {
        public long Id { get; set; }
        public string IdProducto { get; set; }
        public short Tintas { get; set; }
        public int MedidaBasica { get; set; }
        public decimal MillarRolloMinimo { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime? FechaAgrega { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
