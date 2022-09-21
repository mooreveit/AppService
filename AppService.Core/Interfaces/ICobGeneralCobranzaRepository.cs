using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobGeneralCobranzaRepository
    {
        Task<CobGeneralCobranza> ExisteCobranzaPendienteEnviar(CobGeneralCobranza generalCobranza);

        Task<IEnumerable<CobGeneralCobranza>> ListCobranzaPorUsuario(GeneralCobranzaQueryFilter filter);
        IEnumerable<CobGeneralCobranza> GetAll();
        Task<CobGeneralCobranza> GetById(long id);
        Task Add(CobGeneralCobranza entity);
        Task Update(CobGeneralCobranza entity);
        Task Delete(long id);
        Task<CobGrabacionCobranzas> RCRUYaTieneCobranzaGrabada(long documento);
        Task<CobGrabacionCobranzas> RETYaTieneCobranzaGrabada(long documento);
        Task<IEnumerable<CobGeneralCobranza>> ListCobranzaPorUsuarioPendienteVerificarPago(GeneralCobranzaQueryFilter filter);
        Task<IEnumerable<CobGeneralCobranza>> ListGeneralCobranzaPendienteAprobarPago(GeneralCobranzaQueryFilter filter);
        Task<CobGeneralCobranza> GetGeneralCobranzaDocumento(long documento);
        Task<List<CobGeneralCobranza>> GetAllSearchTextBlanco();
    }
}
