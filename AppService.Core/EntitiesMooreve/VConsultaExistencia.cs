using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VConsultaExistencia
    {
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public string Medida { get; set; }
        public decimal? Backlog { get; set; }
        public short Bodega { get; set; }
        public int? Saldo { get; set; }
        public int PtoReorden { get; set; }
        public decimal? Disponible { get; set; }
    }
}
