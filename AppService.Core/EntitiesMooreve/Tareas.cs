using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Tareas
    {
        public int IdTarea { get; set; }
        public string NombreTarea { get; set; }
        public string RutaTarea { get; set; }
        public string NombrePrograma { get; set; }
        public int? Tiempo { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public DateTime? UltimaEjecucion { get; set; }
        public bool? Activa { get; set; }
        public string UsuarioRed { get; set; }
        public string Maquina { get; set; }
    }
}
