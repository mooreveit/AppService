using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy019
    {
        public decimal Recnum { get; set; }
        public long NroOc { get; set; }
        public string Dpto { get; set; }
        public short UltimoItem { get; set; }
        public int Proveedor { get; set; }
        public string Comprador { get; set; }
        public string Origen { get; set; }
        public short CondPago { get; set; }
        public short TipoTransporte { get; set; }
        public string Fletes { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
        public decimal CostoFlete { get; set; }
        public int ProvAduanal { get; set; }
        public string OrdenCompleta { get; set; }
        public DateTime FechaElaborada { get; set; }
        public DateTime? FechaEstimada { get; set; }
        public DateTime FechaColocada { get; set; }
        public DateTime FechaAnulada { get; set; }
        public DateTime? FechaUltRecep { get; set; }
        public DateTime FechaEnvFirma { get; set; }
        public DateTime FechaRecFirma { get; set; }
        public short Status { get; set; }
        public decimal MontoTotal { get; set; }
        public short UltItemGastos { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaSoliAuto { get; set; }
        public string NroAutorizacio { get; set; }
        public DateTime? FechaNotifica { get; set; }
        public DateTime? FechaEmbarque { get; set; }
        public string NombreProv { get; set; }
        public string OrdenAbierta { get; set; }
        public string TipoOc { get; set; }
    }
}
