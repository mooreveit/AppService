using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class PlanillaDeActualizacion
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string CodigoRegion { get; set; }
        public string CodigoEstado { get; set; }
        public string CodigoCiudad { get; set; }
        public string Telefono { get; set; }
        public string Telefono1 { get; set; }
        public string Fax { get; set; }
        public string Rif { get; set; }
        public string ExentoDeImpuesto { get; set; }
        public string RepresLegal { get; set; }
        public string DiaDeCobro { get; set; }
        public string RazonSocial { get; set; }
        public string OrdenCompra { get; set; }
        public string Expr1 { get; set; }
        public string Cargo { get; set; }
        public string TelefonoOficina { get; set; }
        public string TelefonoPersonal { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
        public DateTime? FechaNac { get; set; }
    }
}
