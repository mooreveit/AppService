using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Vistaclientesweb
    {
        public int? Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Rif { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Telefono { get; set; }
        public string CodArea { get; set; }
        public string CodEstado { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public int? Sucursal { get; set; }
        public string RamoNegocio { get; set; }
        public string SectorNegocio { get; set; }
        public string TipoNegocio { get; set; }
        public string NombreRegion { get; set; }
        public string NomOficina { get; set; }
        public string TipoPago { get; set; }
        public DateTime? UltCompra { get; set; }
        public int? LCredito { get; set; }
        public int? Saldoact { get; set; }
        public string Observacion { get; set; }
        public int? Asignacion { get; set; }
        public string Cobrador { get; set; }
        public string Supervisor { get; set; }
        public string NomSupervisor { get; set; }
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
    }
}
