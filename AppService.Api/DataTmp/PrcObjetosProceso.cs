using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class PrcObjetosProceso
    {
        public PrcObjetosProceso()
        {
            PrcUsuarioProcesos = new HashSet<PrcUsuarioProceso>();
        }

        public decimal Id { get; set; }
        public string Servidor { get; set; }
        public string BaseDatos { get; set; }
        public string Objeto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public decimal ColaDeTrabajo { get; set; }

        public virtual ICollection<PrcUsuarioProceso> PrcUsuarioProcesos { get; set; }
    }
}
