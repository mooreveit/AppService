using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class CredentialsDto
    {

        public string User { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public bool Validate { get; set; }
        public string Role { get; set; }
        public List<PageMenuDto> PageMenuDto { get; set; }

        

    }
}
