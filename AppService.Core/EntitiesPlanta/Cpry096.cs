using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry096
    {
        public decimal Recnum { get; set; }
        public int NoPedido { get; set; }
        public int Cliente { get; set; }
        public DateTime? Fecha { get; set; }
        public string TipoNegocio { get; set; }
        public short OperBasica { get; set; }
        public string CteNuevo { get; set; }
        public string CteEstablecido { get; set; }
        public string OrdenCliente { get; set; }
        public string OrdenNueva { get; set; }
        public string RepetExacta { get; set; }
        public string RepetLimitada { get; set; }
        public string CambioEnCopy { get; set; }
        public string CambioEspecif { get; set; }
        public string Prueba { get; set; }
        public string OrdenAnterior { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Impresor { get; set; }
        public string ImpoASextos { get; set; }
        public string ImpAOctava { get; set; }
        public string LugarEnviar { get; set; }
        public string InstFacturar { get; set; }
        public string Embarque { get; set; }
        public short MesExist { get; set; }
        public string AnoExist { get; set; }
        public string Vendedor01 { get; set; }
        public string Superv01 { get; set; }
        public short Grupo01 { get; set; }
        public string Vendedor02 { get; set; }
        public string Superv02 { get; set; }
        public short Grupo02 { get; set; }
        public short Porcent01 { get; set; }
        public short Porcent02 { get; set; }
        public string DesctoGCantid { get; set; }
        public string Factura { get; set; }
        public short CodDivision { get; set; }
        public short Correlativo { get; set; }
        public long Orden { get; set; }
        public string FlagImpres { get; set; }
        public string NoDiseno { get; set; }
        public short PaisProcedenci { get; set; }
        public short TipoOrden { get; set; }
    }
}
