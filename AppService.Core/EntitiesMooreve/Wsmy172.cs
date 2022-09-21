using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy172
    {
        public int IdDetalleTipoExcepecion { get; set; }
        public int IdTipoExcepcion { get; set; }
        public string BaseDatos { get; set; }
        public string Tabla { get; set; }
        public string IdCampo { get; set; }
        public string DescCampo { get; set; }
        public string AliasCampo { get; set; }
        public string Control { get; set; }
        public string CampoWcom111 { get; set; }
        public string FlagBusqueda { get; set; }
        public int? Orden { get; set; }
    }
}
