using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaPlantillaEntradas
    {
        public decimal Id { get; set; }
        public int LineaNegocio { get; set; }
        public string IdVariables { get; set; }
        public int Item { get; set; }
        public string DescripcionVariable { get; set; }
        public string Valor { get; set; }
        public string Observaciones { get; set; }
        public string FuncionDeBusqueda { get; set; }
        public string FuncionDeValidacion { get; set; }

        public virtual TPaVariables IdVariablesNavigation { get; set; }
        public virtual TPaModeloCalculo LineaNegocioNavigation { get; set; }
    }
}
