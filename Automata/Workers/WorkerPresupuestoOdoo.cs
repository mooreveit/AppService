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

                Console.WriteLine("Ejecutando worker cada 1 minuto");
                Console.WriteLine("Iniciando envio de cotizaciones a Odoo");
                await _cotizacionService.UpdateCotizacionesToOdoo();
                Console.WriteLine("Culminado envio de cotizaciones a Odoo");
                await Task.Delay(60000);



            }
        }



    }
}
