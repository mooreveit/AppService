using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Civy008
    {
        public decimal Recnum { get; set; }
        public short Operacion { get; set; }
        public string Nombre { get; set; }
        public string Es { get; set; }
        public short? Signo { get; set; }
        public string InventarioInicial { get; set; }
        public string Alias { get; set; }
        public short? TransaccionGenera { get; set; }
        public string Autorizacion { get; set; }
        public string CentroCosto { get; set; }
        public string AfectaConsumo { get; set; }
        public string RequiereDocumento { get; set; }
        public string Prueba { get; set; }
    }
}
