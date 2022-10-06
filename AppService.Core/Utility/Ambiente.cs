namespace AppService.Core.Utility
{
    public static class Ambiente
    {

        public static int ValorAmbiente()
        {
            //1=Produccion
            //2=Pruebas

            return 1;

        }

        public static string ValorSector()
        {
            //1=Produccion
            //2=Pruebas

            var ambiente = ValorAmbiente();
            var valorSector = "";
            if (ambiente == 1)
            {
                valorSector = "999";
            }
            else
            {
                valorSector = "53";
            }

            return valorSector;

        }
        public static string ValorRamo()
        {
            //1=Produccion
            //2=Pruebas
            var ambiente = ValorAmbiente();
            var valorramo = "";
            if (ambiente == 1)
            {
                valorramo = "999";
            }
            else
            {
                valorramo = "498";
            }

            return valorramo;

        }
    }
}
