using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Almacenes
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Ubicaciones { get; set; }
        public string Tipo { get; set; }
        public string Almacen { get; set; }
        public string Bl { get; set; }
        public decimal? Bodega { get; set; }
        public string AfectaMargen { get; set; }
        public string AlmacenExistencia { get; set; }
    }
}
