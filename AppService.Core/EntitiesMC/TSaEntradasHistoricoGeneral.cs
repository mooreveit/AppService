using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TSaEntradasHistoricoGeneral
    {
        public decimal Id { get; set; }
        public decimal IdSolicitud { get; set; }
        public int LineaNegocio { get; set; }
        public string IdVariables { get; set; }
        public int Item { get; set; }
        public string Valor { get; set; }
        public DateTime? FechaCalculo { get; set; }
        public string Orden { get; set; }
        public string Producto { get; set; }
        public string FuncionDeBusqueda { get; set; }
    }
}
