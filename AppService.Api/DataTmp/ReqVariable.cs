using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Variables para Plantillas por Tarea
    /// </summary>
    public partial class ReqVariable
    {
        public int IdVariable { get; set; }
        public string NombreVariable { get; set; }
        public int? IdTipoVariable { get; set; }
        public string TipoDato { get; set; }
        public string FuncionValidacion { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string UsuarioCambio { get; set; }
    }
}
