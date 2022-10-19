using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class VDiccionariomateriale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
        public short? Length { get; set; }
        public byte? Xtype { get; set; }
        public byte? Xprec { get; set; }
        public byte? Xscale { get; set; }
        public string Type { get; set; }
        public int? Expr1 { get; set; }
        public object Value { get; set; }
        public short? Smallid { get; set; }
        public string TipoTabla { get; set; }
        public string Basededatos { get; set; }
    }
}
