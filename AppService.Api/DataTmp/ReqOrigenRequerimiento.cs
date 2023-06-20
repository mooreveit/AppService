using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Origenes de Requerimientos de Servicios
    /// </summary>
    public partial class ReqOrigenRequerimiento
    {
        public ReqOrigenRequerimiento()
        {
            ReqAreaRequerimientos = new HashSet<ReqAreaRequerimiento>();
        }

        public int IdOrigenRequerimiento { get; set; }
        public string DescripcionOrigenRequerimiento { get; set; }
        public string IdCompañia { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ReqCompañium IdCompañiaNavigation { get; set; }
        public virtual ICollection<ReqAreaRequerimiento> ReqAreaRequerimientos { get; set; }
    }
}
