using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumosPorCodigoMensual
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Codigo { get; set; }
        public decimal? Kilos { get; set; }
        public decimal? Ancho { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionGen { get; set; }
    }
}
