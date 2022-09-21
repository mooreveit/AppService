using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapGeneralPedidosVenta
    {
        public decimal Id { get; set; }
        public string Mandt { get; set; }
        public string Vbeln { get; set; }
        public string Auart { get; set; }
        public string Vkorg { get; set; }
        public string Vtweg { get; set; }
        public string Spart { get; set; }
        public string Vkbur { get; set; }
        public string Vkgrp { get; set; }
        public string Kunnr { get; set; }
        public string Kunnr2 { get; set; }
        public string Bstkd { get; set; }
        public string Bstdk { get; set; }
        public string Zterm { get; set; }
        public decimal? PedidoSap { get; set; }
        public decimal? IdPrelista { get; set; }
        public string Orden { get; set; }
        public long? Job { get; set; }
        public short? Copy { get; set; }
        public string TextCabecera { get; set; }
        public string FechaUpdate { get; set; }
        public string HoraUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public string Procesado { get; set; }
        public string Pltyp { get; set; }
    }
}
