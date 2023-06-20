using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class ReqTarea
    {
        public int IdTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public int IdTipoTarea { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ReqTipoTarea IdTipoTareaNavigation { get; set; }
    }
}
