using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy613
    {
        public long Id { get; set; }
        public string Cotizacion { get; set; }
        public string CodVendedor { get; set; }
        public string CodCliente { get; set; }
        public string Prospecto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Observaciones { get; set; }
        public string RazonSocial { get; set; }
        public string EmailCliente { get; set; }
        public string Rif { get; set; }
        public string NombreContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public string FlagWebSite { get; set; }
        public short? IdMedio { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public string IdEstatus { get; set; }
        public string FlagConcretado { get; set; }
        public string FlagCerrado { get; set; }
        public int? IdSubCategoria { get; set; }
        public short? Ano { get; set; }
        public short? Mes { get; set; }
        public string PuntoReferencia { get; set; }
    }
}
