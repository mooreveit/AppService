using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppGeneralQuote
    {
        public AppGeneralQuote()
        {
            AppDetailQuotes = new HashSet<AppDetailQuote>();
        }

        public int Id { get; set; }
        public string IdVendedor { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public int DiasVigencia { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public DateTime? FechaPostergada { get; set; }
        public int IdEstatus { get; set; }
        public short IdCondPago { get; set; }
        public long IdContacto { get; set; }
        public string ObservacionPostergar { get; set; }
        public decimal IdDireccionFacturar { get; set; }
        public decimal IdDireccionEntregar { get; set; }
        public string OrdenCompra { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Cotizacion { get; set; }
        public string SearchText { get; set; }
        public int? Proximo { get; set; }
        public long? IdMtrTipoMoneda { get; set; }
        public bool? FijarPrecioBs { get; set; }
        public string Rif { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public decimal? IdMunicipio { get; set; }
        public string DescripcionMunicipio { get; set; }
        public bool? IntegrarCotizacion { get; set; }
        public long? Orden { get; set; }
        public long? OrdenAnterior { get; set; }
        public bool? Actualizar { get; set; }
        public bool? EnviarAlCliente { get; set; }
        public bool? EnviarAprobacionPrecio { get; set; }
        public bool? GanarPerder { get; set; }
        public bool? Postergar { get; set; }
        public bool? Eliminar { get; set; }
        public bool? Cancel { get; set; }
        public bool? ExistQuotes { get; set; }
        public bool? Imprimir { get; set; }
        public bool? RetornarAgrabacion { get; set; }
        public bool? TieneOrden { get; set; }

        public virtual MtrCliente IdClienteNavigation { get; set; }
        public virtual MtrContacto IdContactoNavigation { get; set; }
        public virtual AppStatusQuote IdEstatusNavigation { get; set; }
        public virtual MtrTipoMonedum IdMtrTipoMonedaNavigation { get; set; }
        public virtual MtrVendedor IdVendedorNavigation { get; set; }
        public virtual ICollection<AppDetailQuote> AppDetailQuotes { get; set; }
    }
}
