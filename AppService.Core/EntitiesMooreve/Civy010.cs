using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Civy010
    {
        public decimal Recnum { get; set; }
        public short Bodega { get; set; }
        public string Codigo { get; set; }
        public string OrigenProducto { get; set; }
        public string LineaProducto { get; set; }
        public string FamiliaProduct { get; set; }
        public string TipoProducto { get; set; }
        public int ExistAnterior { get; set; }
        public int ExistActual { get; set; }
        public int Comprometido { get; set; }
        public int ExisIniMes { get; set; }
        public decimal CostIniMes { get; set; }
        public decimal ListaIniMes { get; set; }
        public int EntradasMes { get; set; }
        public int SalidasMes { get; set; }
        public int ExisFinMes { get; set; }
        public decimal CostFinMes { get; set; }
        public decimal ListaFinMes { get; set; }
        public int ExistMaxima { get; set; }
        public int ExistMinima { get; set; }
        public int PtoReorden { get; set; }
        public int SalidaPendien { get; set; }
        public short Ano { get; set; }
        public string Ubicacion1 { get; set; }
        public string Ubicacion2 { get; set; }
        public string Ubicacion3 { get; set; }
        public string Ubicacion4 { get; set; }
        public string Ubicacion5 { get; set; }
        public DateTime? FechaUltEntra { get; set; }
        public DateTime? FechaUltSalid { get; set; }
    }
}
