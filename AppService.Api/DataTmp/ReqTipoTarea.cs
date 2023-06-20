using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class ReqTipoTarea
    {
        public ReqTipoTarea()
        {
            ReqTareas = new HashSet<ReqTarea>();
        }

        public int IdTipoTarea { get; set; }
        public string DescripcionTipoTarea { get; set; }
        public int IdAreaRequerimiento { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ReqAreaRequerimiento IdAreaRequerimientoNavigation { get; set; }
        public virtual ICollection<ReqTarea> ReqTareas { get; set; }
    }
}
