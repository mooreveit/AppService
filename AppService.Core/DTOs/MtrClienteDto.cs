using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class MtrClienteDto
    {

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string No_Reg_Tribut { get; set; }
        public string Descripcion { get; set; }

        public string Vendedor1 { get; set; }
        public decimal? IdDireccion { get; set; }

        public MtrDireccionesDto MtrDireccionesDto { get; set; }

    }
}
