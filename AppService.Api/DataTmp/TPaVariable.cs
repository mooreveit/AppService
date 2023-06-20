using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TPaVariable
    {
        public TPaVariable()
        {
            TEnEntrada = new HashSet<TEnEntrada>();
            TPaPlantillaEntrada = new HashSet<TPaPlantillaEntrada>();
        }

        public decimal Id { get; set; }
        public string IdVariables { get; set; }
        public string NombreVariable { get; set; }
        public int? IdTipoVariable { get; set; }
        public string General { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string TipoDato { get; set; }
        public string AfectaMc { get; set; }
        public string AfectaCostoPororden { get; set; }
        public string IgualEnCombinacion { get; set; }

        public virtual TPaTiposDeVariable IdTipoVariableNavigation { get; set; }
        public virtual ICollection<TEnEntrada> TEnEntrada { get; set; }
        public virtual ICollection<TPaPlantillaEntrada> TPaPlantillaEntrada { get; set; }
    }
}
