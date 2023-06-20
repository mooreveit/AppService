using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VInvetarioReconversion
    {
        public string Basededatos { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
        public string Type { get; set; }
        public short? Length { get; set; }
        public byte? Xprec { get; set; }
        public byte? Xscale { get; set; }
    }
}
