using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssServicioResponsable
    {
        public long IdServicioResponsable { get; set; }
        public int IdServicio { get; set; }
        public string IdTipoNomina { get; set; }
        public int IdResponsable { get; set; }
        public byte Secuencia { get; set; }
        public bool Inactivo { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }
    }
}
