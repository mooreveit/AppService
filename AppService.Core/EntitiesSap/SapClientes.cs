using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapClientes
    {
        public decimal Id { get; set; }
        public string Kunnr { get; set; }
        public string Vkorg { get; set; }
        public string Vtweg { get; set; }
        public string Spart { get; set; }
        public string Prfre { get; set; }
        public string Kdgrp { get; set; }
        public string Brsch { get; set; }
        public string Bran1 { get; set; }
        public string Regio { get; set; }
        public string Ort01 { get; set; }
        public string Ort02 { get; set; }
        public string Telf1 { get; set; }
        public string Telf2 { get; set; }
        public string StmpAddr { get; set; }
        public string Zzsn01 { get; set; }
        public string Zzsn02 { get; set; }
        public string Zzsn03 { get; set; }
        public string Zzsn04 { get; set; }
        public string Zzsn05 { get; set; }
        public string Zzsn06 { get; set; }
        public string Lzone { get; set; }
        public string Procesado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime? FechaUpdate { get; set; }
    }
}
