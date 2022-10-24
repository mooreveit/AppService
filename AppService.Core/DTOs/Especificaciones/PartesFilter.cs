namespace AppService.Core.DTOs.Especificaciones
{
    public class PartesFilter
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }

        public int IdAppDetailQuote { get; set; }
        public int IdProducto { get; set; }
    }
}
