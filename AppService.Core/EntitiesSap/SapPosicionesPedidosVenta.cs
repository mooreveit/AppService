using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapPosicionesPedidosVenta
    {
        public decimal Id { get; set; }
        public string Mandt { get; set; }
        public string Vbeln { get; set; }
        public decimal? Posnr { get; set; }
        public string Matnr { get; set; }
        public decimal? Kwmeng { get; set; }
        public string Vrkme { get; set; }
        public decimal? Kpein { get; set; }
        public string Kmein { get; set; }
        public string Charg { get; set; }
        public decimal? Kbetr { get; set; }
        public string Descrip { get; set; }
        public decimal? Bultos { get; set; }
        public string ControlDesde { get; set; }
        public string ControlHasta { get; set; }
        public string FormatoDesde { get; set; }
        public string FormatoHasta { get; set; }
        public string FechaUpdate { get; set; }
        public string HoraUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public decimal? PedidoSap { get; set; }
        public decimal? IdPrelista { get; set; }
        public decimal? IdRegistroPreLista { get; set; }
        public string Almacen { get; set; }
        public string Orden { get; set; }
        public short? Copy { get; set; }
        public decimal? ValorNeto { get; set; }
        public string Moneda { get; set; }
    }
}
