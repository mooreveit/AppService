using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wary251
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string FlagFecAviso { get; set; }
        public string FlagFecInter { get; set; }
        public int? DiasFecInter { get; set; }
        public string FlagEmailCliente { get; set; }
        public string FlagEmailConsultor { get; set; }
        public string FlagEmailAdmini { get; set; }
        public string FlagSms { get; set; }
    }
}
