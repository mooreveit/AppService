using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry062
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public DateTime? FechaAct { get; set; }
        public string Persona { get; set; }
        public short CodAnulacion { get; set; }
        public int NroAnulacion { get; set; }
        public string Observacion1 { get; set; }
        public string Observacion2 { get; set; }
        public string Tipo { get; set; }
        public short Mes { get; set; }
        public short Ano { get; set; }
        public string Hora { get; set; }
        public string CodProducto { get; set; }
        public string FlagSms { get; set; }
        public string Anulado { get; set; }
    }
}
