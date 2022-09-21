using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Infrastructure.Repositories
{
    public class HelperService: IHelperService
    {

        public List<string> GetListString(string str, string initialDelimeter, string endDelimeter)
        {


            int longitudStr = 0;
            int delimitadorInicialPosicion = 0;
            int delimitadorFinalPosicion = 0;
            string valor = "";
            string newValue = "";

            var myList = new List<string>();
            var n = str.IndexOf(initialDelimeter);
            var contiene = str.Contains(initialDelimeter);
            while (str.Contains(initialDelimeter))
            {
                delimitadorInicialPosicion = str.IndexOf(initialDelimeter);
                delimitadorFinalPosicion = str.IndexOf(endDelimeter);
                valor = str.Substring(delimitadorInicialPosicion + 1, (delimitadorFinalPosicion - delimitadorInicialPosicion) - 1);
                longitudStr = str.Length;
                newValue = str.Substring(delimitadorFinalPosicion + 1, (longitudStr - delimitadorFinalPosicion) - 1);
                myList.Add(valor);
                str = newValue;

            }

            return myList;

        }
    }
}
