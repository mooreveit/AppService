namespace AppService.Core.EntitiesMooreve
{
    public class ValoresAdicionalesProducto

    {
        public int Id { get; set; }

        public string Linea { get; set; }

        public string Familia { get; set; }

        //WPRY248.IdVariable
        public string IdVariable { get; set; }

        //WPRY248.FlagMultipleValor,
        public string FlagMultipleValor { get; set; }

        //WPRY248.FlagGralParte,
        public string FlagGralParte { get; set; }

        //WPRY249.Valor,
        public string Valor { get; set; }

        //WPRY249.Bd,
        public string Bd { get; set; }


        //WPRY249.Tabla,
        public string Tabla { get; set; }

        //WPRY249.Campo,
        public string Campo { get; set; }


        //WPRY249.FlagTransformacion,
        public string FlagTransformacion { get; set; }

        //WPRY249.ValorTransformacion
        public string ValorTransformacion { get; set; }
        public long Orden { get; set; }
        public string ValorBusqueda { get; set; }


    }
}
