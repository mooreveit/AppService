using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class SegPrograma
    {
        public int IdPrograma { get; set; }
        public string NombrePrograma { get; set; }
        public string Descripcion { get; set; }
        public string TipoPrograma { get; set; }
        public bool? ParaMenu { get; set; }
        public string Link { get; set; }
        public string FlagRequerimiento { get; set; }
        public byte IdAreaNegocio { get; set; }
        public short ServidorReporte { get; set; }
        public short ServidorPublico { get; set; }
    }
}
