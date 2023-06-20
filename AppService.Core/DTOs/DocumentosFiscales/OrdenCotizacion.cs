using System;
namespace AppService.Core.DTOs.DocumentosFiscales
{
	public class OrdenCotizacion
	{
		public long Orden { get; set; }
        public string Cotizacion { get; set; }
        public string Cliente { get; set; }
        public string Rif { get; set; }
    }
}

