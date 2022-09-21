using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("charppolicy")]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ISegUsuarioService _segUsuarioService;

        public TokenController(IConfiguration configuration, ISegUsuarioService segUsuarioService)
        {
            _configuration = configuration;
            _segUsuarioService = segUsuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Authentication(UserLogin login)
        {


            CredentialsDto result = new CredentialsDto();
            var cedentialDto = await IsValiduser(login);
            if (cedentialDto.Validate)
            {


                string token = _segUsuarioService.GenerateToken();

                result.Token = token;
                result.User = login.User;
                result.Validate = cedentialDto.Validate;
                result.Role = cedentialDto.Role;
                if (result.Role == "358")
                {
                    result.Role = "387";
                }



                List<PageMenuDto> resultMenu = new List<PageMenuDto>();
                resultMenu = await _segUsuarioService.GetMenuDtoByRole(Convert.ToInt32(result.Role));

                result.PageMenuDto = resultMenu;


            }
            else
            {
                result.Token = "";
                result.User = login.User;
                result.Validate = cedentialDto.Validate;
                result.Role = cedentialDto.Role;
            }
            return Ok(result);

        }

        private async Task<CredentialsDto> IsValiduser(UserLogin login)
        {
            return await _segUsuarioService.UsuarioValido(login.User, login.Password);
        }

        private string GenerateTokenbk()
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
                DateTime.UtcNow.AddMinutes(20)

             );

            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }




    }
}