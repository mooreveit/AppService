using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaTiposDeVariables
    {
        public TPaTiposDeVariables()
        {
            TPaVariables = new HashSet<TPaVariables>();
        }

        public decimal Id { get; set; }
        public int IdTipoVariable { get; set; }
        public string Descripcion { get; set; }
        public string Calculo { get; set; }
        public string Entrada { get; set; }
        public string Constante { get; set; }
        public string Busqueda { get; set; }
        public string Acumulador { get; set; }
        public string AcumuladorGeneral { get; set; }
        public string SubDetalle { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<TPaVariables> TPaVariables { get; set; }
    }
}
