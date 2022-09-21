using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy168
    {
        public int IdAjuste { get; set; }
        public decimal Documento { get; set; }
        public decimal Linea { get; set; }
        public string Producto { get; set; }
        public decimal? PorcAjustadoV { get; set; }
        public decimal? PorcAjustadoTl { get; set; }
        public decimal? PorcAjustadoGo { get; set; }
        public decimal? PorcAjustadoGr { get; set; }
        public decimal? PorcAjustadoGc { get; set; }
        public decimal? PorcAjustadoGic { get; set; }
        public decimal? PorcAjustadoCic { get; set; }
        public string IdMotivoAjuste { get; set; }
        public string UsuarioRed { get; set; }
        public string NombreMaquina { get; set; }
        public string UsuarioSistema { get; set; }
        public DateTime FechaAjuste { get; set; }
        public string Observacion { get; set; }
    }
}
