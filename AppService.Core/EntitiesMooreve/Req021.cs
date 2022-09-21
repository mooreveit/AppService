using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req021
    {
        public short Id { get; set; }
        public short IdRutaEstacion { get; set; }
        public byte IdRuta { get; set; }
        public byte IdEstacion { get; set; }
        public byte Secuencia { get; set; }
    }
}
