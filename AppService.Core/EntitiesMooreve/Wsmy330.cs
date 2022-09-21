using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy330
    {
        public decimal Id { get; set; }
        public decimal? Lista { get; set; }
        public string Descripcion { get; set; }
        public string Campo { get; set; }
        public decimal? CantidadIni { get; set; }
        public decimal? CantidadFin { get; set; }
        public string Activo { get; set; }
        public string MetodoLista { get; set; }
        public decimal? IdPantalla { get; set; }
        public decimal? CantMin01 { get; set; }
        public decimal? CantMin02 { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? Unidad { get; set; }
        public DateTime? FechaRevision { get; set; }
        public string FlagRestriccion { get; set; }
    }
}
