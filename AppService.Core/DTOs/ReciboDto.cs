using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class ReciboDto
    {
        public CobGeneralCobranzaDto CobGeneralCobranzaDto { get; set; }

        public List<CobGrabacionCobranzaDto> CobGrabacionCobranzaDto { get; set; }

      
    }
}
