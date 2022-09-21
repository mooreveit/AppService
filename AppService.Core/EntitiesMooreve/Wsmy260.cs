using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy260
    {
        public string NroCotizacion { get; set; }
        public DateTime? FechaCot { get; set; }
        public string CodCliente { get; set; }
        public string NomClienteFact { get; set; }
        public string RifClienteFact { get; set; }
        public string DireccionClienteFact { get; set; }
        public string NomClienteEnt { get; set; }
        public string RifClienteEnt { get; set; }
        public string DireccionClienteEnt { get; set; }
        public string ValidCotiz { get; set; }
        public string OrdenCompra { get; set; }
        public short? TipoPago { get; set; }
        public string Observaciones { get; set; }
        public string CodVendedor { get; set; }
        public decimal? Oficina { get; set; }
        public string Contacto { get; set; }
        public string EmailContacto { get; set; }
        public string CargoContacto { get; set; }
        public string ClienteNuevo { get; set; }
        public string Estacion { get; set; }
        public decimal? AnoActual { get; set; }
        public decimal? MesActual { get; set; }
        public decimal? ConsecutivoCot { get; set; }
        public decimal? ConsecutivoOrd { get; set; }
        public string Estado { get; set; }
        public decimal? Tasa { get; set; }
        public DateTime? FechaTasa { get; set; }
        public decimal? Encabezado { get; set; }
        public string MarcaCondPago { get; set; }
        public string CodTeleoperador { get; set; }
        public string CombGrupo { get; set; }
        public decimal? IdContactos { get; set; }
        public decimal? Rtasa { get; set; }
        public string CotizacionOriginal { get; set; }
        public int? Renglon { get; set; }

        public virtual Wsmy373 EncabezadoNavigation { get; set; }
    }
}
