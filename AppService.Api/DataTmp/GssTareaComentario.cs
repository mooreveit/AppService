using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssTareaComentario
    {
        public long IdComentarioTarea { get; set; }
        public long IdTarea { get; set; }
        public DateTime FechaComentario { get; set; }
        public string ComentarioTarea { get; set; }
        public short IdUsuario { get; set; }

        public virtual GssTarea IdTareaNavigation { get; set; }
    }
}
