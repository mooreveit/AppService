using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VFromLogCotizador
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public int IdEstatus { get; set; }
        public string NombreEstatus { get; set; }
        public decimal? TotalPropuesta { get; set; }
        public decimal? Kilos { get; set; }
        public decimal? Mcb { get; set; }
        public decimal? Mcf { get; set; }
        public bool? FlagEstimada { get; set; }
        public int IdSubCategoria { get; set; }
        public string NombreSubCategoria { get; set; }
        public short IdOficina { get; set; }
        public string NombreOficina { get; set; }
        public string IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public DateTime? Fecha { get; set; }
        public int IdProbabilidad { get; set; }
        public string NombreProbabilidad { get; set; }
        public string NombreCliente { get; set; }
        public string IdProducto { get; set; }
        public string Papeles { get; set; }
        public float? Millares { get; set; }
        public int Partes { get; set; }
        public int? CantTintas { get; set; }
        public string Basica { get; set; }
        public string Opuesta { get; set; }
        public string Tintas { get; set; }
    }
}
