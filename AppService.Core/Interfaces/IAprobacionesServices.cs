using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAprobacionesServices
    {
        Task<Wsmy639> GetByCotizacionRenglonPrpopuesta(string cotizacion, int renglon, int propuesta);

        Task<ApiResponse<Wsmy639>> CreateAprobacion(string cotizacion, int renglon, int propuesta, string UsuarioConectado);

        Task<ApiResponse<Wsmy647>> ActivarWORKFLOW(string cotizacion, int renglon, int propuesta, string usuarioConectado, AppDetailQuotes appDetailQuotes);

        Task<ApiResponse<Wsmy639>> CreateAprobacionAprobada(string cotizacion, int renglon, int propuesta, string UsuarioConectado);

    }
}
