using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class SegModulo
    {
        public int IdModulo { get; set; }
        public string NombreModulo { get; set; }
        public string LinkModulo { get; set; }
        public string Descripcion { get; set; }
        public int? IndiceModulo { get; set; }
        public int? IdPrograma { get; set; }
        public int? IdModuloPadre { get; set; }
        public short? TipoLlamada { get; set; }
        public string Icono { get; set; }
        public short? ServidorReporte { get; set; }
        public string RutaReporte { get; set; }
        public string NombreReporte { get; set; }
        public short? IdTipoReporte { get; set; }
        public string FlagPortafolioReportes { get; set; }
        public string IconoMenu { get; set; }
    }
}
