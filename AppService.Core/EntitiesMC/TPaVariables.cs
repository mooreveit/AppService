using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaVariables
    {
        public TPaVariables()
        {
            TEnEntradas = new HashSet<TEnEntradas>();
            TPaPlantillaEntradas = new HashSet<TPaPlantillaEntradas>();
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

        public virtual TPaTiposDeVariables IdTipoVariableNavigation { get; set; }
        public virtual ICollection<TEnEntradas> TEnEntradas { get; set; }
        public virtual ICollection<TPaPlantillaEntradas> TPaPlantillaEntradas { get; set; }
    }
}
