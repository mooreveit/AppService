using AppService.Core.DTOs.ConvertFile;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertirArchivoController : ControllerBase
    {


        [HttpPost]
        [Route("[action]")]

        public async Task<IActionResult> ConvertirArchivo(ConvertFileDto dto)
        {

            await Convertir(dto);

            return Ok(dto);

        }

        public async Task Convertir(ConvertFileDto dto)
        {


            List<string> listaOriginal = new List<string>();

            //Paso I Lee archivo de texto y agrega a una lista en memoria
            foreach (string item in System.IO.File.ReadLines(@"C:\Temp\Origen\origen.txt"))
            {

                listaOriginal.Add(item);

            }


            //Paso II Recorre la lista en memoria y sustituye NR: por nulo
            //        Agrega los nulos adicionales
            int cuentaNulo = 0;
            List<string> nuevaLista = new List<string>();
            foreach (string item in listaOriginal)
            {
                string nuevoItem = item;
                if (item.StartsWith("Nr:"))
                {
                    nuevoItem = "Nulo";
                    cuentaNulo++;

                }

                nuevaLista.Add(nuevoItem);
                if (cuentaNulo == dto.CatidadNulosEnArchivo)
                {

                    for (int i = 0; i < dto.CantidadNulosAdicionales; i++)
                    {
                        nuevaLista.Add(nuevoItem);

                    }

                    cuentaNulo = 0;
                }

            }

            //Crea archivo destino 
            StreamWriter sw = new StreamWriter(@"C:\Temp\Destino\destino.txt", true, System.Text.Encoding.ASCII);
            foreach (var item in nuevaLista)
            {
                sw.WriteLine(item);
            }

            sw.Close();




        }
    }



}
