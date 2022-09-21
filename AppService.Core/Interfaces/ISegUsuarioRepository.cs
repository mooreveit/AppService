using AppService.Core.DTOs;
using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISegUsuarioRepository 
    {
        

        Task<SegUsuario> GetUser(string id);
        Task<CredentialsDto> UsuarioValido(string Usuario, string Password);
        
    }
}
