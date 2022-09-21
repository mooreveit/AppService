using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class OfdCotizacionDto
    {

        public long IdCotizacion { get; set; }
        public string Cotizacion { get; set; }
        public string IdVendedor { get; set; }
        public string IdCliente { get; set; }
        public string IdProspecto { get; set; }
        public DateTime Fecha { get; set; }
        public string ObsvCotizacion { get; set; }
        public short DiasVigencia { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public DateTime? FechaPostergada { get; set; }
        public int IdEstatus { get; set; }
        public short IdCondPago { get; set; }
        public long IdContacto { get; set; }
        public string ObservacionPostergar { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
        public decimal IdDireccionFacturar { get; set; }
        public decimal IdDireccionEntregar { get; set; }
        public string OrdenCompra { get; set; }
        public short IdMedio { get; set; }
        public bool FlagValidado { get; set; }
    }
}
