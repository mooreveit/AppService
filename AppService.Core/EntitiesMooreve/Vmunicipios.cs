using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Vmunicipios
    {
        public decimal Recnum { get; set; }
        public string CodigoEstado { get; set; }
        public string CodigoMcpo { get; set; }
        public string DescMunicipio { get; set; }
        public string CapitalMcpo { get; set; }
        public int ZonaDespacho { get; set; }
        public int PosicionRuta { get; set; }
        public string EdoMcpo { get; set; }
        public string CodigoJde { get; set; }
        public int? Kilometros { get; set; }
        public int IdOficinaFisica { get; set; }
        public int IdGrupoOficina { get; set; }
        public int? PorcFlete { get; set; }
        public string NombreEstado { get; set; }
    }
}
