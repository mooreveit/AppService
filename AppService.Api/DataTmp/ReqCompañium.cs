using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Lista de Compañias
    /// </summary>
    public partial class ReqCompañium
    {
        public ReqCompañium()
        {
            ReqOrigenRequerimientos = new HashSet<ReqOrigenRequerimiento>();
        }

        public string IdCompañia { get; set; }
        public string NombreCompañia { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }

        public virtual ICollection<ReqOrigenRequerimiento> ReqOrigenRequerimientos { get; set; }
    }
}
