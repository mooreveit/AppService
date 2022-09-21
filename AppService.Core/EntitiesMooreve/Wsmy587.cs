using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy587
    {
        public decimal Id { get; set; }
        public decimal ClienteLegacy { get; set; }
        public decimal ClienteJde { get; set; }
        public decimal Fecha { get; set; }
        public decimal? EfectivoCajaBanco { get; set; }
        public decimal? PasivoCirculante { get; set; }
        public decimal? ActivoCirculante { get; set; }
        public decimal? Inventarios { get; set; }
        public decimal? LiquidezInmediata { get; set; }
        public decimal? PruebaDeAcido { get; set; }
        public decimal? PoseeLocalComercial { get; set; }
        public decimal? CapitalTrabajo { get; set; }
        public string Excepcion { get; set; }
        public string ObsevacionesExcepcion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
