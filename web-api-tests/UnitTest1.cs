using AppService.Api.Controllers;
using AppService.Core.Interfaces;
using AppService.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Xunit;

namespace web_api_tests
{
    public class UnitTest1
    {
        private readonly ICotizacionService _cotizacionService;

        public UnitTest1(ICotizacionService cotizacionService)
        {
            _cotizacionService = cotizacionService;
        }


        [TestMethod]
        public async Task Test1()
        {


           await  _cotizacionService.IntegrarCotizacion(300,true);
        }
    }
}
