using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cev003
    {
        public byte IdRegistro { get; set; }
        public decimal VolumenImpresos { get; set; }
        public decimal VolumenEtiquetas { get; set; }
        public decimal VolumenImpresionComercial { get; set; }
        public decimal VolumenCpo { get; set; }
        public decimal VolumenCutSheets { get; set; }
        public decimal VolumenOfficeProduct { get; set; }
        public decimal NumeroOrdenesImpresas { get; set; }
        public decimal DiasCalle { get; set; }
        public decimal ClientesNuevos { get; set; }
        public decimal MesesCobertura { get; set; }
        public decimal IndiceRnc { get; set; }
        public decimal PorcentajeMc { get; set; }
        public decimal VolumenAdicional { get; set; }
        public decimal CantidadRetencionesIvaislr { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string EquipoRegistro { get; set; }
    }
}
