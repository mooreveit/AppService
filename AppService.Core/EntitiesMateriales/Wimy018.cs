using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy018
    {
        public decimal Recnum { get; set; }
        public string Transaccion { get; set; }
        public int RolloEntrada { get; set; }
        public string PapelEntrada { get; set; }
        public long KgsEntrada { get; set; }
        public string PapelSalida { get; set; }
        public long KgsSalida { get; set; }
        public string ZonaSalida { get; set; }
        public decimal MedidaSalida { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public short CausaAjuste { get; set; }
        public string ZonaEntrada { get; set; }
        public decimal MedidaEntrada { get; set; }
    }
}
