using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cpry255
    {
        public int Id { get; set; }
        public short IdMaquina { get; set; }
        public int MedidaBasicaMultiplo { get; set; }
        public decimal MedidaOpuestaDesde { get; set; }
        public decimal MedidaOpuestaHasta { get; set; }
        public short CantidadTintas { get; set; }
        public short PerfHorizontal { get; set; }
        public short PerfVertical { get; set; }
        public short HoyosArchivo { get; set; }
        public short CarbonEngomado { get; set; }
        public short CarbonSpot { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string Usuario { get; set; }
        public long? CantidadMinima { get; set; }
        public string FlagProducto { get; set; }
    }
}
