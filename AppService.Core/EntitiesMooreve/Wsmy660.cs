using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy660
    {
        public decimal Id { get; set; }
        public string Cia { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public int IdSubCategoria { get; set; }
        public string DescripcionSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public decimal? MontoMaximo { get; set; }
        public decimal? PorcentaJeAdicional { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string EnviarEmail { get; set; }
        public string EnviarSms { get; set; }
        public string UltimoEmailEnviado { get; set; }
        public string UltimoSmsEnviado { get; set; }
    }
}
