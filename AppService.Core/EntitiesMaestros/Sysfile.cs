using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Sysfile
    {
        public decimal Recnum { get; set; }
        public short CodigoCia { get; set; }
        public string CompanyName { get; set; }
        public decimal? CapitalBs { get; set; }
        public string Rif { get; set; }
        public string PolizaSeguro { get; set; }
        public short? LargoPagina { get; set; }
        public short? SaltoPagina { get; set; }
        public string Mark { get; set; }
        public decimal? PorcIva { get; set; }
        public short Mescon { get; set; }
        public short Anocon { get; set; }
        public short? CodigoOficina { get; set; }
        public string Region { get; set; }
    }
}
