using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class ReqAreaRequerimiento
    {
        public ReqAreaRequerimiento()
        {
            ReqTipoTareas = new HashSet<ReqTipoTarea>();
        }

        public int IdAreaRequerimiento { get; set; }
        public string DescripcionAreaRequerimiento { get; set; }
        public int IdOrigenRequerimiento { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ReqOrigenRequerimiento IdOrigenRequerimientoNavigation { get; set; }
        public virtual ICollection<ReqTipoTarea> ReqTipoTareas { get; set; }
    }
}
