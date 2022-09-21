using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy370
    {
        public string NroCotizacion { get; set; }
        public int NroPropuesta { get; set; }
        public int IdPropuesta { get; set; }
        public int CorrelativoCal { get; set; }
        public string NroCalculo { get; set; }
        public string CodVendedor { get; set; }
        public string CodigoProducto { get; set; }
        public int? CantFormas { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public string TransferRem { get; set; }
        public string TransferPerm { get; set; }
        public string TransferExtra { get; set; }
        public decimal? MedidaBasica { get; set; }
        public int? NroPartes { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? BolivMc { get; set; }
        public decimal? PorcComis { get; set; }
        public decimal? BolivComis { get; set; }
        public decimal? NroTintas { get; set; }
        public decimal? CantTransferRem { get; set; }
        public decimal? CantTransferPerm { get; set; }
        public decimal? CantTransferExtra { get; set; }
        public decimal? RvalorLista { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
