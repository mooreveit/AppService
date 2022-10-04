using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Csmy019
    {
        public decimal Recnum { get; set; }
        public string Cotizacion { get; set; }
        public short? Parte { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoNegocio { get; set; }
        public string ClaseOrden { get; set; }
        public short? OperBasica { get; set; }
        public string CteNuevo { get; set; }
        public string CteEstablecido { get; set; }
        public string OrdenCliente { get; set; }
        public string OrdenNueva { get; set; }
        public string RepetExacta { get; set; }
        public string RepetLimitada { get; set; }
        public string CambioEnCopy { get; set; }
        public string CambioEspecif { get; set; }
        public string Prueba { get; set; }
        public long? OrdenAnterior { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Impresor { get; set; }
        public string ImpoASextos { get; set; }
        public string ImpAOctava { get; set; }
        public string LugarEnviar { get; set; }
        public string InstFacturar { get; set; }
        public string Embarque { get; set; }
        public short MesExist { get; set; }
        public short AnoExist { get; set; }
        public string Vendedor01 { get; set; }
        public string Superv01 { get; set; }
        public short? Grupo01 { get; set; }
        public string Vendedor02 { get; set; }
        public string Superv02 { get; set; }
        public short? Grupo02 { get; set; }
        public short? Porcent01 { get; set; }
        public short? Porcent02 { get; set; }
        public string DesctoGCantid { get; set; }
        public short? Competidor { get; set; }
        public string Factura { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public short? CodDivision { get; set; }
        public string SumaResta { get; set; }
        public int OrdenCambio { get; set; }
        public long Orden { get; set; }
        public short Correlativo { get; set; }
        public short? MesOrden { get; set; }
        public short? DiaOrden { get; set; }
        public short? AnoOrden { get; set; }
        public short MesRegist { get; set; }
        public short DiaRegist { get; set; }
        public short AnoRegist { get; set; }
        public decimal? TotalLista { get; set; }
        public decimal TotalVenta { get; set; }
        public string FlagTransm { get; set; }
        public decimal? Comision { get; set; }
        public string OrdAnulada { get; set; }
        public long? OrdenJobbing { get; set; }
        public short? PaisOrden { get; set; }
        public string TipoOrden { get; set; }
        public string ProcesoBcs { get; set; }
        public string TipoProduccion { get; set; }
        public string MetodoLista { get; set; }
        public string Sobretiro { get; set; }
        public string Bajotiro { get; set; }
        public string Fiscal { get; set; }
        public string CteEntregar { get; set; }
        public string DirecEntregar { get; set; }
        public string RifEntregar { get; set; }
        public string CteFacturar { get; set; }
        public string DirecFacturar { get; set; }
        public string RifFacturar { get; set; }
        public string FlagV19 { get; set; }
        public string OrdenComb { get; set; }
        public string StatusOrden { get; set; }
        public short? MesAjuste { get; set; }
        public string DirecEntregar2 { get; set; }
        public string DirecEntregar3 { get; set; }
        public string DirecFacturar2 { get; set; }
        public string DirecFacturar3 { get; set; }
        public decimal? RtotalLista { get; set; }
        public decimal? RtotalVenta { get; set; }
        public decimal? An8facturar { get; set; }
        public decimal? An8entregar { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
    }
}
