using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class OrdenEmbarquesVentasCobro
    {
        public decimal Id { get; set; }
        public short AloContable { get; set; }
        public short MesContable { get; set; }
        public long Orden { get; set; }
        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string PrecioFijado { get; set; }
        public decimal? ValorVentaBsEs { get; set; }
        public decimal? VentaDolRefEs { get; set; }
        public decimal? ValorVentaBsEm { get; set; }
        public decimal? VentaDolRefEm { get; set; }
        public decimal? ValorVentaBsCo { get; set; }
        public decimal? VentaUsdCo { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public decimal? PorcMc { get; set; }
    }
}
