using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwTiposDeTransaccion
    {
        public string Transaccion { get; set; }
        public string Descripcion { get; set; }
        public string Aplicacion { get; set; }
        public decimal Id { get; set; }
    }
}
