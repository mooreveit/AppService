using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapTipoInventarioClaseMovEntrada
    {
        public decimal Id { get; set; }
        public string TipoInventario { get; set; }
        public string ClaseMovEntradaSap { get; set; }
        public string ClaseMovEntradaJde { get; set; }
    }
}
