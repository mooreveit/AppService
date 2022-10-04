using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class PostVentaStock
    {
        public decimal? Orden { get; set; }
        public string Cliente { get; set; }
        public DateTime? Entrega { get; set; }
        public decimal? CodOficina { get; set; }
        public string Oficina { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public decimal? RecordNumber { get; set; }
        public string CodCliente { get; set; }
        public string Telefono { get; set; }
        public string Telefono1 { get; set; }
        public string Fax { get; set; }
        public string NoRegTribut { get; set; }
        public string ContNomb1 { get; set; }
        public string ContTelf1 { get; set; }
        public string ContEmail1 { get; set; }
        public string ContNomb2 { get; set; }
        public string ContTelf2 { get; set; }
        public string ContEmail2 { get; set; }
        public string ContNomb3 { get; set; }
        public string ContTelf3 { get; set; }
        public string ContEmail3 { get; set; }
    }
}
