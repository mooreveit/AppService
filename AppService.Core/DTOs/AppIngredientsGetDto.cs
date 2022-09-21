using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppIngredientsGetDto
    {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int AppUnitId { get; set; }
        public decimal Cost { get; set; }
        public long? PrymaryMtrMonedaId { get; set; }
        public long? SecundaryMtrMonedaId { get; set; }


        public AppUnitsGetDto AppUnitsGetDto { get; set; }
        public MtrTipoMonedaDto PrymaryMtrMonedaDto { get; set; }
        public MtrTipoMonedaDto SecundaryMtrMonedaDto { get; set; }

    }
}
