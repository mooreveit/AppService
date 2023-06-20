using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Ventasin
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public short Correlativo { get; set; }
        public short Renglon { get; set; }
        public string Producto { get; set; }
        public string NomProducto { get; set; }
        public string Tipo { get; set; }
        public short Clase { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
        public string Supervisor { get; set; }
        public string TipoVend { get; set; }
        public string Grupo { get; set; }
        public string Cotizacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public short Partes { get; set; }
        public decimal MillaresP { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorLista { get; set; }
        public short MesContable { get; set; }
        public short AloContable { get; set; }
        public string ZonaVta { get; set; }
        public string RegionVta { get; set; }
        public string TipoPapel { get; set; }
        public string MetodoLista { get; set; }
        public string TipoProdu { get; set; }
        public string Territorio { get; set; }
        public int NotaCambio { get; set; }
        public long Formas { get; set; }
        public string Basica { get; set; }
        public string Opuesta { get; set; }
        public short Conteo { get; set; }
        public string Codmos { get; set; }
        public string Fiscal { get; set; }
        public string CodPro { get; set; }
        public string CodproRpg { get; set; }
        public string Flag { get; set; }
        public string Codcorp { get; set; }
        public short MesReorden { get; set; }
        public short AnoReorden { get; set; }
        public string LineaProduc { get; set; }
        public string NombOfic { get; set; }
        public string Temp { get; set; }
        public string Descripcion { get; set; }
        public string NombreDeForma { get; set; }
        public decimal ListaDol { get; set; }
        public decimal VentaDol { get; set; }
        public decimal Tasa { get; set; }
        public decimal POverger { get; set; }
        public decimal Overger { get; set; }
        public decimal PComision { get; set; }
        public decimal Comision { get; set; }
        public decimal POverride { get; set; }
        public decimal Override { get; set; }
        public string Familia { get; set; }
        public string ManualAuto { get; set; }
        public decimal Bsmc { get; set; }
        public decimal Pormc { get; set; }
    }
}
