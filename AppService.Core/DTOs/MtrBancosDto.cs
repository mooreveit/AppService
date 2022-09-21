using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class MtrBancosDto
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodContable { get; set; }
   
        public int IdTipoCuentaDestino { get; set; }
        public string IdTipoTransaccion { get; set; }


    }
}
