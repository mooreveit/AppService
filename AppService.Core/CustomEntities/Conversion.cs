namespace AppService.Core.CustomEntities
{
    public class Conversion
    {
        //entradas
        public decimal x_numerador { get; set; }
        public decimal y_denominador { get; set; }
        public decimal cantidadBase { get; set; }


        //Result
        public decimal cantidadAlternativa { get; set; }

        public Conversion(decimal x_numerador, decimal y_denominador, decimal cantidadBase)
        {
            this.x_numerador = x_numerador;
            this.y_denominador = y_denominador;
            this.cantidadBase = cantidadBase;
        }


        //Metodos
        public decimal getCantidadAlternativa()
        {
            var cociente = this.x_numerador / this.y_denominador;
            this.cantidadAlternativa = this.cantidadBase * cociente;
            return this.cantidadAlternativa;
        }


    }
}
