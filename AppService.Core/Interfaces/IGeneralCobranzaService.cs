using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.Sap;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IGeneralCobranzaService
    {


        Task GeneraRecibo(long documento, string usuario);
        Task<IEnumerable<CobGeneralCobranza>> GetGeneralCobranza(GeneralCobranzaQueryFilter filters);

        Task<CobGeneralCobranza> GetGeneralCobranzaPorDocumento(long documento);

        Task<CobGeneralCobranza> InsertGeneralCobranza(CobGeneralCobranza generalCobranza);

        Task<CobGeneralCobranza> UpdateGeneralCobranza(CobGeneralCobranza generalCobranza);

        Task<bool> DeleteGeneralCobranza(long documento);

        Task<Metadata> ValidaInsertCobranza(CobGeneralCobranza generalCobranza);

        Task<Metadata> ValidaUpdateCobranza(CobGeneralCobranza generalCobranza);

        Task<ReciboDto> GeneraReciboDto(long recibo);
               

       
        Metadata GeneraPdfRecibo(ReciboDto reciboDto, string sufijoFileName);

        Task<IEnumerable<CobGeneralCobranza>> GetGeneralCobranzaPendienteVerificarPago(GeneralCobranzaQueryFilter filters);

        Task<IEnumerable<CobGeneralCobranza>> GetGeneralCobranzaPendienteAprobarPago(GeneralCobranzaQueryFilter filters);

        Task UpdateSearchText();

        Task<List<ReciboEnviarSapDto>> GeneraListObjectSap(ReciboDto reciboDto);

        string EstatusRecibo(CobGeneralCobranza cobranza);

        Task<List<AppService.Core.DTOs.SapEnviarSoloRetencion.Application>> GeneraListSapEnviarSoloRetencion(ReciboDto reciboDto);


    }
}
