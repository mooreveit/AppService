using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class UnitConvertedGetDto
    {
        public decimal ValorConvertido { get; set; }
        public decimal UnitPriceBaseProduction { get; set; }
        public decimal UnitPriceConverted { get; set; }
        public decimal CantidadPorUnidadProduccion { get; set; }

    }
}
