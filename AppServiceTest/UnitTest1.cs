using AppService.Core.Interfaces;
using AppService.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AppServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ICotizacionService _cotizacionService;
        private readonly ICobEstadoCuentaService _cobEstadoCuentaService;
        public UnitTest1(ICotizacionService cotizacionService, ICobEstadoCuentaService cobEstadoCuentaService)
        {
            _cotizacionService = cotizacionService;
            _cobEstadoCuentaService = cobEstadoCuentaService;
        }
      

       [TestMethod]
        public async Task estMethodEstadoCuenta ()
        {

           
            await _cobEstadoCuentaService.GenerateEstadoCuentaMultimoneda();
            var result = true;
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public async Task TestMethod1()
        {

            string cotizacion = "GJ33202105022";
            await _cotizacionService.IntegrarCotizacion(300, true);
            var result = await _cotizacionService.ExisteWpry229ByCotizacion(cotizacion);
            Assert.AreEqual(true, result);
        }
    }
}
