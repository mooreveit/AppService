using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy520
    {
        public short Ano { get; set; }
        public short Mes { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public string NombreRango { get; set; }
        public int ClientesActual { get; set; }
        public decimal VentasActual { get; set; }
        public int ClientesAnterior { get; set; }
        public decimal VentasAnterior { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
