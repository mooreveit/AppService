using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaModeloCalculo
    {
        public TPaModeloCalculo()
        {
            TPaPlantillaEntradas = new HashSet<TPaPlantillaEntradas>();
        }

        public decimal Id { get; set; }
        public int CodigoModelo { get; set; }
        public string DescripcionModelo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual ICollection<TPaPlantillaEntradas> TPaPlantillaEntradas { get; set; }
    }
}
