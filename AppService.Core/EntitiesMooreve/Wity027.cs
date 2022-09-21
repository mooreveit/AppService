using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wity027
    {
        public long Id { get; set; }
        public string Celular { get; set; }
        public string OrigenSms { get; set; }
        public string Texto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Depurar { get; set; }
    }
}
