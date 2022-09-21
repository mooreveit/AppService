using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy509
    {
        public decimal Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Semana { get; set; }
        public int? Categoria { get; set; }
        public int? SubCategoria { get; set; }
        public decimal? DiaHabil { get; set; }
        public decimal? Venta { get; set; }
        public decimal? EstimadoTotal { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public decimal? DiasHabiles { get; set; }
        public decimal? EstimadoDiario { get; set; }
        public decimal? VentaAcumulada { get; set; }
        public decimal? EstimadoAcumulado { get; set; }
        public string DescCategoria { get; set; }
        public string DescSubCategoria { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? Rventa { get; set; }
        public decimal? RestimadoTotal { get; set; }
        public decimal? RestimadoDiario { get; set; }
        public decimal? RventaAcumulada { get; set; }
        public decimal? RestimadoAcumulado { get; set; }
    }
}
