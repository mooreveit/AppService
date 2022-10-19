using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy020
    {
        public decimal Recnum { get; set; }
        public int NroAsignacion { get; set; }
        public short Item { get; set; }
        public int Rollo { get; set; }
        public int Programacion { get; set; }
        public short Maquina { get; set; }
        public string DescMaquina { get; set; }
        public short NvaMaquina { get; set; }
        public string NuevaDescMaq { get; set; }
        public string UbicacionAct { get; set; }
        public string CodigoPapel { get; set; }
        public long Kilos { get; set; }
        public string Actualizar { get; set; }
        public string NuevaUbicacion { get; set; }
        public long KgsSobrante { get; set; }
        public string Transaccion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaConsumo { get; set; }
        public long Orden1 { get; set; }
        public long Orden2 { get; set; }
        public long Orden3 { get; set; }
        public long Orden4 { get; set; }
        public long Orden5 { get; set; }
        public long Orden6 { get; set; }
        public string Combinada { get; set; }
    }
}
