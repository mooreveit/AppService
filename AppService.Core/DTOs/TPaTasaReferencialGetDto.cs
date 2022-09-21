using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class TPaTasaReferencialGetDto
    {

        public decimal Id { get; set; }
        public decimal? Tasa { get; set; }
        public DateTime? Fecha { get; set; }
        public string FechaTasa { get; set; }

    }
}
