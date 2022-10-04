using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VCaracteristica
    {
        public long Orden { get; set; }
        public int? MedidaBasica { get; set; }
        public int? MedidaOpuesta { get; set; }
        public int CantidadTintas { get; set; }
        public short? PartesFormula { get; set; }
        public string TIpopaPel { get; set; }
        public string PApel { get; set; }
    }
}
