using AppService.Core.Interfaces;
using Microsoft.Extensions.Hosting;

namespace Automata.Workers
{
    public class WorkerPresupuestoOdoo : BackgroundService
    {
        private readonly ICotizacionService _cotizacionService;

        public WorkerPresupuestoOdoo(ICotizacionService cotizacionService)
        {
            _cotizacionService = cotizacionService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                Console.WriteLine("Ejecutando worker cada 120 minuto");
                 Console.WriteLine("Iniciando envio de clientes a Odoo");
                 await _cotizacionService.ActualizarClientes();
                 Console.WriteLine("Culminado envio de Contactos a Odoo: "  + DateTime.Today.ToLongDateString() + "-" + DateTime.Today.ToLongTimeString()) ;
                




                /*Console.WriteLine("Iniciando envio de cotizaciones a Odoo");
                await _cotizacionService.UpdateCotizacionesToOdoo();
                Console.WriteLine("Culminado envio de cotizaciones a Odoo: " +  DateTime.Today.ToLongDateString() + "-" + DateTime.Today.ToLongTimeString());
                */

                await Task.Delay(1200000); 



            }
        }



    }
}
