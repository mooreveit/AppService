using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICotizacionService
    {
        Task IntegrarCotizacionesPorMes();
        Task<List<Wsmy501>> GetAll();


        Task<Wsmy501> GetById(int id);

        Task<Wsmy501> GetByCotizacion(string cotizacion);

        Task<Wsmy501> Insert(Wsmy501 cotizacion);

        Task<ApiResponse<CotizacionGetDto>> CreateCotizacion(CotizacionCreateDto dto);

        Task<Wsmy501> Update(Wsmy501 cotizacion);

        Task<ApiResponse<CotizacionGetDto>> UpdateCotizacion(CotizacionUpdateDto dto);

        Task<bool> Delete(string cotizacion);

        Task<ApiResponse<bool>> DeleteCotizacionOld(CotizacionDeleteDtocs dto);
        Task DeleteCotizacion(AppGeneralQuotes appGeneralQuotes);

        Task IntegrarCotizacion(int generalQuotesId, bool actualizarDetalle);


        Task DeleteCotizacionRenglon(AppDetailQuotes appDetailQuotes);

        Task updateMedidas();

        Task PasarDatosACeos(string cotizacion, string producto);

        Task IntegrarCotizaciones();

        Task UpdateSolicitudPropuesta(string cotizacion, int renglon, int propuesta, int idSolicitud);

        Task<Boolean> ExisteWpry229ByCotizacion(String cotizacion);

        Task UpdateCotizacionesToOdoo();


        Task<string> GetClienteCotizacion(string cotizacion);

        Task<Wsmy501> GetByCotizacionAsNoTracking(string cotizacion);
        Task DeleteCotizacionesDetailToOdoo(List<int> mooreIds);
        Task DeleteCotizacionesToOdoo(List<string> cotizaciones);
        Task ActualizarClientes();

    }
}
