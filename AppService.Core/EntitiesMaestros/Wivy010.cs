using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy010
    {
        public decimal Recnum { get; set; }
        public int NroReq { get; set; }
        public string Dpto { get; set; }
        public string TipoSolicitud { get; set; }
        public string Origen { get; set; }
        public string Urgente { get; set; }
        public string Destino { get; set; }
        public string NroCer { get; set; }
        public string Motivo1 { get; set; }
        public string Motivo2 { get; set; }
        public short UltimoItem { get; set; }
        public string Comprador { get; set; }
        public short TipoTransporte { get; set; }
        public short CondPago { get; set; }
        public string Moneda { get; set; }
        public decimal FleteBs { get; set; }
        public decimal FleteMoneda { get; set; }
        public decimal Tasa { get; set; }
        public string ReqCompleta { get; set; }
        public DateTime? FechaElaborada { get; set; }
        public DateTime? FechaGrabada { get; set; }
        public DateTime? FechaRecCompr { get; set; }
        public DateTime? FechaEstimada { get; set; }
        public DateTime? FechaColocada { get; set; }
        public DateTime? FechaAnulada { get; set; }
        public DateTime? FechaUltRecep { get; set; }
        public short Status { get; set; }
        public string ReqAlmacen { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public string FlagRecorrido { get; set; }
        public string Solicitante { get; set; }
        public string SinProcesar { get; set; }
        public string NoRecibidaPlanta { get; set; }
    }
}
