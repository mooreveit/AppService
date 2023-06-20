using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Control
    {
        public string Corriendomcvta { get; set; }
        public string Corriendomcemb { get; set; }
        public string Corriendovtas { get; set; }
        public decimal? Porcbonomc { get; set; }
        public decimal? AloActual { get; set; }
        public decimal? MesActual { get; set; }
        public decimal? NroCalculoComActual { get; set; }
        public decimal? PorcLc { get; set; }
        public string ProcesandoExistencias { get; set; }
        public string CorriendoComisiones { get; set; }
        public string CorriendoPreciosJde { get; set; }
        public int? MesControlMarketing { get; set; }
        public int? AloControlMarketing { get; set; }
        public DateTime? FechaExistenciasStock { get; set; }
        public int? MesesAtendido { get; set; }
        public int? Añopronostico { get; set; }
        public int? Mespronostico { get; set; }
        public int? DiasPorVencerse { get; set; }
        public decimal? MontoCotizacion { get; set; }
        public int? CaducaInactiva { get; set; }
        public int? DiasValidez { get; set; }
        public int? DiasValidezGob { get; set; }
        public decimal? ConstCqu { get; set; }
        public decimal? ConstMinSqu { get; set; }
        public decimal? ConstMaxSqu { get; set; }
        public decimal? ConstMinDso { get; set; }
        public decimal? ConstMaxDso { get; set; }
        public decimal? ConstMinPmc { get; set; }
        public decimal? ConstMaxPmc { get; set; }
        public decimal? ConstSobMaxPmc { get; set; }
        public decimal? PondCqu { get; set; }
        public decimal? PondSqu { get; set; }
        public decimal? PondDso { get; set; }
        public decimal? PondPmc { get; set; }
        public decimal? PondSmc { get; set; }
        public string ValidarRif { get; set; }
        public decimal? MillarMinEtl { get; set; }
        public decimal? VentaMinEtl { get; set; }
        public decimal? PorcentajeVolumenImpresos { get; set; }
        public decimal? PorcentajeVolumenEtiquetas { get; set; }
        public decimal? PorcentajeVolumenIc { get; set; }
        public decimal? PorcentajeVolumenCpo { get; set; }
        public decimal? PorcentajeVolumenCutSheets { get; set; }
        public decimal? PorcentajeVolumenOfficeProduct { get; set; }
        public byte? MesesCobertura { get; set; }
        public decimal? IndiceRnc { get; set; }
        public decimal? PorcentajeVolumenAdicional { get; set; }
        public decimal? CantidadRetencionesIvaislr { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string EquipoActualizacion { get; set; }
        public short? IdRegistro { get; set; }
        public string CorreoContraloria { get; set; }
        public short? DiasExpSolWeb { get; set; }
        public short? Dias1AlertCaduca { get; set; }
        public short? Dias2AlertCaduca { get; set; }
        public short? Dias3AlertCaduca { get; set; }
        public short? Dias1AlertGrabacion { get; set; }
        public short? DiasEliminaGrabacion { get; set; }
        public decimal? PorcAlertCaduca1 { get; set; }
        public decimal? PorcAlertCaduca2 { get; set; }
        public decimal? PorcAlertCaduca3 { get; set; }
        public string EmailDirector { get; set; }
    }
}
