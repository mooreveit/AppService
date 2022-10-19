using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumoPorMaquinaMesYAño
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Ubicacion { get; set; }
        public string Codigo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Kilos { get; set; }
        public string Maquina { get; set; }
    }
}
