using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class AppGeneralQuotesSimpleGetDto
    {

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
        public string NombreContacto { get; set; }
        public string EmailContacto { get; set; }
        public string ObservacionPostergar { get; set; }
        public decimal IdDireccionFacturar { get; set; }
        public decimal IdDireccionEntregar { get; set; }
        public long IdMtrTipoMoneda { get; set; }
        public string OrdenCompra { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Cotizacion { get; set; }
        public bool FijarPrecioBs { get; set; }
        public string Rif { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string FechaString { get; set; }
        public bool PermiteAdicionarDetalle { get; set; }
        public decimal? PorcFlete { get; set; }
        public decimal IdMunicipio { get; set; }
        public string descripcionMunicipio { get; set; }
     
        public MtrClienteDto MtrClienteDto { get; set; }
     
        public AppStatusQuoteGetDto AppStatusQuoteGetDto { get; set; }
      
        public AppGeneralQuotesActionSheetDto AppGeneralQuotesActionSheetDto { get; set; }
    }
}
