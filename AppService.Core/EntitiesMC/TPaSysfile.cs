using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaSysfile
    {
        public int Id { get; set; }
        public string DestinatarioFuncional { get; set; }
        public string CopiaFuncional { get; set; }
        public string SegundaCopiaFuncional { get; set; }
        public string DestinatarioTecnico { get; set; }
        public string CopiaTecnico { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? ConsecutivoOrdenPlantilla { get; set; }
    }
}
