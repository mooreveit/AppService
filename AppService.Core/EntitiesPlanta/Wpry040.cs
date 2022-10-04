using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry040
    {
        public decimal Recnum { get; set; }
        public string CodProducto { get; set; }
        public short Cantidad { get; set; }
        public string Descripcion { get; set; }
        public short DiasHabiles { get; set; }
    }
}
