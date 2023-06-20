using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class HistoricoPersonalCargo
    {
        public HistoricoPersonalCargo()
        {
            HistoricoNominas = new HashSet<HistoricoNomina>();
        }

        public decimal CodigoEmpresa { get; set; }
        public decimal CodigoPersona { get; set; }
        public decimal CodigoTipoNomina { get; set; }
        public decimal CodigoPeriodo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<HistoricoNomina> HistoricoNominas { get; set; }
    }
}
