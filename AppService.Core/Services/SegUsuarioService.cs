using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class SegUsuarioService : ISegUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        private readonly PaginationOptions _paginationOptions;

        public SegUsuarioService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> options, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _paginationOptions = options.Value;
        }

        public async  Task<SegUsuario> GetUsuario(string id)
        {
            return await _unitOfWork.SegUsuarioRepository.GetUser(id);
        }

        public async Task<CredentialsDto> UsuarioValido(string usuario, string password)
        {
          

            return await _unitOfWork.SegUsuarioRepository.UsuarioValido(usuario, password);

        }

        public string GenerateToken()
        {
            //Header

            SymmetricSecurityKey _symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecrectKey"]));
            SigningCredentials signingCredentials = new SigningCredentials(_symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            JwtHeader header = new JwtHeader(signingCredentials);

            //Claims
            Claim[] claims = new[]
            {
                new Claim(ClaimTypes.Name,"Franklin Reveron"),

                new Claim(ClaimTypes.Role,"Admin"),

                new Claim(ClaimTypes.Email,"Franklin.Reveron@gmail.com"),

            };


            //Payload

            JwtPayload payload = new JwtPayload
            (

                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.Now,
                DateTime.UtcNow.AddDays(30)

             );

            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public async Task<List<PageMenu>> GetMenuByRole(int role)
        {
           
            return await _unitOfWork.PageMenuRepository.GetMenuByRole(role);
           
        }

        public async Task<List<ChildMenu>> GetChildMenuByParent(int idMenu)
        {
            return await _unitOfWork.ChildMenuRepository.GetChildMenuByParent(idMenu);
        }

        public async Task<List<PageMenuDto>> GetMenuDtoByRole(int role)
        {

            List<PageMenuDto> result =  new List<PageMenuDto>();

            var menu = await  GetMenuByRole(role);
            if (menu!= null)
            {
                foreach (var itemMenu in menu)
                {
                    PageMenuDto resultItemMenu = new PageMenuDto();

                    resultItemMenu.Icon = itemMenu.Icon;
                    resultItemMenu.Id = itemMenu.Id;
                    resultItemMenu.Role = (int)itemMenu.Role;
                    resultItemMenu.Title = itemMenu.Title;
                    resultItemMenu.Url = itemMenu.Url;

                    List<Children> resultChild = new List<Children>();
                    var child = await GetChildMenuByParent(itemMenu.Id);

                    if (child!=null)
                    {
                    
                        foreach (var itemChild in child)
                        {
                            Children itemChildDto = new Children();
                            itemChildDto.Id = itemChild.Id;
                            itemChildDto.Title = itemChild.Title;
                            itemChildDto.Url = itemChild.Url;
                            itemChildDto.PageMenuId = (int)itemChild.PageMenuId;
                            itemChildDto.Icon = itemChild.Icon;
                           
                            resultChild.Add(itemChildDto);
                        }
                        resultItemMenu.Children = resultChild;
                    }

                    result.Add(resultItemMenu);
                }
               
            }

            return result;

        }



    }
}
