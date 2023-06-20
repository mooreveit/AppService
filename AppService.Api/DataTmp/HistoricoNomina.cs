using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class HistoricoNomina
    {
        public decimal Id { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public decimal? CodigoPersona { get; set; }

        public virtual HistoricoPersonalCargo Codigo { get; set; }
    }
}
