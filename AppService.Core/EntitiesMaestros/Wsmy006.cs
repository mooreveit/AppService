using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wsmy006
    {
        public short CodCategoria { get; set; }
        public string DesCategoria { get; set; }
        public string FlagSupervisor { get; set; }
        public string FlagDeGerente { get; set; }
        public string FlagGerenteOf { get; set; }
        public string FlagComision { get; set; }
        public string FlagEstadisti { get; set; }
        public string FlagDesactivo { get; set; }
        public string FlagNoAprob { get; set; }
        public string FlagVendedor { get; set; }
        public int? NumeroOrdenesImpresas { get; set; }
        public int? ClientesNuevos { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string EquipoActualizacion { get; set; }
    }
}
