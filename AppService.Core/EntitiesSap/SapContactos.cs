using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapContactos
    {
        public decimal Id { get; set; }
        public decimal IdContacto { get; set; }
        public string Kunnr { get; set; }
        public string Parnr { get; set; }
        public string TitleMedi { get; set; }
        public string Name1 { get; set; }
        public string Namev { get; set; }
        public string Pafkt { get; set; }
        public string Abtnr { get; set; }
        public string Telf1 { get; set; }
        public string Telf2 { get; set; }
        public string StmpAddr { get; set; }
        public string Fax { get; set; }
        public string Pavip { get; set; }
        public string Gbdat { get; set; }
        public string Parvo { get; set; }
        public string Nmail { get; set; }
        public string Procesado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }

        public virtual SapDepartamentoContacto AbtnrNavigation { get; set; }
        public virtual SapCargoContacto PafktNavigation { get; set; }
        public virtual SapPoderContacto ParvoNavigation { get; set; }
    }
}
