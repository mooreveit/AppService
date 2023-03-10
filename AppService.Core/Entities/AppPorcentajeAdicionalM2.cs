using System;
namespace AppService.Core.Entities
{
	public class AppPorcentajeAdicionalM2
	{
        public int Id { get; set; }

        public Decimal M2Desde { get; set; }

        public Decimal M2Hasta { get; set; }

        public Decimal Porcentaje { get; set; }
    }
}

