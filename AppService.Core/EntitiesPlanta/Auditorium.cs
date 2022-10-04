using System;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Auditorium
    {
        public decimal Id { get; set; }
        public string Tabla { get; set; }
        public string Campo { get; set; }
        public string Estacion { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? Fecha { get; set; }
        public string ValorInical { get; set; }
        public string Valorfinal { get; set; }
        public string Usuario { get; set; }
        public string Anterior { get; set; }
        public string Nuevo { get; set; }
    }
}
