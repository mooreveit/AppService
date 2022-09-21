using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy410
    {
        public decimal Recnum { get; set; }
        public string NumCotizacion { get; set; }
        public long NumOrden { get; set; }
        public long NumJob { get; set; }
        public short NumerCopya { get; set; }
        public short NumerCopyb { get; set; }
        public string NombreCliente { get; set; }
        public long CantEntregar { get; set; }
        public string InstrucProd { get; set; }
        public string PrefContDesde { get; set; }
        public string PrefContHasta { get; set; }
        public string PrefCliDesde { get; set; }
        public string PrefCliHasta { get; set; }
        public int NumContDesde { get; set; }
        public int NumContHasta { get; set; }
        public int NumCliDesde { get; set; }
        public int NumCliHasta { get; set; }
        public string NombFacturar { get; set; }
        public string DireccFacturar { get; set; }
        public string NombEntregar { get; set; }
        public string DireccEntregar { get; set; }
        public string RifFacturar { get; set; }
        public string RifEntregar { get; set; }
        public string ImprimirA { get; set; }
        public string RifImprimir { get; set; }
        public string NombForma { get; set; }
        public string CodigoCliente { get; set; }
        public string SufContDesde { get; set; }
        public string SufContHasta { get; set; }
        public string SufClieDesde { get; set; }
        public string SufClieHasta { get; set; }
        public decimal CantMillEnt { get; set; }
        public long CantMillFact { get; set; }
        public string PrefContDEnt { get; set; }
        public string PrefContHEnt { get; set; }
        public string SufContDEnt { get; set; }
        public string SufContHEnt { get; set; }
        public string PrefClieDEnt { get; set; }
        public string PrefClieHEnt { get; set; }
        public string SufClieDEnt { get; set; }
        public string SufClieHEnt { get; set; }
        public int NumContDEnt { get; set; }
        public int NumContHEnt { get; set; }
        public int NumClieDEnt { get; set; }
        public int NumClieHEnt { get; set; }
        public int NumContDFact { get; set; }
        public int NumContHFact { get; set; }
        public int NumClieDFact { get; set; }
        public int NumClieHFact { get; set; }
        public string PrefContDFac { get; set; }
        public string PrefContHFac { get; set; }
        public string SufContDFac { get; set; }
        public string SufContHFac { get; set; }
        public string PrefClieDFac { get; set; }
        public string PrefClieHFac { get; set; }
        public string SufClieDFac { get; set; }
        public string SufClieHFac { get; set; }
        public string DireccFactura1 { get; set; }
        public string DireccFactura2 { get; set; }
        public string DireccEntrega1 { get; set; }
        public string DireccEntrega2 { get; set; }
        public long CtdEntregada { get; set; }
        public long CtdFacturada { get; set; }
        public int UltimaFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string Producto { get; set; }
        public int? CantUnidEmb { get; set; }
        public short? CodAplicacion { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? Pormc { get; set; }
        public decimal? Rbsmc { get; set; }
        public string Fiscal { get; set; }
        public string TipoDocumento { get; set; }
        public decimal? LongitudMascara { get; set; }
        public decimal? IdDireccionFacturar { get; set; }
        public decimal? IdDireccionEntregar { get; set; }
        public string FlagFacturacionEntrega { get; set; }
        public string FlagCopyNuevo { get; set; }
        public string FlagOrdenCopyAnterior { get; set; }
        public long? OrdenAnterior { get; set; }
        public short? CopyAnterior { get; set; }
    }
}
