using System;

namespace AppService.Core.Utility
{
    public static class EsProspecto
    {
        public static bool ClienteEsProspecto(string idCliente)
        {
            bool result = false;
            if (idCliente == "0" || idCliente == "000000")
            {

                result = true;


            }
            return result;
        }
    }
}