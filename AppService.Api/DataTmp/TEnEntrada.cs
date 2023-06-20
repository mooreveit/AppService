using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TEnEntrada
    {
        public decimal Id { get; set; }
        public decimal IdSolicitud { get; set; }
        public int LineaNegocio { get; set; }
        public string IdVariables { get; set; }
        public int Item { get; set; }
        public string Valor { get; set; }
        public string FuncionDeValidacion { get; set; }
        public string MensajeValidacion { get; set; }
        public string FuncionDeBusqueda { get; set; }
        public string Orden { get; set; }
        public string FuncionDeBusquedaValor { get; set; }
        public string Producto { get; set; }

        public virtual TPaVariable IdVariablesNavigation { get; set; }
    }
}
