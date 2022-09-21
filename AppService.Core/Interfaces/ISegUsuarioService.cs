using AppService.Core.DTOs;
using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISegUsuarioService
    {
        Task<SegUsuario> GetUsuario(string id);

        Task<CredentialsDto> UsuarioValido(string usuario, string password);

        string GenerateToken();

        Task<List<PageMenuDto>> GetMenuDtoByRole(int role);
    }
}
