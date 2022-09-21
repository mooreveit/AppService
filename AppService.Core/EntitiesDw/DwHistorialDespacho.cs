using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwHistorialDespacho
    {
        public long Id { get; set; }
        public int? Lista { get; set; }
        public string Zona { get; set; }
        public string Ciudad { get; set; }
        public short? Posicionruta { get; set; }
        public DateTime? Fecha { get; set; }
        public long? Orden { get; set; }
        public string Tipovehiculo { get; set; }
        public int? Bultos { get; set; }
        public decimal? Bsflete { get; set; }
        public decimal? Bsventa { get; set; }
        public string Ciudadlejana { get; set; }
        public int? Kilometros { get; set; }
    }
}
