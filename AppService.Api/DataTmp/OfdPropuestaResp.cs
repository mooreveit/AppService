using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdPropuestaResp
    {
        public long IdPropuesta { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public long IdRenglon { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public int IdEstatus { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string ObsrPropuesta { get; set; }
        public decimal CantXCaja { get; set; }
        public float CantMill { get; set; }
        public decimal Cajas { get; set; }
        public decimal CantFormas { get; set; }
        public string IdSolicitud { get; set; }
        public string RecalcularMargen { get; set; }
        public string CotizacionRenglonPropuesta { get; set; }
        public short UnidadCosteo { get; set; }
        public string IdPresentacion { get; set; }
        public string EstatusPlanta { get; set; }
        public decimal PorcRespSocial { get; set; }
        public decimal PorcComRegulada { get; set; }
        public decimal PorcMcMinimo { get; set; }
        public decimal PorcTolerancia { get; set; }
        public bool FlagAprobado { get; set; }
        public short CambComposicion { get; set; }
        public decimal PorMcFinan { get; set; }
        public bool FlagVolumen { get; set; }
        public decimal PorMcBruto { get; set; }
        public decimal PorcComision { get; set; }
        public decimal FactorSdf { get; set; }
        public decimal? PorcIva { get; set; }
    }
}
