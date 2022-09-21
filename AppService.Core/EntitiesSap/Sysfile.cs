using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class Sysfile
    {
        public int Id { get; set; }
        public int? DiasEvaluacionInterfase { get; set; }
        public int? AñoObsolescencia { get; set; }
        public int? MesObsolescencia { get; set; }
    }
}
