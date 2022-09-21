using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class MtrNotificacionEmail
    {
        public int IdNotificacion { get; set; }
        public string NombreNotificacion { get; set; }
        public string Destino { get; set; }
        public string Copia { get; set; }
        public string CopiaOculta { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public string TipoCuerpo { get; set; }
        public string PerfilEnvio { get; set; }
        public string RutaArchivo { get; set; }
    }
}
