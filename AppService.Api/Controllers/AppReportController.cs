using AppService.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;

namespace AppService.Api.Controllers
{


    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppReportController : ControllerBase
    {


        [HttpGet("[action]/{cotizacion}/{flagTotal}/{flagFormasCaja}/{flagIva}/{observaciones}/{imprimirUsd}/{subcategoria?}")]
        //[HttpPost]
        //[Route("[action]")]
        public IActionResult GetCotizacion(string cotizacion, bool flagTotal, bool flagFormasCaja, bool flagIva, bool observaciones, bool imprimirUsd, int? subcategoria = null)
        {


            ReporteCotizacionDto dto = new ReporteCotizacionDto();

            dto.ParametroCotizacion = "Cotizacion";
            dto.Cotizacion = cotizacion;


            dto.ParametroFlagTotal = "FlagTotal";
            dto.FlagTotal = flagTotal;


            dto.ParametroFlagFormasCaja = "FlagFormasCaja";
            dto.FlagFormasCaja = flagFormasCaja;


            dto.ParametroFlagIva = "FlagIva";
            dto.FlagIva = flagIva;

            dto.ParametroObservaciones = "Observaciones";
            dto.Observaciones = observaciones;

            dto.ParametroImprimirUsd = "ImprimirUsd";
            dto.ImprimirUsd = imprimirUsd;


            //Todo agregar urls,credenciales al settings  y hacer metodo async

            //URL Base de mi servidor de reporte con la peticion de parametro en la url
            //string urlBase = "https://myrshost/ReportServer?/myreport&PARAMETRO=";
            string myreport = "";

            if (subcategoria == 1)
            {
                myreport = "Ventas/Cotizador Plus/AppCotizacionPlusFormas";

            }
            if (subcategoria == 2)
            {
                myreport = "Ventas/Cotizador Plus/CotizacionPlusStock";
            }
            if (subcategoria > 2)
            {
                myreport = "Ventas/Cotizador Plus/CotizacionPlusFormas";
            }


            // string myreport = "Ventas/Cotizador Plus/CotizacionFormasVentas";

            string urlBase = "http://vmooreapp2/ReportServer_FSVEMCYN03D?/" + myreport;
            // aqui es donde indicas en que formato quieres obtener el reporte
            string formatoReporte = "&rs:Format=pdf";

            // la url final
            string url = urlBase
                + "&" + dto.ParametroCotizacion + "=" + dto.Cotizacion
                + "&" + dto.ParametroFlagTotal + "=" + dto.FlagTotal
                + "&" + dto.ParametroFlagFormasCaja + "=" + dto.FlagFormasCaja
                + "&" + dto.ParametroFlagIva + "=" + dto.FlagIva
                + "&" + dto.ParametroObservaciones + "=" + dto.Observaciones
                + "&" + dto.ParametroImprimirUsd + "=" + dto.ImprimirUsd
                + formatoReporte;




            try
            {
                urlBase = url.Replace("\n", "");
                System.Net.WebRequest request = WebRequest.Create(urlBase);
                // pasas las credenciales para conectarte al servidor de reporte de reporting services
                NetworkCredential credentials = new NetworkCredential(@"RR105841", "Polar2023*", "Moore");
                request.Credentials = credentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                string nameFile = dto.Cotizacion + "_" + DateTime.Now.ToString() + ".pdf";
                return File(stream, "application/pdf", nameFile);




            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("[action]/{cotizacion}/{flagTotal}/{flagFormasCaja}/{flagIva}/{observaciones}/{imprimirUsd}/{subcategoria?}")]
        //[HttpPost]
        //[Route("[action]")]
        public IActionResult GetCotizacionWord(string cotizacion, bool flagTotal, bool flagFormasCaja, bool flagIva, bool observaciones, bool imprimirUsd, int? subcategoria = null)
        {


            ReporteCotizacionDto dto = new ReporteCotizacionDto();

            dto.ParametroCotizacion = "Cotizacion";
            dto.Cotizacion = cotizacion;


            dto.ParametroFlagTotal = "FlagTotal";
            dto.FlagTotal = flagTotal;


            dto.ParametroFlagFormasCaja = "FlagFormasCaja";
            dto.FlagFormasCaja = flagFormasCaja;


            dto.ParametroFlagIva = "FlagIva";
            dto.FlagIva = flagIva;

            dto.ParametroObservaciones = "Observaciones";
            dto.Observaciones = observaciones;

            dto.ParametroImprimirUsd = "ImprimirUsd";
            dto.ImprimirUsd = imprimirUsd;


            //Todo agregar urls,credenciales al settings  y hacer metodo async

            //URL Base de mi servidor de reporte con la peticion de parametro en la url
            //string urlBase = "https://myrshost/ReportServer?/myreport&PARAMETRO=";
            string myreport = "";
            if (subcategoria == 1)
            {
                myreport = "Ventas/Cotizador Plus/AppCotizacionPlusFormas";
            }
            if (subcategoria == 2)
            {
                myreport = "Ventas/Cotizador Plus/CotizacionPlusStock";
            }
            if (subcategoria > 2)
            {
                myreport = "Ventas/Cotizador Plus/CotizacionPlusFormas";
            }



            // string myreport = "Ventas/Cotizador Plus/CotizacionFormasVentas";

            string urlBase = "http://vmooreapp2/ReportServer_FSVEMCYN03D?/" + myreport;
            // aqui es donde indicas en que formato quieres obtener el reporte
            string formatoReporte = "&rs:Format=word";
            // la url final
            string url = urlBase
                + "&" + dto.ParametroCotizacion + "=" + dto.Cotizacion
                + "&" + dto.ParametroFlagTotal + "=" + dto.FlagTotal
                + "&" + dto.ParametroFlagFormasCaja + "=" + dto.FlagFormasCaja
                + "&" + dto.ParametroFlagIva + "=" + dto.FlagIva
                + "&" + dto.ParametroObservaciones + "=" + dto.Observaciones
                + "&" + dto.ParametroImprimirUsd + "=" + dto.ImprimirUsd
                + formatoReporte;


            try
            {
                urlBase = url.Replace("\n", "");
                System.Net.WebRequest request = WebRequest.Create(urlBase);
                // pasas las credenciales para conectarte al servidor de reporte de reporting services
                NetworkCredential credentials = new NetworkCredential(@"RR105841", "Polar2023*", "Moore");
                request.Credentials = credentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                string nameFile = dto.Cotizacion + "_" + DateTime.Now.ToString() + ".doc";
                return File(stream, "application/word", nameFile);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("[action]/{cotizacion}/{flagTotal}/{flagFormasCaja}/{flagIva}/{observaciones}/{imprimirUsd}/{subcategoria?}")]
        //[HttpPost]
        //[Route("[action]")]
        public IActionResult GetCotizacionExcel(string cotizacion, bool flagTotal, bool flagFormasCaja, bool flagIva, bool observaciones, bool imprimirUsd, int? subcategoria = null)
        {


            ReporteCotizacionDto dto = new ReporteCotizacionDto();

            dto.ParametroCotizacion = "Cotizacion";
            dto.Cotizacion = cotizacion;


            dto.ParametroFlagTotal = "FlagTotal";
            dto.FlagTotal = flagTotal;


            dto.ParametroFlagFormasCaja = "FlagFormasCaja";
            dto.FlagFormasCaja = flagFormasCaja;


            dto.ParametroFlagIva = "FlagIva";
            dto.FlagIva = flagIva;

            dto.ParametroObservaciones = "Observaciones";
            dto.Observaciones = observaciones;

            dto.ParametroImprimirUsd = "ImprimirUsd";
            dto.ImprimirUsd = imprimirUsd;


            //Todo agregar urls,credenciales al settings  y hacer metodo async

            //URL Base de mi servidor de reporte con la peticion de parametro en la url
            //string urlBase = "https://myrshost/ReportServer?/myreport&PARAMETRO=";
            string myreport = "";
            if (subcategoria == 1)
            {
                myreport = "Ventas/Cotizador Plus/AppCotizacionPlusFormas";
            }
            if (subcategoria == 2)
            {
                myreport = "Ventas/Cotizador Plus/CotizacionPlusStock";
            }
            if (subcategoria > 2)
            {
                myreport = "Ventas/Cotizador Plus/CotizacionPlusFormas";
            }



            // string myreport = "Ventas/Cotizador Plus/CotizacionFormasVentas";
            string urlBase = "http://vmooreapp2/ReportServer_FSVEMCYN03D?/" + myreport;
            // aqui es donde indicas en que formato quieres obtener el reporte
            string formatoReporte = "&rs:Format=excel";
            // la url final
            string url = urlBase
                + "&" + dto.ParametroCotizacion + "=" + dto.Cotizacion
                + "&" + dto.ParametroFlagTotal + "=" + dto.FlagTotal
                + "&" + dto.ParametroFlagFormasCaja + "=" + dto.FlagFormasCaja
                + "&" + dto.ParametroFlagIva + "=" + dto.FlagIva
                + "&" + dto.ParametroObservaciones + "=" + dto.Observaciones
                + "&" + dto.ParametroImprimirUsd + "=" + dto.ImprimirUsd
                + formatoReporte;


            try
            {
                urlBase = url.Replace("\n", "");
                System.Net.WebRequest request = WebRequest.Create(urlBase);
                // pasas las credenciales para conectarte al servidor de reporte de reporting services
                NetworkCredential credentials = new NetworkCredential(@"RR105841", "Polar2023*", "Moore");
                request.Credentials = credentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                string nameFile = dto.Cotizacion + "_" + DateTime.Now.ToString() + ".xls";
                return File(stream, "application/excel", nameFile);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}