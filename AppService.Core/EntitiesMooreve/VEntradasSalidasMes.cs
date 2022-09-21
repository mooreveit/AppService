using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VEntradasSalidasMes
    {
        public short Bodega { get; set; }
        public string Producto { get; set; }
        public int? AñoContable { get; set; }
        public int? MesContable { get; set; }
        public int? EntradaMes { get; set; }
        public int? SalidaMes { get; set; }
    }
}
