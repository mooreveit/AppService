using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy109
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public string Cotizacion { get; set; }
        public decimal? NoForma { get; set; }
        public long NoPartePapel { get; set; }
        public long? CodigoPapel { get; set; }
        public long? ColorPapel { get; set; }
        public string Carbon { get; set; }
        public string TintaFrente1 { get; set; }
        public string TintaFrente2 { get; set; }
        public string TintaFrente3 { get; set; }
        public string TintaFrente4 { get; set; }
        public string TintaFrente5 { get; set; }
        public string TintaRespaldo1 { get; set; }
        public string TintaRespaldo2 { get; set; }
        public string TintaRespaldo3 { get; set; }
        public long? EntMedIrreglr { get; set; }
        public long? NumMedIrreglr { get; set; }
        public long? DenMedIrreglr { get; set; }
        public long? PerforacionHor { get; set; }
        public long? PerforacionVer { get; set; }
        public long? EntTalonIzq { get; set; }
        public long? NumTalonIzq { get; set; }
        public long? DenTalonIzq { get; set; }
        public long? EntTalonDer { get; set; }
        public long? NumTalonDer { get; set; }
        public long? DenTalonDer { get; set; }
        public string FraseMarginal { get; set; }
        public long? PosicionTalon { get; set; }
        public string MedidaCarrbon { get; set; }
        public string Codcarbon { get; set; }
        public short? BasePapel { get; set; }
        public string Abreviado { get; set; }
        public decimal? Medcarbonent { get; set; }
        public string CarbonSpot { get; set; }
        public string TintaRespaldo4 { get; set; }
        public string TintaRespaldo5 { get; set; }
    }
}
