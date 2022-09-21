using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SegUsuarioRepository : ISegUsuarioRepository
    {
        private readonly RRDContext _context;

        public SegUsuarioRepository(RRDContext context) 
        {
            _context = context;
        }

        public async Task<SegUsuario> GetUser(string id)
        {
            var result = await _context.SegUsuario.Where(x => x.Usuario == id ).FirstOrDefaultAsync();
            return result;
        }

      

        public async Task<CredentialsDto> UsuarioValido(string Usuario, string Password)
        {

            bool Validado = false;
            CredentialsDto credentialsDto = new CredentialsDto();

            //var usu = await _context.SegUsuario.Where(x => x.Usuario == Usuario ).FirstOrDefaultAsync();

                var BuscarUsuario = (from u in _context.SegUsuario
                                     join ur in _context.SegUsuarioRol on u.IdUsuario equals ur.IdUsuario
                                     join r in _context.SegRol on ur.IdRol equals r.IdRol
                                     where u.Usuario == Usuario & r.IdPrograma == 141
                                     select new { Clave = u.Clave, IdRol = r.IdRol, NombreUsuario = u.NombreUsuario }).FirstOrDefault();

                if (BuscarUsuario != null)
                {

                    if (BuscarUsuario.Clave == ConvertSha1(Password))
                    {

                        credentialsDto.Validate = true;
                        credentialsDto.User = Usuario;
                    credentialsDto.Role = BuscarUsuario.IdRol.ToString();



                    }





                }

            

            return credentialsDto;

        }

        public string ConvertSha1(string str)
        {
            System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1Managed.Create();
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] stream = null;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i <= (stream.Length - 1); i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();
        }

      

       
    }
}
