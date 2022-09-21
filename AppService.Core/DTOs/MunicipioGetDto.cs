using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class MunicipioGetDto
    {
        public decimal Recnum { get; set; }
        public string CodigoEstado { get; set; }
        public string CodigoMcpo { get; set; }
        public string DescMunicipio { get; set; }
        public string CapitalMcpo { get; set; }
        public decimal? PorcFlete { get; set; }
        public string NombreEstado { get; set; }

    }
}
