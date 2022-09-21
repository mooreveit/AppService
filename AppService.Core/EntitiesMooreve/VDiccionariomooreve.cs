using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VDiccionariomooreve
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
        public short? MaxLength { get; set; }
        public byte? SystemTypeId { get; set; }
        public byte? Precision { get; set; }
        public byte? Scale { get; set; }
        public string Type { get; set; }
        public int? Expr1 { get; set; }
        public object Value { get; set; }
        public int? MinorId { get; set; }
        public string TipoTabla { get; set; }
        public string Basededatos { get; set; }
    }
}
