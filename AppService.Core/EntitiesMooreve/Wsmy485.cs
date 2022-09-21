using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy485
    {
        public int IdPronostico { get; set; }
        public short IdMaquina { get; set; }
        public decimal? Eficienca { get; set; }
        public decimal? HorasTrabajo { get; set; }
        public DateTime FechaProceso { get; set; }
        public DateTime? FechaPronostico { get; set; }
        public string Usuario { get; set; }
        public string NombreProductos { get; set; }
        public string FlagListo { get; set; }
        public decimal? Dias { get; set; }
        public decimal? TotalPies { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? TotalDias { get; set; }
        public string Linea { get; set; }
    }
}
