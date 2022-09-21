using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppVariablesGetDto
    {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int TipoVariable { get; set; }
    }
}
