using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class OfdCotizacionService: IOfdCotizacionService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly PaginationOptions _paginationOptions;

        public OfdCotizacionService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
        }

        public async Task<OfdCotizacion> GetCotizacion(string cotizacion)
        {


            var cotizacionObj = await _unitOfWork.OfdCotizacionRepository.GetByCotizacion(cotizacion);

        
            return cotizacionObj;
        }

    }
}
