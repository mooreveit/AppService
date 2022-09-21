using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy261
    {
        public string NroCotizacion { get; set; }
        public int NroPropuesta { get; set; }
        public string Descripcion { get; set; }
        public string CodigoProducto { get; set; }
        public string TipoProducto { get; set; }
        public string EstadoPro { get; set; }
        public decimal? UnidadCosteo { get; set; }
        public string Estacion { get; set; }
        public decimal? OperacionBasica { get; set; }
        public decimal? NumPc { get; set; }
        public string NroCotizacionAnt { get; set; }
        public int? NroPropuestaAnt { get; set; }
        public string CodLista { get; set; }
        public int? CodReferencia { get; set; }
        public string FlagAprob { get; set; }
        public string ReqAprobMc { get; set; }
        public string FlagAprobMc { get; set; }
        public string ReqAprobExcep { get; set; }
        public string FlagAprobExcep { get; set; }
        public string ReqSoporteApro { get; set; }
        public string ControlCr { get; set; }
    }
}
