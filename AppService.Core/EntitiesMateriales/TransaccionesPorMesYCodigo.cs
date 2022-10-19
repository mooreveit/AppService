using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class TransaccionesPorMesYCodigo
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string ES { get; set; }
        public decimal? Kilos { get; set; }
        public string Transaccion { get; set; }
    }
}
