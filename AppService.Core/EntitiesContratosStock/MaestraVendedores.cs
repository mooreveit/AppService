using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class MaestraVendedores
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal? ClaseVendedor { get; set; }
        public string Supervisor { get; set; }
        public decimal? Grupo { get; set; }
        public string TlfCelular { get; set; }
        public string Activo { get; set; }
        public string CodigoGrupo { get; set; }
        public string FlagSupervisor { get; set; }
        public string FlagDeGerente { get; set; }
        public string Usuario { get; set; }
        public string Oficina { get; set; }
        public string CodigoRegion { get; set; }
        public string Ficha { get; set; }
        public string FlagRetirado { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public decimal? Override { get; set; }
        public decimal? NroVendedor { get; set; }
        public string GerenteRegion { get; set; }
        public string Asignacion { get; set; }
        public string Cobrador { get; set; }
        public string EMail { get; set; }
        public string Garantia { get; set; }
        public decimal? Comision { get; set; }
        public string FreeLance { get; set; }
    }
}
