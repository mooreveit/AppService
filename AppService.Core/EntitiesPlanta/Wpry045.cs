using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry045
    {
        public decimal Recnum { get; set; }
        public string CodigoPapel { get; set; }
        public long KilosBacklog { get; set; }
        public long ExistDisp { get; set; }
        public long Dif1 { get; set; }
        public long KilosTransito { get; set; }
        public long ProyeccionExis { get; set; }
        public long Dif2 { get; set; }
        public short DiasEntrega { get; set; }
        public short MesesDespacho { get; set; }
        public string Plan { get; set; }
        public string Prel { get; set; }
        public string Prog { get; set; }
        public string Pren { get; set; }
        public string Clientes { get; set; }
        public string StockCpo { get; set; }
        public string IntImp { get; set; }
        public string Ccs { get; set; }
        public string Medida { get; set; }
    }
}
