using AppService.Core.Interfaces;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace AppService.Api.WorkersFolder
{
    public class Worker : BackgroundService
    {



        private readonly ICotizacionService _cotizacionService;

        public Worker(ICotizacionService cotizacionService)
        {

            _cotizacionService = cotizacionService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {

                await _cotizacionService.UpdateCotizacionesToOdoo();
                await Task.Delay(60000, stoppingToken);

            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }


    }
}
