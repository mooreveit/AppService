using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry059
    {
        public decimal Recnum { get; set; }
        public long JobId { get; set; }
        public long Orden { get; set; }
        public string LineaProduccio { get; set; }
        public short Pais { get; set; }
        public short Depto { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorLista { get; set; }
        public decimal ValorVenta { get; set; }
        public DateTime? FechaEntrad { get; set; }
        public short Prensa { get; set; }
        public short Colect { get; set; }
        public short Vendedor { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Papel1 { get; set; }
        public string Papel2 { get; set; }
        public decimal? RvalorLista { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
