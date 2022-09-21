using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaRangoToleranciaMc
    {
        public int Id { get; set; }
        public string LineaProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public string Mensaje { get; set; }
        public string Enviaemail { get; set; }
        public string PositivoNegativo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
