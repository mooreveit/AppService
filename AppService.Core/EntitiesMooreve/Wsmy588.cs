using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy588
    {
        public decimal Id { get; set; }
        public string CategoriaRiesgo { get; set; }
        public decimal? ValorCategoriaRiesgo { get; set; }
        public string DescripcionCategoriaRiesgo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
