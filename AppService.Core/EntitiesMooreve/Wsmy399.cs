using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy399
    {
        public int IdBitacora { get; set; }
        public DateTime? FechaBitacora { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public string UsuarioRed { get; set; }
        public string UsuarioSistema { get; set; }
        public string NombreAplicacion { get; set; }
        public string ComentarioUsuario { get; set; }
        public string ComentarioSistema { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Correlativo { get; set; }
        public decimal? Renglon { get; set; }
        public string TipoTransaccion { get; set; }
    }
}
