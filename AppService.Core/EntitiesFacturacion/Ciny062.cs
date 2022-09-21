using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny062
    {
        public decimal Recnum { get; set; }
        public short CentroFac { get; set; }
        public string Lugar { get; set; }
        public int Factura { get; set; }
        public int ComprbFiscal { get; set; }
        public long OrdenCliente { get; set; }
        public long OrdenConsecuti { get; set; }
        public string ImpAcum { get; set; }
        public string ImpIndiv { get; set; }
        public string Gastos { get; set; }
        public string Redondear { get; set; }
        public decimal TipoCambio { get; set; }
        public DateTime? FechaCambio { get; set; }
        public DateTime? FechaDia { get; set; }
        public int CteContado { get; set; }
        public short Vendedor { get; set; }
        public decimal CxcPais1 { get; set; }
        public decimal CxcPais2 { get; set; }
        public decimal CxcPais3 { get; set; }
        public decimal CxcPais4 { get; set; }
        public decimal CxcPais5 { get; set; }
        public decimal CxcPais6 { get; set; }
        public short Impuesto1 { get; set; }
        public short Impuesto2 { get; set; }
        public short Impuesto3 { get; set; }
        public short Impuesto4 { get; set; }
        public short Impuesto5 { get; set; }
        public string CtaCobrar { get; set; }
        public string InvAutomatico { get; set; }
        public int Remision { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public decimal Imp { get; set; }
        public string Atencion1 { get; set; }
        public string Atencion2 { get; set; }
        public string Atencion3 { get; set; }
        public short OficinaVenta { get; set; }
        public string CruzaCxc { get; set; }
        public string ColetillaDol1 { get; set; }
        public string ColetillaDol2 { get; set; }
        public string ColetillaDol3 { get; set; }
        public string ColetillaDol4 { get; set; }
        public string ObsCobranzas1 { get; set; }
        public string ObsCobranzas2 { get; set; }
        public string ObsCobranzas3 { get; set; }
        public string ObsCobranzas4 { get; set; }
        public string ColetillaInd1 { get; set; }
        public string ColetillaInd2 { get; set; }
        public string ColetillaInd3 { get; set; }
        public string ColetillaInd4 { get; set; }
        public string PrintDolFact { get; set; }
        public string TomarDolActua { get; set; }
    }
}
